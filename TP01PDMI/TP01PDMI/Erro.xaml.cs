﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP01PDMI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Erro : ContentPage
    {
        public Erro()
        {
            InitializeComponent();
        }
        private async void btnVoltarErro(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }
    }
}