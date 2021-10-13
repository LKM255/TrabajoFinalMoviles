using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TrabajoFinalMoviles
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            inicio();
        }

        private void inicio()
        {
            hola.Text = "Binvenidos a ITANES";
        }
    }
}
