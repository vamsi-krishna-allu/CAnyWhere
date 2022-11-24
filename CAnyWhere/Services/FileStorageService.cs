using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Storage;
using Xamarin.Essentials;

namespace CAnyWhere.Services
{
    public class FileStorageService : IFileStorage
    {

        public async void postAsync(string username)
        {
            var photo = await MediaPicker.PickPhotoAsync();

            /* var video = await MediaPicker.PickVideoAsync();

             var newPhoto = await MediaPicker.CapturePhotoAsync();

             var newvideo = await MediaPicker.CaptureVideoAsync();*/

            if (photo == null)
                return;

            var task = new FirebaseStorage("canywhere-ed9ad.appspot.com",
                new FirebaseStorageOptions
                {
                    ThrowOnCancel = true
                })
                .Child("Images")
                .Child(username)
                .Child(photo.FileName)
                .PutAsync(await photo.OpenReadAsync());

        }
    }
}
