using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Marathon.Models
{
    [Table("gender")]
    public class Gender
    {
        [Key]
        [Required]
        [MaxLength(10)]
        [Column("Gender")]
        public string GenderName { get; set; }
    }
}
