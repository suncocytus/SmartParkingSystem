using System;
using AllenSPS;
using Xamarin.Forms;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;

namespace AllenSPS
{
	public class OnStreetViewModel : ViewModelBase
	{
		public OnModel OnModel { get; set;}
		public ICommand NavigateCommand { get; private set; }
		public OnStreetViewModel()
		{
			OnModel = new OnModel {

				Name = "Sun",
				PlateNumber = "AAAAAAA",
				PhoneNumber = 041334291,
				ParkingST =  "9:10",
				ParkingET = "11:10",
                
				
			};

			NavigateCommand = new Command (() => {
				
			});
		}
			
	}
}

