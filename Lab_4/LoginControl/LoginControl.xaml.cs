using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using UiAttributesForEmbedding.Attributes;

namespace LoginControl
{
    [EmbedInTabControl(true, "Login")]
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        private void BtnSignIn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            string email = TbEmail.Text;
            string password = TbPassword.Password;

            if (IsValidEmail(email) && !string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(password))
            {
                string message = "You have successfully signed in to your account!\n\n" +
                                 $"Email: {email}\nPassword: {password}";

                MessageBox.Show(message, "Login", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Invalid data entered!", "Login",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private static bool IsValidEmail(string email)
        {
            const string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            var isMatchPattern = Regex.Match(email, pattern, RegexOptions.IgnoreCase);

            return isMatchPattern.Success;
        }
    }
}