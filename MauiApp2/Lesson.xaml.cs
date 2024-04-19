using System.ComponentModel;
using Microsoft.Maui.Controls;
using Syncfusion.Maui.Popup;

namespace MauiApp2
{
    public partial class Lesson : INotifyPropertyChanged
    {
        public List<LessonOptions> LessonsOptions { get; set; }
        
        public static readonly BindableProperty SelectedLessonItemProperty =
            BindableProperty.Create(nameof(SelectedLessonItem), typeof(Groups), typeof(Lesson), null);
        
        public Groups SelectedLessonItem
        {
            get => (Groups)GetValue(SelectedLessonItemProperty);
            set => SetValue(SelectedLessonItemProperty, value);
        }  
        
        public Lesson()
        {
            InitializeComponent();

            LessonsOptions = new List<LessonOptions>
            {
                new()
                {
                    SubjectOptions = new List<string>
                    {
                        "Выберите предмет", 
                        "Введение в программную инженерию",
                        "Информационные системы в экономике ", 
                        "Информационная безопасность",
                        "Геоинформационные системы",
                        "Компьютерные сети и администрирование",
                        "Интеллектуальный анализ больших данных",
                        "Искусственный интеллект и его применение",
                        "Тестирование программного обеспечения",
                        "Объектно- оринтированное программирование",
                        "Технология командной разработки программного обеспечения ",
                        "Хранилище данных и Интеллектуальный анализ данных",
                        "Компьютерные сети и системы"
                    },
                    TeacherOptions = new List<string> { 
                        "Выберите препода",
                        "Омуров Максат Таалайбекович", 
                        "Эралиев Жээнбек Торонович", 
                        "Бегалиев Самыйбек Алтынбекович", 
                        "Нааматова Жибек Бейшенбековна", 
                        "Исаева Гулмира Сейтназировна", 
                        "Баячорова Батыйгуль Джумадыловна"
                        
                    }
                    // Add more options for other types of options as needed
                },
                // Create similar LessonOptions objects for other lessons
            };
            
            BindingContext = this;
        }
     
        public static readonly BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text), typeof(string), typeof(Lesson), string.Empty); 
        
        public static readonly BindableProperty KeyProperty =
            BindableProperty.Create(nameof(Key), typeof(string), typeof(Lesson), string.Empty);
        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }
        
        public string Key
        {
            get => (string)GetValue(KeyProperty);
            set => SetValue(KeyProperty, value);
        }
        
        private void OnGroupSelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            var selectedGroup = picker.SelectedItem.ToString();
            string pickerName = picker.ClassId;

            var count = 0;
            switch (pickerName)
            {
                case "Monday_First":
                    count = SelectedLessonItem.Other
                        .Count(x => x.Monday.First.Subject == SelectedLessonItem.Current.Monday.First.Subject);
                    if (count > 0)
                    {
                    }
                    break;
                case "Monday_Second":
                    count = SelectedLessonItem.Other
                        .Count(x => x.Monday.First.Subject == SelectedLessonItem.Current.Monday.First.Subject);
                    if (count > 0)
                    {
                    }
                    break;
                case "Monday_Third":
                   count = SelectedLessonItem.Other
                        .Count(x => x.Monday.First.Subject == SelectedLessonItem.Current.Monday.First.Subject);
                    
                    break;
                // Add more cases for additional groups
            }
            
        }
       
    }
    public class LessonOptions
    {
        public List<string> SubjectOptions { get; set; }
        public List<string> TeacherOptions { get; set; }

        public string SubjectPlaceholder { get; set; } = "Select Subject";
        public string TeacherPlaceholder { get; set; } = "Select Teacher";
    }
}