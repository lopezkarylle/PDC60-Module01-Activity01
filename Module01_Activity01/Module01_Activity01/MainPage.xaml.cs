﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Module01_Activity01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OpenPage1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViewResourceDictionary());
        }

        private async void OpenPage2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LayoutResourceDictionary());
        }
        private async void OpenPage3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageLevelDictionary());
        }

    }
}
