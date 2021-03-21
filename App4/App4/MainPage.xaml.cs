using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void BtnGiris(object o, EventArgs args)
        {
            if (username.Text=="onur" && password.Text=="123")
            {
                await Navigation.PushModalAsync(new Anasayfa());
            }
            else
            {
                await DisplayAlert("Uyarı", "Hatalı Giriş", "Tamam");
            }
        }
    }
}
