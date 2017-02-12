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
using SQLite;

namespace XamarinLayouts.Droid.Entities
{
    public class ClientEntity
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateBirth { get; set; }


        public override string ToString()
        {
            return string.Format("[ClientEntity: ID={0}, Name={1}, Email={2}, DateBirth={3}]", ID, Name, Email, DateBirth);
        }
    }
}
