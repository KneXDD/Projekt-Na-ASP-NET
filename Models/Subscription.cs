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
        [Display(Name = "Numer Abonamentu")]
        public int SubscriptionId { get; set; }
        [Display(Name = "Numer Rejestracyjny")]
        public string RegistrationNumber { get; set; }
        [Display(Name = "Imię")]
        public string Name { get; set; }
        [Display(Name = "Nazwisko")]
        public string Surname { get; set; }
        [Display(Name = "Ulica")]
        public string Street { get; set; }
        [Display(Name = "Data rozpoczęcia")]
        public DateTime StartDate { get; set; }
        [Display(Name = "Data zakończenia")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Rodzaj Abonamentu")]
        public SubscriptionVariant SubscriptionVariant { get; set; }
        [Display(Name = "Aktywny")]
        public bool Active { get; set; }
    }
}
