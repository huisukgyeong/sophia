using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using YWWAC.core.Interfaces;
using SQLite.Net;
using System.IO;
using System.Diagnostics;

namespace YWWAC.Droid.Database
{
    class SqliteDroid : ISqlite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "YWWACSQLite.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFilename);
            var conn = new SQLiteConnection(new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid(), path);
            return conn;
        }
    }
}