using Firebase.Database;

namespace CAnyWhere.Views;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}


    private async void OnLogin(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomeScreen());
    }

    private async void OnSignUp(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CreateAccount());
    }

    void OnUserNameEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        string myText = entryusername.Text;
    }

    void OnUserNameEntryCompleted(object sender, EventArgs e)
    {
        string text = ((Entry)sender).Text;
    }

    void OnPasswordEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        string myText = entryusername.Text;
    }

    void OnPasswordEntryCompleted(object sender, EventArgs e)
    {
        string text = ((Entry)sender).Text;
    }
}

