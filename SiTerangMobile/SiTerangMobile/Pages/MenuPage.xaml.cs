using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SiTerangMobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
            dateLabel.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        private void OnLihatPetaClicked(object sender, EventArgs e)
        {
            var tabbedPage = this.Parent.Parent as TabbedPage;
            tabbedPage.CurrentPage = tabbedPage.Children[1];
        }
    }
}
