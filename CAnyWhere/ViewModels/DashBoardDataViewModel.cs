using CAnyWhere.Models;
using CAnyWhere.Services;
using MvvmHelpers;
using MvvmHelpers.Commands;
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
        public ObservableRangeCollection<DashBoardData> DashBoardDataCollection { get; set; }
        public AsyncCommand PageAppearingCommand { get; }

        public DashBoardDataViewModel()
        {
            DashBoardDataCollection = new ObservableRangeCollection<DashBoardData>();
            PageAppearingCommand = new AsyncCommand(PageAppearing);
        }

        public async Task Refresh()
        {
            DashBoardData obj = new();
            obj.SourceUrl = "C:\\Users\\visha\\source\\FinalProject\\CAnyWhere\\CAnyWhere\\Resources\\Images\\stop.jpg";
            obj.PostedDate = "12/5/2022";
            obj.Description = "harrasment";
            obj.LikeCount = "10";
            obj.DislikeCount = "2";
            DashBoardDataCollection.Add(obj);

            obj = new();
            obj.SourceUrl = "C:\\Users\\visha\\source\\FinalProject\\CAnyWhere\\CAnyWhere\\Resources\\Images\\stop.jpg";
            obj.PostedDate = "12/5/2032";
            obj.Description = "Ragging";
            obj.LikeCount = "15";
            obj.DislikeCount = "5";
            DashBoardDataCollection.Add(obj);

            obj = new();
            obj.SourceUrl = "C:\\Users\\visha\\source\\FinalProject\\CAnyWhere\\CAnyWhere\\Resources\\Images\\stop.jpg";
            obj.PostedDate = "11/12/2022";
            obj.Description = "Bullying";
            obj.LikeCount = "15";
            obj.DislikeCount = "3";
            DashBoardDataCollection.Add(obj);

            obj = new();
            obj.SourceUrl = "C:\\Users\\visha\\source\\FinalProject\\CAnyWhere\\CAnyWhere\\Resources\\Images\\stop.jpg";
            obj.PostedDate = "1/2/2022";
            obj.Description = "RoomMateIssue";
            obj.LikeCount = "25";
            obj.DislikeCount = "5";
            DashBoardDataCollection.Add(obj);

            obj = new();
            obj.SourceUrl = "C:\\Users\\visha\\source\\FinalProject\\CAnyWhere\\CAnyWhere\\Resources\\Images\\stop.jpg";
            obj.PostedDate = "11/1/2022";
            obj.Description = "Accidents";
            obj.LikeCount = "35";
            obj.DislikeCount = "8";
            DashBoardDataCollection.Add(obj);
        }

        async Task PageAppearing()
        {
            await Refresh();
        }

    }
}
