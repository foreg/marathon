using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Marathon.Models
{
    [Table("user")]
    public class User
    {
        [Key]
        [MaxLength(100)]
        [Required]
        public string Email { get; set; }
        [MaxLength(100)]
        [Required]
        public string Password { get; set; }
        [MaxLength(80)]
        public string FirstName { get; set; }
        [MaxLength(80)]
        public string LastName { get; set; }
        [Column(TypeName = "char")]
        [Required]
        public string RoleId { get; set; }


        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }
    }
}
