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
using System.IO;
using SQLite;
using XamarinLayouts.Droid.Entities;

namespace XamarinLayouts.Droid
{
    public class Util
    {
        public static string PathDataBase()
        {
            var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            path = Path.Combine(path, "base.db3");

            return path;
        }

        public static void CreateDatabaseClient(string path)
        {
            var connection = new SQLiteConnection(path);
            connection.CreateTable<ClientEntity>();
        }

        public static void InsertUpdateClient(ClientEntity data, string path)
        {
            var db = new SQLiteConnection(path);
            if (db.Insert(data).Equals(0))
                db.Update(data);
        }

        public static TableQuery<ClientEntity> SelectClient(string path)
        {
            var conn = new SQLiteConnection(path);
            var itens = from s in conn.Table<ClientEntity>() select s;

            return itens;
        }
    }
}