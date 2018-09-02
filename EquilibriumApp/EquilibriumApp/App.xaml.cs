﻿using System;
using Xamarin.Forms;
using EquilibriumApp.Views;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace EquilibriumApp
{
	public partial class App : Application
	{
		
		public App ()
		{
			InitializeComponent();


            MainPage = new EquilibriumApp.Views.Login();
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
