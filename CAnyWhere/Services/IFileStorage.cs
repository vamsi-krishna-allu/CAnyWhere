using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAnyWhere.Services
{
    internal interface IFileStorage
    {
        void postAsync(string username);
    }
}
