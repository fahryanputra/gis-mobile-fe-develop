using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SiTerangMobile.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        private bool _loginTapped;
        public LoginPage()
        {
            InitializeComponent();
        }

        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            if (_loginTapped)
            {
                return;
            }
            _loginTapped = true;
            var user = new User
            {
                Email = emailEntry.Text,
                Password = passwordEntry.Text
            };

            var isValid = CredentialsCheck(user);

            if (isValid)
            {
                App.IsUserLoggedIn = true;
                Navigation.InsertPageBefore(new HomePage(), this);
                await Navigation.PopAsync();
            } else
            {
                messageLabel.Text = "Login Failed";
                passwordEntry.Text = String.Empty;
            }
            _loginTapped = false;
        }

        bool CredentialsCheck(User user)
        {
            return user.Email == "quadran@gmail.com" && user.Password == "xamarin";
        }

        void OnShowButtonClicked(object sender, EventArgs e)
        {
            if (passwordEntry.IsPassword == true)
            {
                eyeIcon.Source = ImageSource.FromResource("SiTerangMobile.Assets.eye-off.png");
                passwordEntry.IsPassword = false;
            }
            else
            {
                eyeIcon.Source = ImageSource.FromResource("SiTerangMobile.Assets.eye.png");
                passwordEntry.IsPassword = true;
            }
        }
    }
}