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
    public partial class PasswordEntry : ContentView
    {
        public PasswordEntry()
        {
            InitializeComponent();
        }
        private void OnButtonClicked(object sender, EventArgs e)
        {
            if (MyEntry.IsPassword)
            {
                MyEntry.IsPassword = false;
            }
            else
            {
                MyEntry.IsPassword = true;
            }
        }
    }
}