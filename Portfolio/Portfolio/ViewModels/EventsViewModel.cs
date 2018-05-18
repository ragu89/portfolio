using GalaSoft.MvvmLight.Messaging;
using Portfolio.Models;
using Portfolio.Services;
using Portfolio.ViewModels.Interfaces;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Portfolio.ViewModels
{
    public class EventsViewModel : BaseViewModel, IEventsViewModel
    {
        public EventsViewModel(IDataStore dataStore, IMessenger messenger) : base(dataStore, messenger)
        {
            Title             = "Calendar";
            Events            = new ObservableCollection<Event>();
            LoadEventsCommand = DoLess.Commands.Command.CreateFromTask(ExecuteLoadEventsCommand);
        }

        ObservableCollection<Event> events;
        public ObservableCollection<Event> Events
        {
            get => events;
            set { Set(ref events, value); }
        }

        public ICommand LoadEventsCommand { get; private set; }

        async Task ExecuteLoadEventsCommand()
        {
            if (IsBusy) return;

            IsBusy = true;

            try
            {
                var events = await DataStore?.GetEventsAsync(true);

                Events.Clear();
                foreach (var ev in events)
                {
                    Events.Add(ev);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}