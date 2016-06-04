using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AllenSPS
{
	public partial class UserDetail : ContentPage
	{
		public UserDetail (locationdetails SearchResultList)
		{
			InitializeComponent ();

		}



		private async void ConfirmButton_OnClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Final_UserPage());
		}

	}






}

