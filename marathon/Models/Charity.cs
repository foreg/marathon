using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Marathon.Models
{
    [Table("charity")]
    public class Charity
    {
        [Key]
        [Required]
        public int CharityId { get; set; }
        [MaxLength(100)]
        [Required]
        public string CharityName { get; set; }
        [MaxLength(2000)]
        public string CharityDescription { get; set; }
        [MaxLength(50)]
        public string CharityLogo { get; set; }
    }
}