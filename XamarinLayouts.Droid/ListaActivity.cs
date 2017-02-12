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
using XamarinLayouts.Droid.Adapters;
using XamarinLayouts.Droid.DataAccess;
using XamarinLayouts.Droid.Entities;

namespace XamarinLayouts.Droid
{
    [Activity(Label = "Lista", MainLauncher = false, Icon = "@drawable/icon")]
    public class ListaActivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            SetContentView(Resource.Layout.Lista);

            ListView lvClient = FindViewById<ListView>(Resource.Id.lvClient);
            ClientEntity[] list = Util.SelectClient(Util.PathDataBase()).ToArray<ClientEntity>(); //new ClientDataAccess().ListClients(20);
            ClientAdapter clientAdapter = new ClientAdapter(list);

            lvClient.Adapter = clientAdapter;
        }
    }
}