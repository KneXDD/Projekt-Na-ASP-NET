using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Models
{
    public class Mandate
    {
        [Key]
        [Display(Name = "Numer Mandatu")]
        public int MandateId { get; set; }
        [Display(Name = "Numer Rejestracyjny")]
        public string RegistrationNumber { get; set; }
        [Display(Name = "Cena")]
        public int Price { get; set; }
        [Display(Name = "Ulica")]
        public string Street { get; set; }
        [Display(Name = "Data")]
        public DateTime Date { get; set; }
        [Display(Name = "Opłacony")]
        public bool paid { get; set; }
        [Display(Name = "Zdjęcie")]
        public string PictureUrl { get; set; }
    }
}
