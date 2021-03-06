﻿using System;
using System.IO;
using Xamarin.Forms;
using SQLite;
using SQLitePCL;
using AllenSPS;
using AllenSPS.iOS;

[assembly:Dependency(typeof (DB_iOS))]
namespace AllenSPS.iOS
{	
	public class DB_iOS:ISQLite
	{

		public DB_iOS(){
		}

		public SQLite.SQLiteConnection GetConnection()
		{

			var sqlFilename = "Allen.db3";
			string documentsPath = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
			string libraryPath = Path.Combine (documentsPath, "..", "Library");
			var path = Path.Combine (libraryPath,sqlFilename);
			var conn = new SQLite.SQLiteConnection (path);
			return conn;
		}



	}

}
