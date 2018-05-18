
using GalaSoft.MvvmLight.Messaging;
using Portfolio.Models;
using Portfolio.Services;
using Portfolio.ViewModels.Interfaces;

namespace Portfolio.ViewModels
{
    public class EventDetailViewModel : BaseViewModel, IEventDetailViewModel
    {
        public EventDetailViewModel(IDataStore dataStore, IMessenger messenger) : base(dataStore, messenger)
        {
            //TODO: Messenger.Register
        }

        Event _event;

        public Event Event
        {
            get => _event;
            set
            {
                Set(ref _event, value);
                Title = value?.Title;
            }
        }
    }
}
