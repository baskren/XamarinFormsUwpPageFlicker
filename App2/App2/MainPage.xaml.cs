using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1(false));
        }

        private void Button_Clicked2(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Page1(true));
        }

    }
}
