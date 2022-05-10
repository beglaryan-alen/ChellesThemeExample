using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;

namespace ChellesThemeExample.Droid
{
    [Activity(Label = "ChellesThemeExample", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            ThemeModel theme = HttpRequest();
            base.SetTheme(new Android.Content.Res.Resources.Theme()
            {
                
            });

            LoadApplication(new App(new AndroidInitializer(), theme));
        }

        private ThemeModel HttpRequest()
        {
            return new ThemeModel()
            {
                DefaultColor1 = "Some color1",
                DefaultColor2 = "Some color2",
                DefaultColor3 = "Some color3",
                DefaultColor4 = "Some color4",
                NativeColor1 = "Some native Color1",
                NativeColor2 = "Some native color2",
                AvatarIcon = "https://cdn-icons-png.flaticon.com/512/147/147142.png",
            };
        }

    }
}