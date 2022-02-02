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
        public int MandateId { get; set; }
        public string RegistrationNumber { get; set; }
        public int Price { get; set; }
        public string Street { get; set; }
        public DateTime Date { get; set; }
        public bool paid { get; set; }
        public string PictureUrl { get; set; }
    }
}
