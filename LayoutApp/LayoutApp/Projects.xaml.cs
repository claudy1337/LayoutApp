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
    public partial class Projects : ContentPage
    {
        public Projects()
        {
            InitializeComponent();
        }

        private  async void BAddProject_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PickerFuckOFF());
        }

       

        private async void BProjectO_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProjectOneInfo());
        }

        private async void BProjectT_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProjectInfoTwo());
        }
    }
}