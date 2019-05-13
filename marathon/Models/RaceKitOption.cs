using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Marathon.Models
{
    [Table("racekitoption")]
    class RaceKitOption
    {
        [Key]
        [Required]
        [MaxLength(1)]
        [Column(TypeName = "char")]
        public string RaceKitOptionId { get; set; }
        //[Required]
        //[MaxLength(80)] // todo доделать модель
        //public string RaceKitOption { get; set; }
    }
}
