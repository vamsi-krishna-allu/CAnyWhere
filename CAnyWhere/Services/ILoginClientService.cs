using CAnyWhere.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAnyWhere.Services
{
    internal interface ILoginClientService
    {
        Task<User> GetAsync(string key);
        void PostAsync(User model);
        void UpdateAsync(User model);
        void DeleteAsync(User model);

    }
}
