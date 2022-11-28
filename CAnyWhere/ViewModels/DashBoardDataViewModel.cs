using CAnyWhere.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAnyWhere.ViewModels
{
    internal class DashBoardDataViewModel
    {
        public ObservableCollection<DashBoardData> DashBoardDataCollection { get; set; }
        public DashBoardDataViewModel()
        {
            DashBoardDataCollection = new ObservableCollection<DashBoardData>();
            DashBoardData obj = new();
            obj.SourceUrl = "https://media.istockphoto.com/id/1001313596/photo/woman-raised-her-hand-for-dissuade-campaign-stop-violence-against-women-asian-woman-raised.jpg?b=1&s=170667a&w=0&k=20&c=zzE8R9pvP9J2IIhqGNI5f0Nr-6JVpbk_yEQW7GKvbFw=";
            obj.PostedDate = "12/5/2022";
            obj.Description = "harrasment";
            obj.LikeCount = "10";
            obj.DislikeCount = "2";
            DashBoardDataCollection.Add(obj);

            obj.SourceUrl = "https://www.alamy.com/teenage-boy-being-bullied-at-school-covered-his-face-group-of-students-threatening-to-hit-classmate-or-junior-at-university-concept-of-teasing-image339718429.html?imageid=B922C54D-5D22-4D0B-ABA0-1510A142CF97&p=645714&pn=1&searchId=c3e6c3cf7e3fd44e6972f014984aefd4&searchtype=0";
            obj.PostedDate = "12/5/2032";
            obj.Description = "Ragging";
            obj.LikeCount = "15";
            obj.DislikeCount = "5";
            DashBoardDataCollection.Add(obj);


            obj.SourceUrl = "https://images.unsplash.com/photo-1546957222-39a2f31d3644?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Nnx8YnVsbHlpbmd8ZW58MHx8MHx8&auto=format&fit=crop&w=500&q=60";
            obj.PostedDate = "11/12/2022";
            obj.Description = "Bullying";
            obj.LikeCount = "15";
            obj.DislikeCount = "3";
            DashBoardDataCollection.Add(obj);

            obj.SourceUrl = "https://plus.unsplash.com/premium_photo-1661400309821-328822169ce1?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8N3x8cm9vbW1hdGVzfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60";
            obj.PostedDate = "1/2/2022";
            obj.Description = "RoomMateIssue";
            obj.LikeCount = "25";
            obj.DislikeCount = "5";
            DashBoardDataCollection.Add(obj);

            obj.SourceUrl = " obj.SourceUrl = \"https://plus.unsplash.com/premium_photo-1661400309821-328822169ce1?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxzZWFyY2h8N3x8cm9vbW1hdGVzfGVufDB8fDB8fA%3D%3D&auto=format&fit=crop&w=500&q=60\";\r\n            obj.PostedDate = \"11/12/2022\";\r\n            obj.Description = \"RoomMateIssue\";\r\n            obj.LikeCount = \"25\";\r\n            obj.DislikeCount = \"5\";\r\n            DashBoardDataCollection.Add(obj);";
            obj.PostedDate = "11/1/2022";
            obj.Description = "Accidents";
            obj.LikeCount = "35";
            obj.DislikeCount = "8";
            DashBoardDataCollection.Add(obj);
        }

    }
}
