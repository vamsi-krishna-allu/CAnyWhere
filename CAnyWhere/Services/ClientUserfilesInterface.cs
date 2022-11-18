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
        Task<ObservableCollection<UserFiles>> GetAsync();
        void PostAsync(UserFiles model);
        void UpdateAsync(UserFiles model);
        void DeleteAsync(UserFiles model);
    }
}

