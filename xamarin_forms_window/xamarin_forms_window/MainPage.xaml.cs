using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace xamarin_forms_window
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            send_button.Clicked += Send_button_Clicked;
        }

        private void Send_button_Clicked(object sender, EventArgs e)
        {
            var message = ievade_teksts.Text;
            izmaina.Text = message;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
