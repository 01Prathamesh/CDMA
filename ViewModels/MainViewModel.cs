using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CDMA.ViewModels
{
    internal class MainViewModel : INotifyPropertyChanged
    {
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
    }
}
