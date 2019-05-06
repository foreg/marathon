using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Marathon.Models
{
    [Table("runner")]
    public class Runner
    {
        [Key]
        [Required]
        public string RunnerId { get; set; }
        [MaxLength(100)]
        [Required]
        public string Email { get; set; }

        [MaxLength(100)]
        [Required]
        public string GenderName { get; set; }

        public DateTime DateOfBirth { get; set; }

        [MaxLength(3)]
        [Column(TypeName = "char")]
        [Required]
        public string CountryCode { get; set; }


        [ForeignKey("GenderName")]
        public virtual Gender Gender { get; set; }
        [ForeignKey("CountryCode")]
        public virtual Country Country { get; set; }
    }
}
