using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tabs
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void TabPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new TabPage());
        }

        private void TabPageDatabound_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new TabPageDatabound());
        }
    }
}
