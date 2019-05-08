using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Question1.Models;

namespace Question1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Messages messages = new Messages();
        static Generate username = new Generate();
        static Validate check = new Validate();
        public MainWindow()
        {
            InitializeComponent();
            Title.Content = messages.Title;
            fnameTitle.Content = messages.AskForFirstname;
            lnameTitle.Content = messages.AskForLastname;
            emailTitle.Content = messages.AskForEmail;
            userroleTitle.Content = messages.AskForUserrole;
            password1Title.Content = messages.AskForFirstPassword;
            password2Title.Content = messages.AskForSecondPassword;
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            fnameError.Content = check.ValidateRequiredField(fnameInput.Text);
            lnameError.Content = check.ValidateRequiredField(lnameInput.Text);
            emailError.Content = check.ValidateRequiredField(emailInput.Text);
            userroleError.Content = check.ValidateRequiredField(userroleInput.Text);
            passwordError.Content = check.ValidatePassword(password1Input.Text, password2Input.Text);

            ExtendedUserInfo user = new ExtendedUserInfo(fnameInput.Text, lnameInput.Text, emailInput.Text, userroleInput.Text);
            usernameOutput.Content = username.GenerateUsername(fnameInput.Text, lnameInput.Text);
            user.DisplayListedUsers();
        }
    }
}
