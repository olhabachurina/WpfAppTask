using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public class Task
    {
        public string Name { get; set; }
        public ObservableCollection<Task> Subtasks { get; set; }

        public Task()
        {
            // Конструктор без параметров
            Subtasks = new ObservableCollection<Task>();
        }
    }

    public partial class MainWindow : Window
    {
        public ObservableCollection<Task> Tasks { get; set; }

        public MainWindow()
        { 
        InitializeComponent();
            
            Tasks = new ObservableCollection<Task>
            {
                new Task
                {
                    Name = "Разработка приложения",
                    Subtasks = new ObservableCollection<Task>
                    {
                        new Task
                        {
                            Name = "Изучение технологий и инструментов",
                            Subtasks = new ObservableCollection<Task>
                            {
                                new Task
                                {
                                    Name = "Изучить базовые концепции разработки",
                                    Subtasks = new ObservableCollection<Task>
                                    {
                                        new Task { Name = "Изучение официальной документации технологии" },
                                        new Task { Name = "Решение задач,связанных с использованием технологии" }
                                    }
                                },
                                new Task { Name = "Создать структуру базы данных" }
                            }
                        },
                        new Task { Name = "Тестирование приложения" }
                    }
                },
                new Task
                {
                    Name = "Проектирование приложения",
                    Subtasks = new ObservableCollection<Task>
                    {
                        new Task { Name = "Определить основные функциональные требования приложения" },
                        new Task { Name = "Разработать макет пользовательского интерфейса" }
                    }
                }
            };

           DataContext = this; // Эта строка устанавливает контекст данных для экземпляра MainWindow
        }
    }
}