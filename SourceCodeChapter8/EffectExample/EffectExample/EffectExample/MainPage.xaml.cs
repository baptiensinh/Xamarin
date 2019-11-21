using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EffectExample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Exbtt(object sender,EventArgs e)
        {
            Navigation.PushModalAsync(new EffectExamplePag());
        }
    }
}
