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
   public partial class CardsPage : Page
    {
        public CardsPage()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void AddCard_Click(object sender, RoutedEventArgs e)
        {
            var addCardWindow = new AddEditCardWindow();
            if (addCardWindow.ShowDialog() == true)
            {
                var newCard = addCardWindow.Card;
                ((MainViewModel)DataContext).Cards.Add(newCard);
            }
        }

        private void EditCard_Click(object sender, RoutedEventArgs e)
        {
            var card = ((FrameworkElement)sender).DataContext as Card;
            if (card != null)
            {
                var editCardWindow = new AddEditCardWindow(card);
                if (editCardWindow.ShowDialog() == true)
                {
                    var updatedCard = editCardWindow.Card;
                    var index = ((MainViewModel)DataContext).Cards.IndexOf(card);
                    ((MainViewModel)DataContext).Cards[index] = updatedCard;
                }
            }
        }

        private void DetailCard_Click(object sender, RoutedEventArgs e)
        {
             var card = ((FrameworkElement)sender).DataContext as Card;
            if (card != null)
            {
                var detailWindow = new CardDetailWindow(card);
                detailWindow.ShowDialog();
            }
        }

        private void DeleteCard_Click(object sender, RoutedEventArgs e)
        {
            var card = ((FrameworkElement)sender).DataContext as Card;
            if (card != null)
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить эту услугу карты?", "Подтверждение удаления", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    ((MainViewModel)DataContext).Cards.Remove(card);
                }
            }
        }
    }
}
