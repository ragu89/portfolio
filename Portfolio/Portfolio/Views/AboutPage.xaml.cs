using GalaSoft.MvvmLight.Ioc;
using Portfolio.Services;
using Portfolio.ViewModels;
using Portfolio.ViewModels.Interfaces;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Portfolio.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AboutPage : ContentPage
	{
		public AboutPage()
		{
			InitializeComponent ();

            BindingContext = ViewModel;
        }

        IAboutViewModel ViewModel => SimpleIoc.Default.GetInstance<IAboutViewModel>();
    }
}