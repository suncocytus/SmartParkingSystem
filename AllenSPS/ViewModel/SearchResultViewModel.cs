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
	public class SearchResultViewModel : ViewModelBase
	{
		private IEnumerable<locationdetails> SRdetails;

		public SearchResultViewModel ()
		{
			var db = new DBInit ();
			SRdetails = db.GetDetails ();


		}

		public IEnumerable<locationdetails> SRDetails {

			get{ 

				return this.SRdetails;
			}

			set{  
				this.SRdetails = value;

			}

		}
	}
}

