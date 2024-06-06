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

namespace KochinProject_ISP21K.Views
{
    public partial class ScheduleDetailWindow : Window
    {
        public ScheduleDetailWindow(Schedule schedule)
        {
            InitializeComponent();
            DataContext = schedule;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
