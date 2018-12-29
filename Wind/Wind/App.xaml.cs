using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Wind.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Wind
{
    public partial class App : Application
    {
        //This is what will make ANY collections from Our viewModel Global
        public static ViewModels.MainViewModels ViewModel { get; internal set; }

        public App()
        {
            InitializeComponent();


            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
