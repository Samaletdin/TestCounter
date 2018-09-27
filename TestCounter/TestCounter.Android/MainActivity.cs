using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content;
using System.Collections;

namespace TestCounter.Droid
{
    [Activity(Label = "TestCounter", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        string date;
        ArrayList dates = new ArrayList();
        ArrayList data = new ArrayList();
        protected override void OnCreate(Bundle bundle)
        {
            string temp = DateTime.Today.ToString("yy:mm:dd");
            if (date != null)
            {
                if (!date.Equals(temp))
                {
                    dates.Add(date);
                    data.Add(MainPage.counter);
                    date = temp;
                    MainPage.counter = 0;
                }

            }
            else
            {
                if (bundle != null)
                {
                    MainPage.counter = bundle.GetInt("PillCounter");
                }
            }
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            Console.WriteLine("ON CREATE");
            base.OnCreate(bundle);

            

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }

        protected override void OnSaveInstanceState(Bundle outState)
        {
            outState.PutInt("PillCounter", MainPage.counter);
            base.OnSaveInstanceState(outState);
        }

        protected override void OnResume()
        {
            base.OnResume();
        }

        protected override void OnRestart()
        {
            base.OnRestart();
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
        }


        
    }
}

