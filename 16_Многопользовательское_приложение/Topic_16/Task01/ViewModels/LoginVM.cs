using System;
using System.ComponentModel;
using System.Linq;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Task01.Models;

namespace Task01.ViewModels
{
    public class LoginVM : INotifyPropertyChanged
    {
        private string _login;
        private AuthService _authService = new AuthService();

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                OnPropertyChanged(nameof(Login));
            }
        }

        public User CurrentUser { get; private set; }

        public ICommand LoginCommand { get; }
        public ICommand CancelCommand { get; }

        public LoginVM()
        {
            LoginCommand = new RelayCommand(param => LoginMethod(param));
            CancelCommand = new RelayCommand(_ => Cancel());
        }
        private void LoginMethod(object param)
        {
            if (string.IsNullOrWhiteSpace(Login))
            {
                MessageBox.Show("Введите логин");
                return;
            }

            var passwordBox = param as PasswordBox;
            if (passwordBox == null)
            {
                MessageBox.Show("Ошибка получения пароля");
                return;
            }

            string password = passwordBox.Password;

            var user = _authService.Login(Login, password);

            if (user == null)
            {
                MessageBox.Show("Неверный логин или пароль");
                return;
            }

            CurrentUser = user;

            CloseWindow();
        }

        private void Cancel()
        {
            Application.Current.Shutdown();
        }

        private void CloseWindow()
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.DataContext == this)
                {
                    window.DialogResult = true;
                    window.Close();
                    break;
                }
            }
        }
    }
}