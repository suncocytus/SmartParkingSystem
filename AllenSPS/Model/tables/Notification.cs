using System;
using SQLite;

namespace AllenSPS
{
	public class Notification
	{
		[PrimaryKey]
		public String PlateNumber { get ; set;}

		public string NotiMessage { get ; set ;}

		public string ViolationType { get ; set;}


	}
}

