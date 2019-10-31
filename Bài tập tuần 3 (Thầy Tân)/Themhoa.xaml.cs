using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BT3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Themhoa : ContentPage
	{
		public Themhoa ()
		{
			InitializeComponent ();
		}
        private void themhoaclick(object sender, EventArgs e)
        {
            
        }
        private void xoahoaclick(object sender, EventArgs e)
        {

        }
        private int Number;
        private void Themhoaclick(object sender,EventArgs e)
        {
            database db = new database();
            
            Hoa h = new Hoa
            {
                Tenhoa = txttenhoa.Text,
                Image = txthinh.Text,
                Ghichu = txtmota.Text,
                
            };
            if (db.InsertHoa(h) == true)
            {
                DisplayAlert("Notify", "Success", "Ok");
            }
            else
                {
                DisplayAlert("Notify", "False", "Ok");
                 }
        }
    }
}