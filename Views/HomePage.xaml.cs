using Microsoft.Maui.Controls;

namespace CDMA.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        // Button click event handlers
        private async void OnViewCareerListClicked(object sender, EventArgs e)
        {
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
