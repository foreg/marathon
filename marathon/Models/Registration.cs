using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Marathon.Models
{
    [Table("registration")]
    public class Registration
    {
        [Key]
        [Required]
        public int RegistrationId { get; set; }
        [Required]
        public int RunnerId { get; set; }
        [Required]
        public DateTime RegistrationDateTime { get; set; }
        [MaxLength(1)]
        [Column(TypeName = "char")]
        [Required]
        public string RaceKitOptionId { get; set; }
        [Required]
        public short RegistrationStatusId { get; set; }
        [Required]
        public decimal Cost { get; set; }
        [Required]
        public int CharityId { get; set; }
        [Required]
        public int SponsorshipTarget { get; set; }


        [ForeignKey("RunnerId")]
        public virtual Runner Runner { get; set; }
        //[ForeignKey("RaceKitOptionId")]
        //public virtual RaceKitOption RaceKitOption { get; set; }
        //[ForeignKey("RegistrationStatusId")]
        //public virtual RegistrationStatus RegistrationStatus { get; set; }
        [ForeignKey("CharityId")]
        public virtual Charity Charity { get; set; }

        public string RunnerFullName
        {
            get
            {
                return $"{Runner.User.FirstName}, {Runner.User.LastName} - {RunnerId} ({Runner.Country.CountryName})";
            }
        }
    }
}
