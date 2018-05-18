
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using Portfolio.Models;
using Portfolio.Services;

namespace Portfolio.ViewModels
{
    public class BaseViewModel : ViewModelBase
    {
        public BaseViewModel(IDataStore dataStore, IMessenger messenger)
        {
            DataStore = dataStore;
            Messenger = messenger;
        }

        protected IDataStore DataStore { get; private set; }
        protected IMessenger Messenger { get; private set; }

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { Set(ref isBusy, value); }
        }

        string title = string.Empty;
        public string Title
        {
            get { return title; }
            set { Set(ref title, value); }
        }
    }
}
