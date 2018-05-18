using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Portfolio.Models;
using Portfolio.Views;
using Portfolio.ViewModels;
using Portfolio.Services;
using Portfolio.ViewModels.Interfaces;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;

namespace Portfolio.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EventsPage : ContentPage
	{
        public EventsPage()
        {
            InitializeComponent();

            BindingContext = ViewModel;
        }

        IEventsViewModel ViewModel => SimpleIoc.Default.GetInstance<IEventsViewModel>();
        IMessenger _mess = Messenger.Default;

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var ev = args.SelectedItem as Event;
            if (ev == null) return;

            var eventDetailViewModel = SimpleIoc.Default.GetInstance<IEventDetailViewModel>();
            eventDetailViewModel.Event = ev;

            //TODO: NavigationService
            // https://mallibone.com/post/a-simple-navigation-service-for-xamarinforms
            // https://marcominerva.wordpress.com/2016/07/11/a-simple-navigationservice-for-xamarin-forms/
            // http://www.mvvmlight.net/doc/nav1.cshtml
            // http://blog.galasoft.ch/posts/?s=navigationservice
            // https://mallibone.com/post/xamarin.forms-navigation-with-mvvm-light
            // https://gist.github.com/twolfprogrammer/8df2a80e3afb67485ea6b917d27d54f4
            //
            await Navigation.PushAsync(new EventDetailPage());

            EventsListView.SelectedItem = null;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (ViewModel.Events.Count == 0)
                ViewModel.LoadEventsCommand.Execute(null);
        }
    }
}