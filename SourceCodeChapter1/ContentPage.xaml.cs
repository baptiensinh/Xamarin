using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace FormsExample
{
    public partial class ContentPageExample : ContentPage
    {
        public ContentPageExample()
        {
            InitializeComponent();
        }
        protected void ButtonClicked(object sender, EventArgs e)
        {
            ((Button)sender).Text = "It is so!";
        }
        private async Task<bool> ButtonClicked(object sender, EventArgs e)
        {
            var b = sender as Button;
            b.Text = "It is so!"; return await Task.FromResult(true);
        }

    }
}
