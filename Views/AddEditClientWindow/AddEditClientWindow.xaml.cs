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
    public partial class AddEditClientWindow : Window
    {
        public Client Client { get; private set; }

        public AddEditClientWindow()
        {
            InitializeComponent();
            Client = new Client();
            DataContext = Client;
        }

        public AddEditClientWindow(Client client)
        {
            InitializeComponent();
            Client = client;
            DataContext = Client;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
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
            NameTextBox.Tag = "Name";
            EmailTextBox.Tag = "Email";
            PhoneTextBox.Tag = "Phone";

            AddText(NameTextBox, null);
            AddText(EmailTextBox, null);
            AddText(PhoneTextBox, null);
        }
    }
}
