using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;
using System;

namespace XamarinLayouts.Droid
{
    [Activity(Label = "Listas Android Xamarin", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            Button btCadastrar = FindViewById<Button>(Resource.Id.btCadastrar);
            Button btListar = FindViewById<Button>(Resource.Id.btListar);

            btCadastrar.Click += delegate
            {
                Cadastrar();
            };
            btListar.Click += delegate
            {
                Listar();
            };
                        
            Util.CreateDatabaseClient(Util.PathDataBase());
        }

        protected void Cadastrar()
        {
            Intent intent = new Intent(this, typeof(CadastroActivity));
            StartActivity(intent);
        }

        protected void Listar()
        {
            Intent intent = new Intent(this, typeof(ListaActivity));
            StartActivity(intent);
        }      
    }
}

