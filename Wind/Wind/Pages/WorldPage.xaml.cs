using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Wind.Pages
{
    public partial class WorldPage : ContentPage
    {
        public WorldPage()
        {
            InitializeComponent(); 
        }

        protected override void OnAppearing()
        {
            this.BindingContext = App.ViewModel;

            base.OnAppearing();
        }
 
        private void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            new Common.Commands.NavigateToDetailCommand().Execute(e.Item as News.NewsInformation);
        }
    }
}
