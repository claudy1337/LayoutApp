using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
            //RegistrationPage = new NavigationPage(new MainPage());
        }
        private async void BRegistrationVerification_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Projects());
        }
    }
}