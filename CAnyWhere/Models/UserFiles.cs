using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAnyWhere.Models
{
    internal class UserFiles
    {
        public string FileId { get; set; }
        public string UserId { get; set; }
        public string FileName { get; set; }
        public string FileLocation { get; set; }

        public UserFiles(string FileId, string UserId, string FileName, string FileLoaction)
        {
            this.FileId = FileId;
            this.UserId = UserId;
            this.FileName = FileName;
            this.FileLocation = FileLoaction;
        }
    }
}
