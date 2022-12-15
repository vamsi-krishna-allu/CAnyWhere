using CAnyWhere.Models;
using CAnyWhere.Services;

namespace CAnyWhere.Views;

public partial class PostVideoScreen : ContentPage
{
    private string username;
    private string filename = "";
    public PostVideoScreen(string username)
	{
		InitializeComponent();
        this.username = username;
	}

    private void onPostPickedVideo(object sender, EventArgs e)
    {
        FileStorageService FileStorageService = new();
        FileStorageService.postPickedVideoAsync(username, filename);

    }

    private void onPostCapturedVideo(object sender, EventArgs e)
    {
        FileStorageService FileStorageService = new();
        FileStorageService.postCapturedVideoAsync(username, filename);

    }

    private void onPostPickedImage(object sender, EventArgs e)
    {
        FileStorageService FileStorageService = new();
        FileStorageService.postPickedPhotoAsync(username, filename);
    }

    private void onPostCapturedImage(object sender, EventArgs e)
    {
        FileStorageService FileStorageService = new();
        FileStorageService.postCapturedPhotoAsync(username, filename);
    }

    void OnFileNameEntryCompleted(object sender, EventArgs e)
    {
        filename = ((Entry)sender).Text;
    }

    void OnFileNameEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        filename = entryfilename.Text;
    }
}

