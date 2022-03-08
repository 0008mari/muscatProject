﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace muscatApi.Models
{
    [Table("PWD")]
    public partial class Pwd
    {
        [Key]
        public int Id { get; set; }
        public byte[] Password { get; set; } = null!;

        [ForeignKey(nameof(Id))]
        [InverseProperty(nameof(MyUser.Pwd))]
        public virtual MyUser IdNavigation { get; set; } = null!;
    }
}
