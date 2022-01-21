using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Essentials;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PickerFuckOFF : ContentPage
    {
        Image img;
        Button takePhotoBtn;
        Button getPhotoBtn;             //что ты тут забыл?
        Button dellPhoto;            
                                        //message telegram me @wynpel
        public PickerFuckOFF()
        {
            InitializeComponent();

            takePhotoBtn = new Button { Text = "add project" };
            getPhotoBtn = new Button { Text = "Upload project" };
            dellPhoto = new Button { Text = "delete!!!" };
            ;
            img = new Image();
            getPhotoBtn.Clicked += GetPhotoAsync;
            takePhotoBtn.Clicked += TakePhotoAsync;
            dellPhoto.Clicked += DellYourFuckedFaceAsync;
            Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                Children = {
                    new StackLayout
                    {
                         Children = {takePhotoBtn, getPhotoBtn, dellPhoto},
                         Orientation =StackOrientation.Horizontal,
                         HorizontalOptions = LayoutOptions.CenterAndExpand
                    },
                    img
                }
            };
        }
        async void TakePhotoAsync(object sender, EventArgs e)
        {
            try
            {
                var photo = await MediaPicker.CapturePhotoAsync(new MediaPickerOptions
                {
                    Title = $"xamarin.{DateTime.Now.ToString("dd.MM.yyyy_hh.mm.ss")}.png"
                });
                var newFile = Path.Combine(FileSystem.AppDataDirectory, photo.FileName);
                using (var stream = await photo.OpenReadAsync())
                using (var newStream = File.OpenWrite(newFile))
                    await stream.CopyToAsync(newStream);
                img.Source = ImageSource.FromFile(photo.FullPath);
            }
            catch (Exception ex)
            {
                await DisplayAlert("error excep", ex.Message, "OK");
            }
        }
        async void DellYourFuckedFaceAsync(object sender,EventArgs e)
        {
            try
            {
                DisplayAlert("delete","delete", "ОK");
                (Application.Current).MainPage = new NavigationPage(new MainPage());

            }
            catch (Exception ex)
            {

                await DisplayAlert("error excep", ex.Message, "OK");
            }
                                                                                                //ты все еще тут?)
        }
        async void GetPhotoAsync(object sender, EventArgs e)
        {
            try
            {
                var photo = await MediaPicker.PickPhotoAsync();
                img.Source = ImageSource.FromFile(photo.FullPath);
            }
            catch (Exception ex)
            {
                await DisplayAlert("error excep", ex.Message, "OK");
            }
        }
        async void TakeMeYourPhotoAsync(object sender, EventArgs e)

        {
            try
            {

            }
            catch (Exception ex)
            {
                await DisplayAlert("error excep", ex.Message, "OK");
            }
            //    var content = JsonConvert.SerializeObject(foto);
            //    string url = "http://client.handyhost/WS/api/Home/Image?foto=" + content;
            //    var result = await _client.PostAsync(url, new StringContent(content, Encoding.UTF8, "application/json"));
            //    return result.ToString();
            //}
            //catch (Exception ex)
            //    {
        }
    }

}