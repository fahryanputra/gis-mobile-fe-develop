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
    public partial class PelangganMenuPage : ContentPage
    {
        public PelangganMenuPage()
        {
            InitializeComponent();
        }

        async void OnDataPelangganClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new PelangganMapPage());
        }

        async void OnPelangganSekitarClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new LayerVisibilityMap());
        }
    }
}