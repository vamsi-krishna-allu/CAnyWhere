using CAnyWhere.Validators;
using CAnyWhere.ViewModels;
using Firebase.Database;

namespace CAnyWhere.Views;

public partial class MainPage : ContentPage
{
    string username = "";
    string password = "";

	public MainPage()
	{
		InitializeComponent();
	}
  
    private async void OnLogin(object sender, EventArgs e)
    {
        Task<bool> isValid = LoginViewModel.OnLogin(username, password);
        if (isValid.Result)
        {
            new DashBoardDataViewModel();
            await Navigation.PushAsync(new HomeScreen());
        }
    }

    private async void OnSignUp(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreateAccount());
    }

    void OnUserNameEntryTextChanged(object sender, TextChangedEventArgs e)
    {
         username = entryusername.Text;
    }

    void OnUserNameEntryCompleted(object sender, EventArgs e)
    {
        username = ((Entry)sender).Text;
    }

    void OnPasswordEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        password = entrypassword.Text;
    }

    void OnPasswordEntryCompleted(object sender, EventArgs e)
    {
        password = ((Entry)sender).Text;
    }
}

