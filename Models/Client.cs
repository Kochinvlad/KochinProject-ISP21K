using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KochinProject_ISP21K.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }

    public class Schedule
    {
        [Key]
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public string Activity { get; set; }
        public string Room { get; set; }
        public string Employee { get; set; }
    }

    public class Card
    {
        [Key]
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public string Services { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

}
