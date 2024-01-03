using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashApp.Data.Models
{
    public class Translate
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Преводач { get; set; }

        [Required]
        public string ДатаНаПревода { get; set; }

        [Required]
        public decimal Стойност { get; set; }
    }
}
