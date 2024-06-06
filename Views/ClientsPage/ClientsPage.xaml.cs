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
    public partial class ClientsPage : Page
    {
        public ClientsPage()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void AddClient_Click(object sender, RoutedEventArgs e)
        {
            var addClientWindow = new AddEditClientWindow();
            if (addClientWindow.ShowDialog() == true)
            {
                var newClient = addClientWindow.Client;
                ((MainViewModel)DataContext).Clients.Add(newClient);
            }
        }

        private void EditClient_Click(object sender, RoutedEventArgs e)
        {
            var client = ((FrameworkElement)sender).DataContext as Client;
            if (client != null)
            {
                var editClientWindow = new AddEditClientWindow(client);
                if (editClientWindow.ShowDialog() == true)
                {
                    var updatedClient = editClientWindow.Client;
                    var index = ((MainViewModel)DataContext).Clients.IndexOf(client);
                    ((MainViewModel)DataContext).Clients[index] = updatedClient;
                }
            }
        }

        private void DetailClient_Click(object sender, RoutedEventArgs e)
        {
            var client = ((FrameworkElement)sender).DataContext as Client;
            if (client != null)
            {
                var detailWindow = new ClientDetailWindow(client);
                detailWindow.ShowDialog();
            }
        }

        private void DeleteClient_Click(object sender, RoutedEventArgs e)
        {
            var client = ((FrameworkElement)sender).DataContext as Client;
            if (client != null)
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить этого клиента?", "Подтверждение удаления", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    ((MainViewModel)DataContext).Clients.Remove(client);
                }
            }
        }
    }
}
