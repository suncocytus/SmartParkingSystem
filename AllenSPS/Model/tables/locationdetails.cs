using System;
using SQLite;

namespace AllenSPS
{
	public class locationdetails
	{
		[PrimaryKey]
		public string Locationname { get ; set;}
		public string ImageName { get ; set ;}
		public int SpotNumber { get ; set;}
		public double Distance { get; set;}
		public int MaximalPT { get; set;}

	}
}

