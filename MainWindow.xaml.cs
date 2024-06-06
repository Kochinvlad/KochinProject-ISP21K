using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using KochinProject_ISP21K.Models;
using KochinProject_ISP21K.ViewModels;
using KochinProject_ISP21K.Views;

namespace KochinProject_ISP21K
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Загрузка начального окна при запуске
            MainContentFrame.Content = new HomePage(); // Замените HomePage на ваш начальный контент, если он другой
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Content = new HomePage(); // Замените HomePage на ваш начальный контент, если он другой
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (sender is MenuItem menuItem)
            {
                switch (menuItem.Tag.ToString())
                {
                    case "SchedulePage":
                        MainContentFrame.Content = new SchedulePage();
                        break;
                    case "CardsPage":
                        MainContentFrame.Content = new CardsPage();
                        break;
                    case "ClientsPage":
                        MainContentFrame.Content = new ClientsPage();
                        break;
                }
            }
        }
    }
}
