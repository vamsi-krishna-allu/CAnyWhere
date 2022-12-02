using CAnyWhere.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAnyWhere.Services
{
    public class LoginClientService : ILoginClientService
    {
        readonly FirebaseClient firebaseClient = new("https://canywhere-ed9ad-default-rtdb.firebaseio.com");

        ObservableCollection<User> DataResponse { get; set; } = new ObservableCollection<User>();

        public async void DeleteAsync(User model)
        {
            var selected = DataResponse.Where(k => k.Key == model.Key).FirstOrDefault();

            await firebaseClient.Child("User").Child(selected.Key).DeleteAsync();

            DataResponse.Remove(selected);
        }

        public async Task<User> GetAsync(string key)
        {
            User user = new();
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
                if (item.Key.Equals(key))
                {
                    user = item;
                    break;
                }
            }

            return user;
        }

        public async void PostAsync(User model)
        {
            model.Key = model.EmailId.Replace("@", "atTheRate").Replace(".", "dot").ToUpper();
            await firebaseClient.Child("User").Child(model.Key).PutAsync(new User(model.EmailId, model.Name, model.Password, model.UserType));
        }

        public async void UpdateAsync(User model)
        {
            await firebaseClient.Child("User").PutAsync(model);   
        }

    }
}
