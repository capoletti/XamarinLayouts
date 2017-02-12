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
using XamarinLayouts.Droid.Entities;

namespace XamarinLayouts.Droid
{
    [Activity(Label = "Cadastro", MainLauncher = false, Icon = "@drawable/icon")]
    public class CadastroActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Cadastro);

            Button btGravar = FindViewById<Button>(Resource.Id.btGravar);

            btGravar.Click += delegate
            {
                Gravar();
            };
        }

        protected void Gravar()
        {
            try
            {
                int count = Util.SelectClient(Util.PathDataBase()).Count();
                
                EditText etName = FindViewById<EditText>(Resource.Id.etName);
                EditText etEmail = FindViewById<EditText>(Resource.Id.etEmail);
                EditText etDate = FindViewById<EditText>(Resource.Id.etDate);

                DateTime data = Convert.ToDateTime(etDate.Text);
                
                ClientEntity clientEntity = new ClientEntity { ID = count + 1, Name = etName.Text, Email = etEmail.Text, DateBirth = data };
                Util.InsertUpdateClient(clientEntity, Util.PathDataBase());

                Toast.MakeText(this, "Salvo com sucesso!", ToastLength.Long).Show();
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, ex.Message, ToastLength.Long).Show();
            }
        }
    }
}