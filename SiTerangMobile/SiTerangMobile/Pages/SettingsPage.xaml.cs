using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace SiTerangMobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
            Initialization();
        }

        protected override bool OnBackButtonPressed()
        {
            var tabbedPage = this.Parent.Parent as TabbedPage;
            tabbedPage.CurrentPage = tabbedPage.Children[0];

            return true;
        }

        async void OnLocationToggled(object sender, EventArgs e)
        {
            var status = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();

            if (status == PermissionStatus.Denied)
            {
                await DisplayAlert("Location", "Please allow application to access device location", "OK");
            }

            status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();

            await DisplayAlert("DEBUG Location!", status.ToString(), "OK");
        }

        async void Initialization()
        {
            var status = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();
            if (status == PermissionStatus.Granted)
            {
                locationSwitch.IsToggled = true;

            }
            else
            {
                locationSwitch.IsToggled = false;
            }
        }
    }
}