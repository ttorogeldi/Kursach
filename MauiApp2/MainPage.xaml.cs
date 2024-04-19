using System.ComponentModel;

namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        private Days Pi_20_1;
        private Days Pi_20_2;
        private Days Pi_21_1;
        private Groups tester = new Groups();
        
        public MainPage()
        { 
            InitializeComponent();

            Pi_20_1 = new Days
            {
                Monday = new Schedule {}
            };
            
            Pi_20_2 = new Days
            {
                Monday =
                {
                    First = new Discipline
                    {
                    },
                    Second = new Discipline
                    {
                    },
                    Third = new Discipline
                    {
                    }
                }
            };
            
            Pi_21_1 = new Days
            {
                Monday =
                {
                    First = new Discipline
                    {
                    },
                    Second = new Discipline
                    {
                    },
                    Third = new Discipline
                    {
                    }
                }
            };
            
            tester = new Groups
                {
                    Current = Pi_20_1,
                    Other  = new List<Days>
                    {
                        Pi_20_2,
                        Pi_21_1
                    }
            };

        }
        private void OnGroupSelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            var selectedGroup = picker.SelectedItem.ToString();

            switch (selectedGroup)
            {
                case "ПИ-1-20":
                    LessonsStackLayout1.IsVisible = true;
                    Test1.SelectedLessonItem = new Groups
                    {
                        Current = Pi_20_1,
                        Other = new List<Days> { Pi_21_1, Pi_20_2 }
                    };
                    break;
                case "ПИ-2-20":
                    LessonsStackLayout1.IsVisible = true;
                    Test1.SelectedLessonItem = new Groups
                    {
                        Current = Pi_20_2,
                        Other = new List<Days> { Pi_21_1, Pi_20_1 }
                    };
                    break;
                case "ПИ-1-21":
                    LessonsStackLayout1.IsVisible = true;
                    Test1.SelectedLessonItem = new Groups
                    {
                        Current = Pi_21_1,
                        Other = new List<Days> { Pi_20_1, Pi_20_2 }
                    };
                    break;
                // Add more cases for additional groups
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
