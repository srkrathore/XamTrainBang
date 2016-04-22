using SQLite.Net;

namespace XamTrainBang
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
