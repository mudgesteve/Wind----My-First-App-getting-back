using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wind.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //private void InitializeComponent()
        //{
        //    //throw new NotImplementedException();    await Navigation.PushAsync(new Pages.TestingPage());
        //}

        protected override void OnAppearing()
        {
            App.ViewModel = new ViewModels.MainViewModels();
            App.ViewModel.RefreshNewsAsync();

            base.OnAppearing();
        }

        private void MyButton_Click(object sender, EventArgs e)
        {

        }
    }
}