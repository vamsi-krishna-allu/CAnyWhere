using System;
using CAnyWhere.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace CAnyWhere.Services
{
	internal interface ClientUserfilesInterface
	{
        Task<ObservableCollection<User>> GetAsync();
        void PostAsync(User model);
        void UpdateAsync(User model);
        void DeleteAsync(User model);
    }
}

