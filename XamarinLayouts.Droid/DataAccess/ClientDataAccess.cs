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
using XamarinLayouts.Droid.Entities;

namespace XamarinLayouts.Droid.DataAccess
{
    public class ClientDataAccess
    {

        public ClientEntity[] ListClients(int count)
        {
            ClientEntity[] list = new ClientEntity[count];

            for (int i = 0; i < count; i++)
            {
                list[i] = new ClientEntity { Name = "nome" + i, Email = "email" + i, DateBirth = DateTime.Now.AddDays(i) };
            }

            return list;
        }

    }
}