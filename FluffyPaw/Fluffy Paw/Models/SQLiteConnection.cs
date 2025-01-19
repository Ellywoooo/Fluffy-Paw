namespace Fluffy_Paw.Models
{
    internal class SQLiteConnection
    {
        public SQLiteConnection(string dbPath)
        {
            DbPath = dbPath;
        }

        public string DbPath { get; }
    }
}