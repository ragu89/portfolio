using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Portfolio.Models;
using Portfolio.ViewModels;
using Portfolio.Services;
using Portfolio.ViewModels.Interfaces;
using GalaSoft.MvvmLight.Ioc;

namespace Portfolio.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EventDetailPage : ContentPage
	{
        EventDetailViewModel viewModel;

        public EventDetailPage()
        {
            InitializeComponent();

            BindingContext = ViewModel;
        }

        IEventDetailViewModel ViewModel => SimpleIoc.Default.GetInstance<IEventDetailViewModel>();
    }
}