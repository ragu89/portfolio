using GalaSoft.MvvmLight.Messaging;
using Portfolio.Services;
using Portfolio.ViewModels.Interfaces;
using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace Portfolio.ViewModels
{
    public class AboutViewModel : BaseViewModel, IAboutViewModel
    {
        public AboutViewModel(IDataStore dataStore, IMessenger messenger) : base(dataStore, messenger)
        {
            Title = "About";

            OpenWebCommand = DoLess.Commands.Command.CreateFromAction(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}