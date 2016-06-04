using System;
using System.Collections.Generic;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using AllenSPS;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace AllenSPS
{
	public partial class driverMainpage : ContentPage
	{
		public driverMainpage ()
		{
			InitializeComponent ();
			DBInit db = new DBInit ();
			//BindingContext = new MaindriverIVM(SimpleIoc.Default.GetInstance<INavigationService>());

		}

		private async void NavigateButton_OnClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new SearchPage());
		}
		private async void NavigateButton1_OnClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new OfficerPage());
		}

	}
}

