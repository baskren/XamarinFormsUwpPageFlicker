using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App2
{
    public class Page1 : ContentPage
    {
        bool _modal = false;
        public Page1(bool modal)
        {
            _modal = modal;

            var button = new Button
            {
                Text = "return to MainPage",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            Content = new StackLayout
            {
                Children = {
                    new Label
                    {
                        Text = "Welcome to Xamarin Forms!",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.Center
                    },
                    button
                }
            };

            button.Clicked += Button_Clicked;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (_modal)
                Navigation.PopModalAsync();
            else
                Navigation.PopAsync();
        }
    }
}