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

        ObservableCollection<User> DataResponse { get; set; } = new ObservableCollection<User>();

        async void ClientUserfilesInterface.DeleteAsync(User model)
        {
            var selected = DataResponse.Where(k => k.Key == model.Key).FirstOrDefault();

            await firebaseClient.Child("User").Child(selected.Key).DeleteAsync();

            DataResponse.Remove(selected);
        }

        async Task<ObservableCollection<User>> ClientUserfilesInterface.GetAsync()
        {
            var GetItems = (await firebaseClient
                  .Child("User")
                  .OnceAsync<User>()).Select(item => new User
                  {
                      EmailId = item.Object.EmailId,
                      Name = item.Object.Name,
                      Password = item.Object.Password,
                      UserType = item.Object.UserType,
                      Key = item.Key
                  });

            foreach (var item in GetItems)
            {
                DataResponse.Add(item);
            }

            return DataResponse;
        }

        async void ClientUserfilesInterface.PostAsync(User model)
        {
            await firebaseClient.Child("User").PostAsync(new User(model.EmailId, model.Name, model.Password, model.UserType));
        }

        async void ClientUserfilesInterface.UpdateAsync(User model)
        {
            await firebaseClient.Child("User").PutAsync(model);
        }
    }
}

