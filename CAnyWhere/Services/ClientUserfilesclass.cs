using System;
using CAnyWhere.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace CAnyWhere.Services
{
	public class ClientUserfilesclass : ClientUserfilesInterface
	{
        readonly FirebaseClient firebaseClient = new("https://canywhere-ed9ad-default-rtdb.firebaseio.com");

        ObservableCollection<UserFiles> DataResponse { get; set; } = new ObservableCollection<UserFiles>();

        async void ClientUserfilesInterface.DeleteAsync(UserFiles model)
        {
            var selected = DataResponse.Where(k => k.Key == model.Key).FirstOrDefault();

            await firebaseClient.Child("UserFiles").Child(selected.Key).DeleteAsync();

            DataResponse.Remove(selected);
        }

        async Task<ObservableCollection<UserFiles>> ClientUserfilesInterface.GetAsync()
        {
            var GetItems = (await firebaseClient
                  .Child("UserFiles")
                  .OnceAsync<UserFiles>()).Select(item => new UserFiles
                  {
                      FileId = item.Object.FileId,
                      UserId = item.Object.UserId,
                      FileName = item.Object.FileName,
                      FileLocation = item.Object.FileLocation,
                      Key = item.Key
                  });

            foreach (var item in GetItems)
            {
                DataResponse.Add(item);
            }

            return DataResponse;
        }

        async void ClientUserfilesInterface.PostAsync(UserFiles model)
        {
            await firebaseClient.Child("UserFiles").PostAsync(new UserFiles(model.FileId, model.UserId, model.FileName, model.FileLocation));
        }

        async void ClientUserfilesInterface.UpdateAsync(UserFiles model)
        {
            await firebaseClient.Child("UserFiles").PutAsync(model);
        }
    }
}

