using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OnymousXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterPage : MasterDetailPage
	{
		public MasterPage ()
		{
			InitializeComponent ();
		}
	}
}