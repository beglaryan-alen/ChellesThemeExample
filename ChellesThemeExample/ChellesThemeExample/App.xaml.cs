using ChellesThemeExample.Views;
using Prism;
using Prism.Ioc;
using Prism.Unity;

namespace ChellesThemeExample
{
    public partial class App : PrismApplication
    {
        public static T Resolve<T>() => Current.Container.Resolve<T>();
        public App(IPlatformInitializer platformInitializer) : base(platformInitializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            //Should come from api
            var themeModel = new ThemeModel
            {
                DefaultColor1 = "#eb4034",
                DefaultColor2 = "#eb3489",
                DefaultColor3 = "#34eb43",
                DefaultColor4 = "#e8eb34",
            };
            ThemeManager.ChangeTheme(themeModel);
            MainPage = new SomeView();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<SomeView>(nameof(SomeView));
        }
    }
}
