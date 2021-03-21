using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Anasayfa : ContentPage
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void BtnHesapla(object o, EventArgs args)
        {
            if (en.Text == null || boy.Text == null || yukseklik.Text == null)
            {
                DisplayAlert("HATA", "Lütfen Boş Alanları Doldurunuz.", "Tamam");
            }
            else
            {
                float desisonuc = (float.Parse(en.Text) * float.Parse(boy.Text) * float.Parse(yukseklik.Text)) / 3000;
                sonuc.Text = "Sonuc: " + desisonuc;
            }
            
        }
    }
}