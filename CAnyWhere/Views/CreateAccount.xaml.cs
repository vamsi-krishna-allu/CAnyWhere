namespace CAnyWhere.Views;

public partial class CreateAccount : ContentPage
{

	public CreateAccount()
	{
		InitializeComponent();
	}

    private async void OnSignUp(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomeScreen());
    }

    void OnUserNameEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        string myText = entryusernameca.Text;
    }

    void OnUserNameEntryCompleted(object sender, EventArgs e)
    {
        string text = ((Entry)sender).Text;
    }

    void OnPasswordEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        string myText = entryusernameca.Text;
    }

    void OnPasswordEntryCompleted(object sender, EventArgs e)
    {
        string text = ((Entry)sender).Text;
    }
}

