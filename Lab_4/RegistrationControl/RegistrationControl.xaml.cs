using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using UiAttributesForEmbedding.Attributes;

namespace RegistrationControl
{
    [EmbedInTabControl(true, "Registration")]
    public partial class RegistrationControl : UserControl
    {
        public RegistrationControl()
        {
            InitializeComponent();
        }

        private void BtnSignUp_Click(object sender, RoutedEventArgs e)
        {
            string email = TbEmail.Text;
            string password = TbPassword.Password;
            string rePassword = TbRePassword.Password;
            string name = TbName.Text;
            string surname = TbSurname.Text;

            if (IsValidEmail(email) && IsValidPasswords(password, rePassword) 
                && !string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(surname))
            {
                string message = $"Email: {email}\nPassword: {password}\nName: {name}\nSurname: {surname}";

                MessageBox.Show(message, "Registration completed successfully",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Incorrect data entered!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private static bool IsValidEmail(string email)
        {
            const string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            var isMatchPattern = Regex.Match(email, pattern, RegexOptions.IgnoreCase);

            return isMatchPattern.Success;
        }

        private static bool IsValidPasswords(string password, string rePassword)
        {
            if (!string.IsNullOrWhiteSpace(password) && !string.IsNullOrWhiteSpace(rePassword)
                && password == rePassword)
            {
                return true;
            }

            return false;
        }
    }
}