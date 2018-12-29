using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Wind.Pages
{
    public class UserInformation
    {

        public string DisplayName { get; set; }
        public string BioContent { get; set; }
        public string ProfileImageUrl { get; set; }

    }

    public partial class SettingsPage : ContentPage
    {
        public UserInformation CurrentUser { get; set; }

        public SettingsPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            InitializeSettings();

            base.OnAppearing();
        }

        private void InitializeSettings()
        {
            //this.CurrentUser = new UserInformation()
            //{
            //    DisplayName = "Steve",
            //    BioContent = "Steve Is Trying",
            //    ProfileImageUrl = "",
            //};

            this.BindingContext = this.CurrentUser;

            this.BindingContext = App.ViewModels;

            articleCountSlider.Value = 10;
            categoryPicker.SelectedIndex = 1;

            var label = Helpers.GeneralHelper.GetLabel();
            var extendedLabel = Helpers.GeneralHelper.GetLabel("Running Wind on", true);

            var orientation = Helpers.GeneralHelper.GetOrientation();

            App.ViewModels.PlatformLabel = label;
            App.ViewModels.ExtendedPlatformLabel = extendedLabel;
            App.ViewModels.CurrentOrientation = orientation;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.Resources["ListTextColor"] = Color.Blue;
        }

        private void TestThis(INavigation navigation)
        {
            throw new NotImplementedException();
        }
    }
}
