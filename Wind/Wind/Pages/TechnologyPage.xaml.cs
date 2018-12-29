using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Wind.Pages
{
    public partial class TechnologyPage : ContentPage
    {
        public TechnologyPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            this.BindingContext = App.ViewModel;

            base.OnAppearing();
        }

    }
}
