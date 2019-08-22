﻿using RecommendersDemo.Models;
using RecommendersDemo.ViewModels;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices.ComTypes;
using Xamarin.Forms;

namespace RecommendersDemo.Views
{
    [DesignTimeVisible(false)]
    public partial class LgbmAlgorithmPage : ContentPage
    {
        public LgbmAlgorithmPage()
        {
            InitializeComponent();
        }

        private async void Redirect(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage()).ConfigureAwait(false);
        }
    }
}