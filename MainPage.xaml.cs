﻿using System;
using Microsoft.Maui.Controls;
using CDMA.ViewModels;

namespace CDMA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel(); // Assuming you have a ViewModel for data binding
        }

        // Logout button click event handler
        private async void OnLogoutClicked(object sender, EventArgs e)
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
