using System;
using System;
using Xamarin.Forms;
using GalaSoft.MvvmLight;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;

namespace AllenSPS
{
	public class NotificationViewModel : ViewModelBase
	{

		private IEnumerable<Notification> Notifydetails;

		public NotificationViewModel ()
		{
			var db = new DBInit ();
			Notifydetails = db.GetNotification ();


		}

		public IEnumerable<Notification> NotifyDetails 
		{

			get{ 

				return this.Notifydetails;
			}

			set{  
				this.Notifydetails = value;

			}

		}
	}



}

