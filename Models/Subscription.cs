using Projekt.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Models
{
    public class Subscription
    {
        [Key]
        public int SubscriptionId { get; set; }
        public string RegistrationNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Street { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public SubscriptionVariant SubscriptionVariant { get; set; }
        public bool Active { get; set; }
    }
}
