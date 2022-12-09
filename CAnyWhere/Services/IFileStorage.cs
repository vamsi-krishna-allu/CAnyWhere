using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAnyWhere.Services
{
    internal interface IFileStorage
    {
        void postPickedPhotoAsync(string username);

        void postPickedVideoAsync(string username);

        void postCapturedPhotoAsync(string username);

        void postCapturedVideoAsync(string username);

        void getImagesAndVideosAsync();
    }
}
