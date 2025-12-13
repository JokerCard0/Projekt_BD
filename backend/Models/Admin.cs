using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace backend.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName ="nvarchar(30)")]
        [Required(ErrorMessage = "Podaj login"), NotNull]
        public string? Name { get; set; }

        [Column(TypeName = "nvarchar(512)")]
        [Required(ErrorMessage ="Podaj hasło"),NotNull]
        public string? Pass { get; set; }
    }
}
