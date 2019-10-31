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
	public partial class DSLoaiHoa : ContentPage
	{
        database db;
        List<LoaiHoa> ds;
		public DSLoaiHoa ()
		{
			InitializeComponent ();
            db = new database();
            ds = db.SelectLoaiHoa();
            dsloai.ItemsSource = ds;
		}
        public void dshoaclick (object sender,SelectedItemChangedEventArgs e)
        {
            LoaiHoa lh = (LoaiHoa)e.SelectedItem;
            Navigation.PushAsync(new DSHoa(lh.Maloai));
        }
	}
}