using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AllenSPS
{
	public partial class ViolationParkingNotification : ContentPage
	{
		public ViolationParkingNotification ()
		{
			InitializeComponent ();
			BindingContext = new NotificationViewModel ();
		}
		public void NotificationTapped(object sender, ItemTappedEventArgs args)

		{

			var NotificationMEList = args.Item as Notification;

			if (NotificationMEList == null)
				return;
			Navigation.PushAsync(new Contact(NotificationMEList));
			NotificationList.SelectedItem = null;

		}



	}
}

