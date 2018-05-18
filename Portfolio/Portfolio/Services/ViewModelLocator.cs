using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using Portfolio.ViewModels;
using Portfolio.ViewModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portfolio.Services
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            RegisterServices();

            RegisterViewModels();
        }

        static void RegisterServices()
        {
            SimpleIoc.Default.Register<IDataStore, MockDataStore>();
            SimpleIoc.Default.Register<IMessenger, Messenger>();
        }

        static void RegisterViewModels()
        {
            SimpleIoc.Default.Register<IAboutViewModel, AboutViewModel>();
            SimpleIoc.Default.Register<IEventDetailViewModel, EventDetailViewModel>();
            SimpleIoc.Default.Register<IEventsViewModel, EventsViewModel>();
        }
    }
}
