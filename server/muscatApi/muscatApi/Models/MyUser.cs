using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace muscatApi.Models
{
    [Table("MyUser")]
    public partial class MyUser
    {
        [Key]
        public int Id { get; set; }
        [StringLength(60)]
        [Unicode(false)]
        public string Email { get; set; } = null!;
        [Column(TypeName = "date")]
        public DateTime BirthDate { get; set; }
        [StringLength(10)]
        public string Name { get; set; } = null!;
        public int MyStatus { get; set; }
        [Column(TypeName = "date")]
        public DateTime RegisteredDate { get; set; }

        [InverseProperty("IdNavigation")]
        public virtual Pwd Pwd { get; set; } = null!;
    }
}
