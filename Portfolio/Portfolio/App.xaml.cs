using System;
using Portfolio.Services;
using Portfolio.Views;
using Xamarin.Forms;

namespace Portfolio
{
	public partial class App : Application
	{

		public App ()
		{
			InitializeComponent();

            new ViewModelLocator();
            MainPage = new MainPage();
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
