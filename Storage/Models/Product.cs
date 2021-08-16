using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "produktnamn")]
        [Required]
        [StringLength(30, ErrorMessage = "max 30")]
        public string Name { get; set; }

        [Display(Name="pris")]
        [Range(0, 1000000, ErrorMessage ="måste vare mellan 0-1000000")]
        public int Price { get; set; }

        [Display(Name="Inköpsdatum")]
        [DataType(DataType.Date)]
        public DateTime Orderdate { get; set; }


        [Display(Name="kategori")]
        [Required]
        public string Category { get; set; }

        [Display(Name="hylla")]
        public string Shelf { get; set; }

        [Display(Name="saldo")]
        [Range(0, 1000)]        
        public int Count { get; set; }

        [Display(Name="beskrivning")]
        public string Description { get; set; }
    }
}
