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
	public partial class Themloaihoa : ContentPage
	{
		public Themloaihoa ()
		{
			InitializeComponent ();
		}
        private void tenloaiclick(object sender,EventArgs e)
        {
            database db = new database();
            LoaiHoa l = new LoaiHoa { Tenloai = txttenloai.Text };
            if (db.Insertloai(l) == true)
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