using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Marathon.Models
{
    [Table("country")]
    public class Country
    {
        [Key]
        [Required]
        [MaxLength(3)]
        [Column(TypeName = "char")]
        public string CountryCode { get; set; }

        [MaxLength(100)]
        [Required]
        public string CountryName { get; set; }

        [MaxLength(100)]
        [Required]
        public string CountryFlag { get; set; }
    }
}
