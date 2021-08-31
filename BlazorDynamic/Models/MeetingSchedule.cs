
using Microsoft.AspNetCore.Components;

namespace BlazorDynamic.Models;
    public partial class MeetingSchedule : ComponentBase
    {
        public int Id { get; set; }
        public string? Subject { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int? EID { get; set; }

        public static List<MeetingSchedule> GetMeetingData()
        {
            List<MeetingSchedule> ScheduleData = new()
            {
                new MeetingSchedule { Id = 1, Subject = "Meeting with Alex", StartTime = new DateTime(2020, 03, 02, 09, 30, 0), EndTime = new DateTime(2020, 03, 02, 10, 30, 0), EID = 1 },
                new MeetingSchedule { Id = 2, Subject = "Meeting with Bob", StartTime = new DateTime(2020, 03, 02, 09, 30, 0), EndTime = new DateTime(2020, 03, 02, 10, 30, 0), EID = 1 },
                new MeetingSchedule { Id = 3, Subject = "Meeting with Catherine", StartTime = new DateTime(2020, 03, 03, 09, 30, 0), EndTime = new DateTime(2020, 03, 03, 10, 30, 0), EID = 2 },
                new MeetingSchedule { Id = 4, Subject = "Meeting with Dany", StartTime = new DateTime(2020, 03, 03, 09, 30, 0), EndTime = new DateTime(2020, 03, 03, 10, 30, 0), EID = 2 },
                new MeetingSchedule { Id = 5, Subject = "Meeting with Eliot", StartTime = new DateTime(2020, 03, 04, 09, 30, 0), EndTime = new DateTime(2020, 03, 04, 10, 30, 0), EID = 3 },
                new MeetingSchedule { Id = 6, Subject = "Meeting with Frezey", StartTime = new DateTime(2020, 03, 04, 09, 30, 0), EndTime = new DateTime(2020, 03, 04, 10, 30, 0), EID = 3 },
                new MeetingSchedule { Id = 7, Subject = "Meeting with Goldie", StartTime = new DateTime(2020, 03, 05, 09, 30, 0), EndTime = new DateTime(2020, 03, 05, 10, 30, 0), EID = 4 },
                new MeetingSchedule { Id = 8, Subject = "Meeting with Harman", StartTime = new DateTime(2020, 03, 05, 09, 30, 0), EndTime = new DateTime(2020, 03, 05, 10, 30, 0), EID = 4 },
                new MeetingSchedule { Id = 9, Subject = "Meeting with Irwin", StartTime = new DateTime(2020, 03, 06, 09, 30, 0), EndTime = new DateTime(2020, 03, 06, 10, 30, 0), EID = 5 },
                new MeetingSchedule { Id = 10, Subject = "Meeting with Jack", StartTime = new DateTime(2020, 03, 06, 09, 30, 0), EndTime = new DateTime(2020, 03, 06, 10, 30, 0), EID = 5 },
                new MeetingSchedule { Id = 11, Subject = "Meeting with Klay", StartTime = new DateTime(2020, 03, 06, 09, 30, 0), EndTime = new DateTime(2020, 03, 06, 10, 30, 0), EID = 6 },
                new MeetingSchedule { Id = 12, Subject = "Meeting with Lucy", StartTime = new DateTime(2020, 03, 07, 09, 30, 0), EndTime = new DateTime(2020, 03, 07, 10, 30, 0), EID = 6 },
                new MeetingSchedule { Id = 13, Subject = "Meeting with Moni", StartTime = new DateTime(2020, 03, 07, 09, 30, 0), EndTime = new DateTime(2020, 03, 07, 10, 30, 0), EID = 7 },
                new MeetingSchedule { Id = 14, Subject = "Meeting with Nancy", StartTime = new DateTime(2020, 03, 07, 09, 30, 0), EndTime = new DateTime(2020, 03, 07, 10, 30, 0), EID = 7 },
                new MeetingSchedule { Id = 15, Subject = "Meeting with Orley", StartTime = new DateTime(2020, 03, 08, 09, 30, 0), EndTime = new DateTime(2020, 03, 08, 10, 30, 0), EID = 8 },
                new MeetingSchedule { Id = 16, Subject = "Meeting with Prince", StartTime = new DateTime(2020, 03, 08, 09, 30, 0), EndTime = new DateTime(2020, 03, 08, 10, 30, 0), EID = 8 },
                new MeetingSchedule { Id = 17, Subject = "Meeting with Queen", StartTime = new DateTime(2020, 03, 08, 09, 30, 0), EndTime = new DateTime(2020, 03, 08, 10, 30, 0), EID = 9 },
                new MeetingSchedule { Id = 18, Subject = "Meeting with Rockstar", StartTime = new DateTime(2020, 03, 09, 09, 30, 0), EndTime = new DateTime(2020, 03, 09, 10, 30, 0), EID = 9 }
            };
            return ScheduleData;
        }
    }
