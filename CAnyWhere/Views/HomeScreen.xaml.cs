using CAnyWhere.Services;

namespace CAnyWhere.Views;

public partial class HomeScreen : ContentPage
{

	public HomeScreen()
	{
		InitializeComponent();
	}

    private void onPostVideo(object sender, EventArgs e)
    {
        FileStorageService fileStorageService = new FileStorageService();
        fileStorageService.postAsync("default");
    }
}

