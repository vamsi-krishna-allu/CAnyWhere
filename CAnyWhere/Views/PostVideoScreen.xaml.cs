using CAnyWhere.Services;

namespace CAnyWhere.Views;

public partial class PostVideoScreen : ContentPage
{
    private string username;
	public PostVideoScreen(string username)
	{
		InitializeComponent();
        this.username = username;
	}

    private void onPostPickedVideo(object sender, EventArgs e)
    {
        FileStorageService FileStorageService = new();
        FileStorageService.postPickedVideoAsync(username);

    }

    private void onPostCapturedVideo(object sender, EventArgs e)
    {
        FileStorageService FileStorageService = new();
        FileStorageService.postCapturedVideoAsync(username);

    }

    private void onPostPickedImage(object sender, EventArgs e)
    {
        FileStorageService FileStorageService = new();
        FileStorageService.postPickedPhotoAsync(username);
    }

    private void onPostCapturedImage(object sender, EventArgs e)
    {
        FileStorageService FileStorageService = new();
        FileStorageService.postCapturedPhotoAsync(username);
    }
}

