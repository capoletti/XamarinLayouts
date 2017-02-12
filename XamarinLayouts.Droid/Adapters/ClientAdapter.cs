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

namespace XamarinLayouts.Droid.Adapters
{
    public class ClientAdapter : BaseAdapter<ClientEntity>
    {

        ClientEntity[] data;

        public ClientAdapter (ClientEntity[] data)
        {
            this.data = data;
        }

        public override ClientEntity this[int position]
        {
            get
            {
                return this.data[position];
            }
        }

        public override int Count
        {
            get
            {
                return this.data.Count();
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var inflater = LayoutInflater.From(parent.Context);
            var view = inflater.Inflate(Resource.Layout.ClientItem, parent, false);

            (view.FindViewById<TextView>(Resource.Id.tvNome)).Text = data[position].Name;
            (view.FindViewById<TextView>(Resource.Id.tvEmail)).Text = data[position].Email;
            (view.FindViewById<TextView>(Resource.Id.tvDataNascimento)).Text = data[position].DateBirth.ToString("dd/MM/yyyy");
            
            return view;
        }
    }
}