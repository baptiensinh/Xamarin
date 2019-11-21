using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Menu
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void DropdownMenu_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new DropdownMenu());
        }

        private void PopupMenu_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new PopupMenu());
        }
    }
}
