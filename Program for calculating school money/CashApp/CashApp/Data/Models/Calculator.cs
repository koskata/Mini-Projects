using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashApp.Data.Models
{
    public class Calculator
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public decimal Стипендия { get; set; }

        [Required]
        public decimal Транспортни { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string Месец { get; set; }

        [Required]
        public decimal СумаЗаМесеца { get; set; }

    }
}
