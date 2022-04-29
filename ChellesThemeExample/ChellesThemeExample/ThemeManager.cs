using System;
using Xamarin.Forms;

namespace ChellesThemeExample
{
    public class ThemeManager
    {
        public static void ChangeTheme(ThemeModel model)
        {
            //App.Current.Resources.Clear();
            App.Current.Resources["defaultColor1"] = model.DefaultColor1;
            App.Current.Resources["defaultColor2"] = model.DefaultColor2;
            App.Current.Resources["defaultColor3"] = model.DefaultColor3;
            App.Current.Resources["defaultColor4"] = model.DefaultColor4;
        }
    }
}
