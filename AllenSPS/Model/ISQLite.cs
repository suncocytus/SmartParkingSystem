using System;
using SQLite;


namespace AllenSPS
{
	public interface ISQLite{
		SQLiteConnection GetConnection();
	}
}
