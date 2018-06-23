using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace PosX.App.Entity
{
    public class SqLiteBaseRepository
    {
        public static string DbFile
        {
            get { return Environment.CurrentDirectory + "\\Data\\posx.db"; }
        }

        public static SQLiteConnection  DbConnection()
        {
            return new SQLiteConnection("Data Source=" + DbFile);
        }
    }
}
