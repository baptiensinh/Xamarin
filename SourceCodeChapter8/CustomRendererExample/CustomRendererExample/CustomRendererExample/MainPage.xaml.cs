using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomRendererExample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Custombtt(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new CustomRendererExamplePage());
        }
        private void EffectExamplebtt(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new EffectExamplePage());
        }
    }
}
