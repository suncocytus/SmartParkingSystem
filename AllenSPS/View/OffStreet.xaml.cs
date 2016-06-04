using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AllenSPS
{
	public partial class OffStreet : ContentPage
	{
		public OffStreet ()
		{
			InitializeComponent ();
		}
		private async void ReserveButton_OnClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new OffST_UserDetail());
		}
	}
}

