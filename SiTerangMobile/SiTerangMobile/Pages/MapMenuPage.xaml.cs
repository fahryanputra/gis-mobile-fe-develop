using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiTerangMobile.Pages;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SiTerangMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapMenuPage : ContentPage
    {
        private bool _menuTapped;
        public MapMenuPage()
        {
            InitializeComponent();
        }
        
        async void OnPelangganClicked(object sender, EventArgs args)
        {
            if (_menuTapped)
            {
                return;
            }
            _menuTapped = true;
            PlayClickedAnimation();
            await Navigation.PushAsync(new PelangganMapPage());
            _menuTapped = false;
        }

        protected override bool OnBackButtonPressed()
        {
            var tabbedPage = this.Parent.Parent as TabbedPage;
            tabbedPage.CurrentPage = tabbedPage.Children[0];

            return true;
        }

        async void PlayClickedAnimation()
        {
            await frame03.ScaleTo(1.1, 100);
            await frame03.ScaleTo(1, 100);
        }
    }
}