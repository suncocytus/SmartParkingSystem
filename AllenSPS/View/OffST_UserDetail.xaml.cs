using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AllenSPS
{
	public partial class OffST_UserDetail : ContentPage
	{
		public OffST_UserDetail ()
		{
			InitializeComponent ();
		}
		private async void ConfirmButton_OnClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Final_UserPage());
		}

	}
}

