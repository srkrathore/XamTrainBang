using System;
using System.IO;
using SQLite.Net;
using Xamarin.Forms;
using XamTrainBang.Droid;

[assembly: Dependency(typeof(SqliteService))]
namespace XamTrainBang.Droid
{
    public class SqliteService : ISQLite
    {
        public SqliteService() { }
        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "MyAppSQLite.db3";
            string documentsPath = Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
            var path = Path.Combine(documentsPath, sqliteFilename);

            // This is where we copy in the prepopulated database
            Console.WriteLine(path);
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            var plat = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            var conn = new SQLite.Net.SQLiteConnection(plat, path);

            // Return the database connection 
            return conn;
        }
    }
}