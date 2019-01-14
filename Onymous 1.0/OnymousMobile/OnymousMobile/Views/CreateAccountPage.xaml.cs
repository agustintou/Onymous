using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OnymousMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreateAccountPage : ContentPage
    {
        private View[] _views;

		public CreateAccountPage ()
		{
			InitializeComponent ();

            InitialViews();
		}

        private void InitialViews()
        {
            _views = new View[]
            {
                new CreateUserNameView(),
                new CreatePersonView(),
                new CreatePasswordView()
            };

            carousel.ItemsSource = _views;
        }

        private void Carousel_PositionSelected(object sender, CarouselView.FormsPlugin.Abstractions.PositionSelectedEventArgs e)
        {

        }
    }
}