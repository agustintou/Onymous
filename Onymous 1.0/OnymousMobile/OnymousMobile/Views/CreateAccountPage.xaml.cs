using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OnymousMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreateAccountPage : ContentPage
	{
		public CreateAccountPage ()
		{
			InitializeComponent ();

            CheckFullName();
            
        }

        private void CheckFullName()
        {
            if (txtFullName.Text == null || txtFullName.Text.Length == 0)
            {
                lblFullName.IsVisible = false;
            }
        }

        private void FullName_Focused(object sender, FocusEventArgs e)
        {
            lblFullName.IsVisible = true;

            CheckFullName();
        }

        private void FullName_Unfocused(object sender, FocusEventArgs e)
        {
            if (txtFullName.Text == null || txtFullName.Text.Length == 0)
            {
                lblFullName.IsVisible = false;
            }
        }
    }
}