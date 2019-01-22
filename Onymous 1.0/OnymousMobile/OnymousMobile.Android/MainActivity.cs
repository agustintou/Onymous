﻿using Android.App;
using Android.Content.PM;
using Android.OS;
using SuaveControls.FloatingActionButton.Droid.Renderers;

namespace OnymousMobile.Droid
{
    [Activity(Label = "OnymousMobile", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            FloatingActionButtonRenderer.Initialize();
            LoadApplication(new App());
        }
    }
}