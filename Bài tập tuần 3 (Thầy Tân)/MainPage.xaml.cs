using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BT3
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
         
        }
        private void themloaihoac(object sender,EventArgs e)
        {
            Navigation.PushAsync(new Themloaihoa());
        }
        private void themhoac(object sender,EventArgs e)
        {
            Navigation.PushAsync(new Themhoa());
        }
        private void loaihoac(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DSLoaiHoa());
        }
    }
}
