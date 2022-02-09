using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Models
{
    public class Customers
    {
        [Key]
        [Display(Name = "Numer klienta")]
        public int CustomersId { get; set; }
        [Display(Name = "Imię")]
        [Required(ErrorMessage = "Imię jest wymagane")]
        public string Name { get; set; }
        [Display(Name = "Nazwisko")]
        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        public string Surname { get; set; }
        [Display(Name = "Pesel")]
        [Required(ErrorMessage = "Pesel jest wymagany")]
        [Range(9, 9, ErrorMessage = "Pesel wymaga 9 znaków")]
        public int IdNumber { get; set; }
        [Display(Name = "Data dodania klienta")]
        [Required(ErrorMessage = "Data dodania jest wymagana")]
        public DateTime Date { get; set; }
        [Display(Name = "Numer wniosku")]
        [Required(ErrorMessage = "Numer wniosku jest wymagany")]
        public int ApplicationNumber { get; set; }

        //Relacje
        public List<Subscription> Subscriptions { get; set; }
    }
}
