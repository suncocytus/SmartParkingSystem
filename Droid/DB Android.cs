using System;
using System.IO;
using Xamarin.Forms;
using AllenSPS;
using AllenSPS.Droid;
using SQLite;

[assembly:Dependency (typeof(DB_Android))]
namespace AllenSPS.Droid
{	
	public class DB_Android : ISQLite
	{
		public DB_Android (){

		}

		public SQLite.SQLiteConnection GetConnection()
		{
			var sqlFilename="SPS.db3";
			string documentsPath = System.Environment.GetFolderPath (System.Environment.SpecialFolder.Personal);
			var path = Path.Combine (documentsPath,sqlFilename);
			var conn = new SQLiteConnection (path);
			return conn;
		}

	}
}
