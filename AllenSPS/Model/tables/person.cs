using System;
using SQLite;

namespace AllenSPS
{
	public class person

	{
		[PrimaryKey]
		public string Name { get; set;}

		public string PlateNumber { get; set;}

		public int PhoneNumber { get; set;}

		public string ParkingST { get; set;}

		public string ParkingET { get; set;}


		
	}
}

