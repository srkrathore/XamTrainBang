using SQLite.Net;
using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace XamTrainBang
{

    public class DataAccess
    {
        static object locker = new object();
        SQLiteConnection dbConn;
       public  DataAccess() {
            dbConn = DependencyService.Get<ISQLite>().GetConnection();
            dbConn.CreateTable<AppUser>();
        }
        public int SaveUser(AppUser aIUser)
        {
            lock (locker)
            {
                return dbConn.Insert(aIUser);
            }
        }

        public IEnumerable<AppUser> GetAllUser()
        {
            lock (locker)
            {
                return dbConn.Query<AppUser>("Select * From [AppUser]");
            }
        }
        public AppUser GetSingleUser(int iUserId)
        {
            lock (locker)
            {
                return dbConn.Table<AppUser>().FirstOrDefault(x => x.UserId == iUserId);
            }
        }

    }

    public class AppUser
    {
        [PrimaryKey, AutoIncrement]
        public long UserId
        { get; set; }
        public string UserName
        { get; set; }
        public DateTime DateOfBirth
        { get; set; }
        public DateTime TimeOfBirth
        { get; set; }
        public string Gender
        { get; set; }
        public string State
        { get; set; }
        public string Qualification
        { get; set; }
        public string LoginPass
        { get; set; }

    }
}
