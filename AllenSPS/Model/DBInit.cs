using System;
using Xamarin.Forms;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using SQLitePCL;
using System.Diagnostics;


namespace AllenSPS
{
	public class DBInit
	{
		readonly SQLiteConnection db;


		public DBInit ()
		{   
			
			db = DependencyService.Get<ISQLite>().GetConnection();

			locationdetailsInit(db);
			NotificationInit (db);
			//personInit(db);
			//searchlocationInit(db);
			//List<person> p = db.Table<person>().ToList();
			//p [0].Name;
			//Debug.WriteLine (p [0].Name);
		}

		public IEnumerable<locationdetails> GetDetails()
		{

			return (from t in db.Table<locationdetails>() select t).ToList();

		}

		public IEnumerable<Notification> GetNotification()
		{

			return (from t in db.Table<Notification>() select t).ToList();

		}

		public void locationdetailsInit(SQLiteConnection db)
		{
			
			if (db.Table<locationdetails> ().Count () != 0) {
				db.DropTable<locationdetails> ();
				db.CreateTable<locationdetails> ();
				var LD = new locationdetails ();
				LD.Locationname = "qut";
				LD.ImageName = "QUTimage";
				LD.SpotNumber = 15;
				LD.Distance = 3.5;
				LD.MaximalPT = 6;
				db.Insert (LD);
				var LD2 = new locationdetails ();
				LD2.Locationname = "Alice ST";
				LD2.ImageName = "Alice";
				LD2.SpotNumber = 20;
				LD2.Distance = 5.2;
				LD2.MaximalPT = 4;
				db.Insert (LD2);
				var LD3 = new locationdetails ();
				LD3.Locationname = "Willon ST";
				LD3.ImageName = "WillonST";
				LD3.SpotNumber = 30;
				LD3.Distance = 6.7;
				LD3.MaximalPT = 3;
				db.Insert (LD3);

			}
	    }


			public void personInit(SQLiteConnection db)
			{
			db.CreateTable<person> ();
			if (db.Table<person> ().Count () == 0) {
				var person = new person ();
				person.Name = "JON";
				person.PlateNumber = "ASAS111";
				person.PhoneNumber = 03212121;
				person.ParkingET = "3.10PM";
				person.ParkingST = "5.10PM";
				db.Insert (person);
			}
			}


			public void searchlocationInit(SQLiteConnection db)


		{
			db.CreateTable<searchlocation> ();
			if (db.Table<searchlocation> ().Count () == 0) {
				var SL = new searchlocation ();
				SL.locationname = "qut";
				SL.locationname = "garden city";
				SL.locationname = "West feild";
				db.Insert (SL);	
			}
		}

		public void NotificationInit(SQLiteConnection db)


		{
			db.CreateTable<Notification> ();
			if (db.Table<Notification> ().Count () == 0) {
				var Notify = new Notification ();
				Notify.PlateNumber = "AAAA123";
				Notify.NotiMessage = "Violation vehicle slot: A4";
				Notify.ViolationType = "Overstay";
				db.Insert (Notify);	
			
				var Notify2 = new Notification ();
				Notify2.PlateNumber = "BBB123";
				Notify2.NotiMessage = "Violation vehicle slot: C3";
				Notify2.ViolationType = "Parking without payment";
				db.Insert (Notify2);

				var Notify3 = new Notification ();
				Notify3.PlateNumber = "CCC123";
				Notify3.NotiMessage = "Violation vehicle slot: D4";
				Notify3.ViolationType = "Overstay";
				db.Insert (Notify3);
			}
		}





}
}
