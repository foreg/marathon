using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Marathon.Models
{
    [Table("role")]
    public class Role
    {
        [Key]
        [Required]
        [Column(TypeName = "char")]
        public string RoleId { get; set; }
        [MaxLength(50)]
        [Required]
        public string RoleName { get; set; }

        public virtual List<User> Users { get; set; }
    }
}
