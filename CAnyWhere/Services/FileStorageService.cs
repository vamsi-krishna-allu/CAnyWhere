using CAnyWhere.Models;
using Firebase.Storage;
using System.Collections.ObjectModel;

namespace CAnyWhere.Services
{
    public class FileStorageService : IFileStorage
    {

        public async void postPickedPhotoAsync(string username, string filename)
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
                .Child(filename)
                .PutAsync(await photo.OpenReadAsync());


            ClientUserfilesclass ClientUserfilesclass = new ClientUserfilesclass();
            UserFiles userFiles = new()
            {
                UserId = username,
                FileId = username,
                FileName = filename,
                FileLocation = "Images/" + updateFolderName(username) + "/" + filename,
            };
            ClientUserfilesclass.PostAsync(userFiles);


        }

        public async void postPickedVideoAsync(string username, string filename)
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
                .Child(filename)
                .PutAsync(await video.OpenReadAsync());

            ClientUserfilesclass ClientUserfilesclass = new ClientUserfilesclass();
            UserFiles userFiles = new()
            {
                UserId = username,
                FileId = username,
                FileName = filename,
                FileLocation = "Images/" + updateFolderName(username) + "/" + filename,
            };
            ClientUserfilesclass.PostAsync(userFiles);

        }

        public async void postCapturedPhotoAsync(string username, string filename)
        {
            var photo = await MediaPicker.CapturePhotoAsync();

            if (photo == null)
                return;

            var task = await new FirebaseStorage("canywhere-ed9ad.appspot.com",
                new FirebaseStorageOptions
                {
                    ThrowOnCancel = true
                })
                .Child("Images")
                .Child(updateFolderName(username))
                .Child(filename)
                .PutAsync(await photo.OpenReadAsync());

            ClientUserfilesclass ClientUserfilesclass = new ClientUserfilesclass();
            UserFiles userFiles = new()
            {
                UserId = username,
                FileId = username,
                FileName = filename,
                FileLocation = "Images/" + updateFolderName(username) + "/" + filename,
            };
            ClientUserfilesclass.PostAsync(userFiles);

        }


        public async void postCapturedVideoAsync(string username, string filename)
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
                .Child(filename)
                .PutAsync(await video.OpenReadAsync());

            ClientUserfilesclass ClientUserfilesclass = new ClientUserfilesclass();
            UserFiles userFiles = new()
            {
                UserId = username,
                FileId = username,
                FileName = filename,
                FileLocation = "Images/" + updateFolderName(username) + "/" + filename,
            };
            ClientUserfilesclass.PostAsync(userFiles);


        }

        public async Task<ObservableCollection<string>> getImagesAndVideosAsync()
        {
            ClientUserfilesclass ClientUserfilesclass = new ClientUserfilesclass();
            ObservableCollection<UserFiles> UserFiels = await ClientUserfilesclass.GetAsync();
            ObservableCollection<string> urls = new ObservableCollection<string>();
            foreach (UserFiles userFile in UserFiels)
            {
                var task = await new FirebaseStorage("canywhere-ed9ad.appspot.com",
                new FirebaseStorageOptions
                {
                    ThrowOnCancel = true
                })
                .Child(userFile.FileLocation).GetDownloadUrlAsync();
                urls.Add(task);

            }
            return urls;

        }

        private string updateFolderName(string username)
        {
            username = username.Replace("@", "atTheRate").Replace(".", "dot").ToUpper();
            return username;
        }
    }
}
