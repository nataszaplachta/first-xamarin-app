﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            lblMain.Text = "To jest text zmieniony po inicjalizacji";
            lblMain.TextColor = Color.Blue;
            lblMain.FontSize = 20;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            btn.BackgroundColor = Color.Red;
            lblMain.IsVisible = !lblMain.IsVisible;
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigate();
        }

        private void colorButton(object sender, EventArgs e)
        {
            var color = entryColor.Text;

            if (string.IsNullOrWhiteSpace(color))
            {
                return;
            }

            var colorHex = Color.FromHex(color);
            btnColor.BackgroundColor = colorHex;
        }

        private void entryColor_TextChanged(object sender, TextChangedEventArgs e)
        {
            var isHex = Regex.IsMatch(e.NewTextValue, "^#(([0-9a-fA-F]{2}){3}|([0-9a-fA-F]){3})$");
            entryColor.BackgroundColor = isHex ?
                Color.LightSeaGreen :
            Color.Red;
        }

        private async void urlEntry_Completed(object sender, EventArgs e)
        {
            
            await Navigate();
        }

        private async Task Navigate()
        {
            var url = urlEntry.Text;
            if (string.IsNullOrEmpty(url))
            {
                await DisplayAlert("Uwaga", "Nie wpisałeś adresu WWW", "Okay");
                return;
            }
            var response = await DisplayAlert("Pytanie", "Czy masz skończone 18 lat, żeby wejść na stronę?", "TAK", "NIE");
            if (response)
            {
                await Navigation.PushAsync(new GridPage());
            }
            else
            {
                await DisplayAlert("OK", "Wróć jak dorośniesz", "Ok");
            }

           
        }
    }
}
