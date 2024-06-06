using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using KochinProject_ISP21K.Models;
using KochinProject_ISP21K.ViewModels;

namespace KochinProject_ISP21K.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<Client> Clients { get; set; }
        public ObservableCollection<Schedule> Schedules { get; set; }
        public ObservableCollection<Card> Cards { get; set; } 

        public MainViewModel()
        {
            Clients = new ObservableCollection<Client>
            {
                new Client { Id = 1, Name = "Иван Иванов", Email = "ivanov@example.com", Phone = "123-456-7890" }
            };

            Schedules = new ObservableCollection<Schedule>();
            Cards = new ObservableCollection<Card>(); 
        }
    }
}
