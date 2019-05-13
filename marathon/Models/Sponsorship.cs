using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Marathon.Models
{
    [Table("sponsorship")]
    public class Sponsorship
    {
        [Key]
        [Required]
        public int SponsorshipId { get; set; }
        [MaxLength(150)]
        [Required]
        public string SponsorName { get; set; }
        [Required]
        public int RegistrationId { get; set; }
        [Required]
        public decimal Amount { get; set; }


        [ForeignKey("RegistrationId")]
        public virtual Registration Registration { get; set; }
    }
}
