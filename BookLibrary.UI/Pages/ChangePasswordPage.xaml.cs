﻿using BookLibrary.Repository.Repositories;
using BookLibrary.Storage.Repositories;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace BookLibrary.UI.Pages
{
    /// <summary>
    /// Interaction logic for ChangePasswordPage.xaml
    /// </summary>
    public partial class ChangePasswordPage : Page
    {
        private readonly IAccountRepository accountRepository = new AccountRepository();

        public ChangePasswordPage()
        {
            InitializeComponent();

            btnBackward.Background = PagesPropertiesProvider.BackwardImage;
            btnBackward.Click += btnBackward_Click;
            btnChangePassword.Click += btnChangePassword_Click;
        }

        private void btnBackward_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private async void btnChangePassword_Click(object sender, RoutedEventArgs e)
        {
            if (string.Compare(pbNewPassword.Password, pbConfirmPassword.Password) == 0)
            {
                if (await accountRepository.ChangeAccountPassword(AppUser.GetInstance().AccountId, pbPassword.Password, pbNewPassword.Password))
                {
                    MessageBox.Show("Password changed", "Book Library Alert", MessageBoxButton.OK, MessageBoxImage.Information);
                    NavigationService.GoBack();
                }
                lblMasage.Content = "Can't change password with this password";
            }
            else
            {
                lblMasage.Content = "Confirm password not correct";
            }
        }
    }
}
