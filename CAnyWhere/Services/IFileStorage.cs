using CAnyWhere.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAnyWhere.Services
{
    internal interface IFileStorage
    {
        void postPickedPhotoAsync(string username, string filename);

        void postPickedVideoAsync(string username, string filename);

        void postCapturedPhotoAsync(string username, string filename);

        void postCapturedVideoAsync(string username, string filename);

        Task<ObservableCollection<string>> getImagesAndVideosAsync();
    }
}
