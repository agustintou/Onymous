using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OnymousMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : TabbedPage
    {
		public MainPage ()
		{
			InitializeComponent ();
		}

        private void CustomizeTabs()
        {
        }
    }
}