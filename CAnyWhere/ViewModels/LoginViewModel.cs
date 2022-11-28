using CAnyWhere.Validators;
using System.Web;

namespace CAnyWhere.ViewModels
{
    internal class LoginViewModel
    {
        public static async Task<bool> OnLogin(string username, string password)
        {
            CustomValidator customValidator = new EmailValidator();
            bool isValid = customValidator.Validate(username);

            if (!isValid)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Username is Invalid. Please try Again", "OK");
                return false;
            }

            customValidator = new PasswordValidator();
            isValid = customValidator.Validate(password);

            if (!isValid)
            {
                await Application.Current.MainPage.DisplayAlert("Error",
                    String.Join(Environment.NewLine, "Password is Invalid.", "1. Minimum 6 characters and maximum 20 characters",
                    "2. Should Contain Atleast One Upper Case", "3. Should Contain Atleast One Lower Case",
                    "4. Should Contain Atleast One Special Character", "5. Should not contain spaces"), "OK");
                return false;
            }

            return true;
        }
    }
}
