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
    public partial class NewProject : ContentPage
    {
        public NewProject()
        {
            InitializeComponent();
        }

        private async void BProjectOne_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProjectOneInfo());
        }

        private async void BProjectTwo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProjectInfoTwo());
        }

        private async void PictYourFace_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PickerFuckOFF());
        }
    }
}