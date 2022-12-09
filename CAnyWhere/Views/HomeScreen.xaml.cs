using CAnyWhere.Services;

namespace CAnyWhere.Views;

public partial class HomeScreen : ContentPage
{
    private string username;
	public HomeScreen(string username)
	{
		InitializeComponent();
        this.username = username;
	}

    private async void onPostVideoAsync(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PostVideoScreen(this.username));
    }
}

