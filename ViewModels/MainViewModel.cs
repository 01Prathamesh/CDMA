using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Threading.Tasks;

namespace CDMA.ViewModels
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        private bool isLoggedIn;

        public bool IsLoggedIn
        {
            get => isLoggedIn;
            set
            {
                if (isLoggedIn != value)
                {
                    isLoggedIn = value;
                    OnPropertyChanged(nameof(IsLoggedIn));
                    OnPropertyChanged(nameof(IsLoggedOut));
                    // Note: Do not call UpdateToolbarItems here
                }
            }
        }
        public ICommand OnLoginCommand => new Command(async () => await OnLoginClicked());
        public ICommand OnLogoutCommand => new Command(async () => await OnLogoutClicked());


        public bool IsLoggedOut => !IsLoggedIn;

        // Event to notify when a property changes
        public event PropertyChangedEventHandler? PropertyChanged;

        // Method to raise the PropertyChanged event
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Example property
        private string username = string.Empty;
        public string Username
        {
            get => username;
            set
            {
                if (username != value)
                {
                    username = value;
                    OnPropertyChanged(); // Notify that the property has changed
                }
            }
        }

        // Constructor
        public MainViewModel()
        {
            Username = "User"; // Default username
        }

        // Login method
        private async Task OnLoginClicked()
        {
            // Your login logic here
            // For example:
            await Task.Delay(500); // Simulate login process
            IsLoggedIn = true; // Update login state
        }

        // Logout method
        private async Task OnLogoutClicked()
        {
            // Your logout logic here
            await Task.Delay(500); // Simulate logout process
            IsLoggedIn = false; // Update login state
        }
    }
}
