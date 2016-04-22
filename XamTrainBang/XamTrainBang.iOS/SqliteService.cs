using System;
using SQLite.Net;
using Xamarin.Forms;
using XamTrainBang.iOS;
using System.IO;

[assembly: Dependency(typeof(SqliteService))]
namespace XamTrainBang.iOS
{
    public class SqliteService : ISQLite
    {
        public SqliteService() { }

        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "MyAppSQLite.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
            string libraryPath = Path.Combine(documentsPath, "..", "Library"); // Library folder
            var path = Path.Combine(libraryPath, sqliteFilename);

            // This is where we copy in the prepopulated database
           // Console.WriteLine(path);
            if (!File.Exists(path))
            {
                File.Create(path);
            }

            var plat = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
            var conn = new SQLite.Net.SQLiteConnection(plat, path);

            // Return the database connection 
            return conn;
        }
    }
}
