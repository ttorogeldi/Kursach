using System.ComponentModel;
using Microsoft.Maui.Controls;

namespace MauiApp2
{
    public partial class Lesson : INotifyPropertyChanged
    {
        public List<LessonOptions> LessonsOptions { get; set; }
        public Lesson()
        {
            InitializeComponent();
            LessonsOptions = new List<LessonOptions>
            {
                new()
                {
                    SubjectOptions = new List<string>
                    {
                        "Select Subject", 
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
                        "Select Teacher",
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
        public Lesson(Item lessonItem)
        {
            InitializeComponent();
            _lessonItem = lessonItem;
            BindingContext = _lessonItem;
            LessonsOptions = new List<LessonOptions>
            {
                new()
                {
                    SubjectOptions = new List<string>
                    {
                        "Select Subject", 
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
                        "Select Teacher",
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

        public string SelectedItem { get; set; }

        private Item _lessonItem = new Item();

        public Item LessonItem
        {
            get { return _lessonItem ; }
            set
            {
                _lessonItem = value;
                OnPropertyChanged(nameof(LessonItem));
            }
        }
     
        public static readonly BindableProperty TextProperty =
            BindableProperty.Create(nameof(Text), typeof(string), typeof(Lesson), string.Empty);
        public static readonly BindableProperty ItemProperty =
            BindableProperty.Create(nameof(Item), typeof(Item), typeof(Lesson), null);
        
        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
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