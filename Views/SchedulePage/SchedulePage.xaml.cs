using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using KochinProject_ISP21K.Models;
using KochinProject_ISP21K.ViewModels;

namespace KochinProject_ISP21K.Views
{
    public partial class SchedulePage : Page
    {
        public SchedulePage()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void AddSchedule_Click(object sender, RoutedEventArgs e)
        {
            var addScheduleWindow = new AddEditScheduleWindow();
            if (addScheduleWindow.ShowDialog() == true)
            {
                var newSchedule = addScheduleWindow.Schedule;
                ((MainViewModel)DataContext).Schedules.Add(newSchedule);
            }
        }

        private void EditSchedule_Click(object sender, RoutedEventArgs e)
        {
            var schedule = ((FrameworkElement)sender).DataContext as Schedule;
            if (schedule != null)
            {
                var editScheduleWindow = new AddEditScheduleWindow(schedule);
                if (editScheduleWindow.ShowDialog() == true)
                {
                    var updatedSchedule = editScheduleWindow.Schedule;
                    var index = ((MainViewModel)DataContext).Schedules.IndexOf(schedule);
                    ((MainViewModel)DataContext).Schedules[index] = updatedSchedule;
                }
            }
        }

        private void DetailSchedule_Click(object sender, RoutedEventArgs e)
        {
            var schedule = ((FrameworkElement)sender).DataContext as Schedule;
            if (schedule != null)
            {
                var detailWindow = new ScheduleDetailWindow(schedule);
                detailWindow.ShowDialog();
            }
        }

        private void DeleteSchedule_Click(object sender, RoutedEventArgs e)
        {
            var schedule = ((FrameworkElement)sender).DataContext as Schedule;
            if (schedule != null)
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить это расписание?", "Подтверждение удаления", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    ((MainViewModel)DataContext).Schedules.Remove(schedule);
                }
            }
        }
    }
}
