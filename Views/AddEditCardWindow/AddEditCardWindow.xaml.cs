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
    public partial class AddEditCardWindow : Window
    {
        public Card Card { get; private set; }

        public AddEditCardWindow()
        {
            InitializeComponent();
            Card = new Card();
            DataContext = Card;

            Loaded += Window_Loaded;
        }

        public AddEditCardWindow(Card card)
        {
            InitializeComponent();
            Card = card;
            DataContext = Card;

            Loaded += Window_Loaded;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void RemoveText(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Tag != null && textBox.Text == textBox.Tag.ToString())
            {
                textBox.Text = "";
                textBox.Foreground = Brushes.Black;
            }
        }

        private void AddText(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Tag.ToString();
                textBox.Foreground = Brushes.Gray;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CardNumberTextBox.Tag = "Card Number";
            ServiceTextBox.Tag = "Service";

            AddText(CardNumberTextBox, null);
            AddText(ServiceTextBox, null);
        }
    }
}
