using Firebase.Storage;

namespace CAnyWhere.Services
{
    public class FileStorageService : IFileStorage
    {

        public async void postPickedPhotoAsync(string username)
        {
            var photo = await MediaPicker.PickPhotoAsync();

            if (photo == null)
                return;

            var task = new FirebaseStorage("canywhere-ed9ad.appspot.com",
                new FirebaseStorageOptions
                {
                    ThrowOnCancel = true
                })
                .Child("Images")
                .Child(updateFolderName(username))
                .Child(photo.FileName)
                .PutAsync(await photo.OpenReadAsync());

        }

        public async void postPickedVideoAsync(string username)
        {
            var video = await MediaPicker.PickVideoAsync();

            if (video == null)
                return;

            var task = new FirebaseStorage("canywhere-ed9ad.appspot.com",
                new FirebaseStorageOptions
                {
                    ThrowOnCancel = true
                })
                .Child("Images")
                .Child(updateFolderName(username))
                .Child(video.FileName)
                .PutAsync(await video.OpenReadAsync());

        }

        public async void postCapturedPhotoAsync(string username)
        {
            var photo = await MediaPicker.CapturePhotoAsync();

            if (photo == null)
                return;

            var task = new FirebaseStorage("canywhere-ed9ad.appspot.com",
                new FirebaseStorageOptions
                {
                    ThrowOnCancel = true
                })
                .Child("Images")
                .Child(updateFolderName(username))
                .Child(photo.FileName)
                .PutAsync(await photo.OpenReadAsync());

        }


        public async void postCapturedVideoAsync(string username)
        {
            var video = await MediaPicker.CaptureVideoAsync();

            if (video == null)
                return;

            var task = new FirebaseStorage("canywhere-ed9ad.appspot.com",
                new FirebaseStorageOptions
                {
                    ThrowOnCancel = true
                })
                .Child("Images")
                .Child(updateFolderName(username))
                .Child(video.FileName)
                .PutAsync(await video.OpenReadAsync());

        }

        public async void getImagesAndVideosAsync()
        {

            var task = new FirebaseStorage("canywhere-ed9ad.appspot.com",
                new FirebaseStorageOptions
                {
                    ThrowOnCancel = true
                })
                .Child("Images");
            Console.WriteLine(task);

        }

        private string updateFolderName(string username)
        {
            username = username.Replace("@", "atTheRate").Replace(".", "dot").ToUpper();
            return username;
        }
    }
}
