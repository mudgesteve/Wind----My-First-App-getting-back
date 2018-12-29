using Wind.News;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Wind.Pages
{
    public partial class ItemDetailPage : ContentPage
    {
        public NewsInformation CurrentArticle { get; set; }
       
        public ItemDetailPage()
        {
            InitializeComponent();
        }

        public ItemDetailPage(NewsInformation currentArticle)
        {
            InitializeComponent();
            this.CurrentArticle = currentArticle;
        }

        public ItemDetailPage(FavoriteInformation currentArticle)
        {
            InitializeComponent();
            this.CurrentArticle = currentArticle.AsArticle();
        }

        protected override void OnAppearing()
        {
            this.BindingContext = this.CurrentArticle;
            
            base.OnAppearing();
        }
    }
}
