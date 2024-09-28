using Microsoft.Maui.Controls;

namespace CDMA
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        // Add your button click event handlers here
        private async void OnViewCareerListClicked(object sender, EventArgs e)
        {
            // Handle the button click, for example:
            await Navigation.PushAsync(new CareerListPage());
        }

        private async void OnViewDendrogramClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DendrogramPage());
        }

        private async void OnStartTestClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StartTestPage());
        }
    }
}
