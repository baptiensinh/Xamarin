using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomRendererExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomRendererExamplePage : ContentPage
    {
        public CustomRendererExamplePage() { InitializeComponent(); }
        public void ButtonClicked(object sender, EventArgs args)
        { DisplayAlert("Congratulations", "This button was rendered in a platform-specific class.", "OK"); }
    }
}