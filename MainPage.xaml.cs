using System;
using Microsoft.Maui.Controls;
using CDMA.ViewModels;

namespace CDMA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel(); // Set the BindingContext to your ViewModel
            UpdateToolbarItems(); // Initialize toolbar items based on login state
        }

        private void UpdateToolbarItems()
        {
            var viewModel = (MainViewModel)BindingContext;
            ToolbarItems.Clear(); // Clear existing toolbar items

            // Add Login toolbar item if the user is logged out
            if (viewModel.IsLoggedOut)
            {
                ToolbarItems.Add(new ToolbarItem
                {
                    Text = "Login",
                    Command = new Command(async () => await OnLoginClicked()) // Use a lambda for the command
                });
            }
            else
            {
                // Optionally add logout toolbar item
                ToolbarItems.Add(new ToolbarItem
                {
                    Text = "Logout",
                    Command = new Command(async () => await OnLogoutClicked()) // Use a lambda for the command
                });
            }

            // You can add more toolbar items here based on login state if needed
        }

        // Login button click event handler
        private async Task OnLoginClicked()
        {
            // Your login logic here
            await DisplayAlert("Info", "Login clicked", "OK");
            
            // Update the ViewModel's IsLoggedIn property
            var viewModel = (MainViewModel)BindingContext;
            viewModel.IsLoggedIn = true; // Set to true or false based on actual login logic

            // Refresh toolbar items after login
            UpdateToolbarItems();
        }

        // Logout button click event handler
        private async Task OnLogoutClicked()
        {
            try
            {
                // Handle logout logic here (e.g., clear user session)
                await Navigation.PushAsync(new LoginPage()); // Navigate to the Login page
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during logout
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }

        // Register button click event handler
        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            try
            {
                // Navigate to the Register page
                await Navigation.PushAsync(new RegisterPage());
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during registration
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }

        // Profile button click event handler
        private async void OnProfileClicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new ProfilePage()); // Navigate to Profile page
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK"); // Handle errors
            }
        }


        // View Career List button click event handler
        private async void OnViewCareerListClicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new CareerListPage()); // Navigate to Career List page
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK"); // Handle errors
            }
        }

        // View Dendrogram button click event handler
        private async void OnViewDendrogramClicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new DendrogramPage()); // Navigate to Dendrogram page
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK"); // Handle errors
            }
        }

        // View Profile button click event handler
        private async void OnViewProfileClicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new ProfilePage()); // Navigate to Profile page
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK"); // Handle errors
            }
        }

        // Start Test button click event handler
        private async void OnStartTestClicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new StartTestPage()); // Navigate to Start Test page
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK"); // Handle errors
            }
        }
    }
}
