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
	public partial class DSHoa : ContentPage
	{
		public DSHoa (int maloai)
		{
			InitializeComponent ();
		}
	}
}