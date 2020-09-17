using Java.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP01PDMI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
        private async void btnEntrar(object sender, EventArgs e)
        {
            if (user.Text =="admin" && senha.Text == "senha@dmin")
            {
                await Navigation.PushAsync(new Logado());

            }
            else
            {
                await Navigation.PushAsync(new Erro());
                user.Text = "";
                senha.Text = "";
            }
        }
        private void btnLimpar(object sender, EventArgs e)
        {
            user.Text = "";
            senha.Text = "";
            
        }
        private async void btnCreditos(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Creditos());
        }

    }
}