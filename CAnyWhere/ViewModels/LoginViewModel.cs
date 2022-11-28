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

            

            return true;
        }
    }
}
