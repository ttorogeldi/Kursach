using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace MauiApp2.Models
{
    public class ScheduleViewModel : BindableObject
    {
        public ObservableCollection<ScheduleItem> Schedule { get; set; }

        public ScheduleViewModel()
        {
            // Populate sample data
            Schedule = new ObservableCollection<ScheduleItem>
            {
                new ScheduleItem { CourseName = "Math", Instructor = "Prof. Smith", Time = "9:00 AM - 10:30 AM", Location = "Room 101" },
                new ScheduleItem { CourseName = "History", Instructor = "Prof. Johnson", Time = "11:00 AM - 12:30 PM", Location = "Room 102" },
                // Add more items as needed
            };
        }
    }
}
