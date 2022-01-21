using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LayoutApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        private async void BReg_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationPage());

        }

        private async void BLogin_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Projects());
        }
    }
}
