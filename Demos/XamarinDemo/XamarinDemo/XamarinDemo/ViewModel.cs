using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinDemo
{
    public class ViewModel : INotifyPropertyChanged
    {
        private bool isValidLogin;

        public ViewModel()
        {
            this.Username = null;
            this.Password = null;
            this.IsValidLogin = false;
            this.LoginCommand = new Command(ExecuteLoginCommand);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private void ExecuteLoginCommand(object obj)
        {
            if(!string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password))
            {
                IsValidLogin = true;
            }
        }

        public string Username { get; set; }

        public string Password { get; set; }

        public bool IsValidLogin {
            get { return this.isValidLogin; }
            set
            {
                this.isValidLogin = value;
                OnPropertyChanged("IsValidLogin");
            }
        }

        public Command LoginCommand { get; set; }
    }
}
