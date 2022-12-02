using CAnyWhere.Models;
using CAnyWhere.Services;

namespace CAnyWhere.Views;

public partial class CreateAccount : ContentPage
{

    private string Email;
    private string Password;
    private string Name;
    private string Usertype;
    public CreateAccount()
    {
        InitializeComponent();
    }

    private async void OnSignUp(object sender, EventArgs e)
    {
        User user = new(Email, Name, Password, Usertype);
        LoginClientService LoginClientService = new();
        LoginClientService.PostAsync(user);
        await Navigation.PushAsync(new MainPage());
    }

    void OnUserNameEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        Name = entryusernameca.Text;
    }

    void OnUserNameEntryCompleted(object sender, EventArgs e)
    {
        Name = ((Entry)sender).Text;
    }

    void OnPasswordEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        Password = entrypasswordca.Text;
    }

    void OnPasswordEntryCompleted(object sender, EventArgs e)
    {
        Password = ((Entry)sender).Text;
    }

    void OnEmailEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        Email = ((Entry)sender).Text;
    }

    void OnEmailEntryCompleted(object sender, EventArgs e)
    {
        Email = ((Entry)sender).Text;
    }

    void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        int selectedIndex = picker.SelectedIndex;

        if (selectedIndex != -1)
        {
            Usertype = (string)picker.ItemsSource[selectedIndex];
        }
    }

}

