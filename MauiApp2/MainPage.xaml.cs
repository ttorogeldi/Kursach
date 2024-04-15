using System.ComponentModel;

namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        private List<Item> group1Lessons;
        private List<Item> group2Lessons;
        private List<Item> group3Lessons;
        // Add more groups as needed
        private List<Item> _selectedGroupLessons = new List<Item>
        {
        };

        public List<Item> SelectedGroupLessons
        {
            get => _selectedGroupLessons;
            set
            {
                _selectedGroupLessons = value;
                OnPropertyChanged(nameof(SelectedGroupLessons));
            }
        }
        
        public MainPage()
        {
            InitializeComponent();

            // Initialize lessons for each group
            group1Lessons = new List<Item>
            {
                new Item { TimeRange = "08:00 - 09:20", Subject = 0, Teacher = 0 },
                new Item { TimeRange = "09:20 - 10:40", Subject = 0, Teacher =0 },
                new Item { TimeRange = "10:40 - 12:00", Subject = 0, Teacher = 0 },
                new Item { TimeRange = "12:00 - 13:20", Subject = 0, Teacher = 0 },
                new Item { TimeRange = "13:20 - 14:40", Subject = 0, Teacher = 0 }
            };
            
            group2Lessons = new List<Item>
            {
                new Item { TimeRange = "08:00 - 09:20", Subject = 0, Teacher = 0 },
                new Item { TimeRange = "09:20 - 10:40", Subject = 0, Teacher =0 },
                new Item { TimeRange = "10:40 - 12:00", Subject = 0, Teacher = 0 },
                new Item { TimeRange = "12:00 - 13:20", Subject = 0, Teacher = 0 },
                new Item { TimeRange = "13:20 - 14:40", Subject = 0, Teacher = 0 }
            };
            
            group3Lessons = new List<Item>
            {
                new Item { TimeRange = "08:00 - 09:20", Subject = 0, Teacher = 0 },
                new Item { TimeRange = "09:20 - 10:40", Subject = 0, Teacher =0 },
                new Item { TimeRange = "10:40 - 12:00", Subject = 0, Teacher = 0 },
                new Item { TimeRange = "12:00 - 13:20", Subject = 0, Teacher = 0 },
                new Item { TimeRange = "13:20 - 14:40", Subject = 0, Teacher = 0 }
            };

        }
        
        
        private void OnGroupSelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            var selectedGroup = picker.SelectedItem.ToString();

            // Update the SelectedGroupLessons property based on the selected group
            switch (selectedGroup)
            {
                case "Group 1":
                    SelectedGroupLessons= group1Lessons;
                    break;
                case "Group 2":
                    SelectedGroupLessons = group2Lessons;
                    break;
                case "Group 3":
                    SelectedGroupLessons = group3Lessons;
                    break;
                // Add more cases for additional groups
            }
            AddLessonsToStack(SelectedGroupLessons);
        }
        private void AddLessonsToStack(List<Item> lessons)
        {
            foreach (var lesson in lessons)
            {
                var lessonView = new Lesson(lesson); // Create a new instance of Lesson with the provided lesson object
                LessonsStackLayout.Children.Add(lessonView); // Add the Lesson instance to the Children collection of the StackLayout
            }
        }


        // Other code...

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
