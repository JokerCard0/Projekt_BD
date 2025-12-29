using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models {

    public class Adres {

        [Key]
        public int Id { get; set; }


        [Column(TypeName = "nvarchar(6)")]
        [Required(ErrorMessage = "Wpisz kod pocztowy"), RegularExpression(@"^\d{2}-\d{3}$", ErrorMessage = "Kod pocztowy musi byæ w formacie 00-000")]
        public String? Kod_pocztowy { get; set; }


        [Column(TypeName = "nvarchar(40)")]
        [Required(ErrorMessage = "Podaj miasto")]
        public String? Miasto { get; set; }


        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "Podaj ulice"),MinLength(3,ErrorMessage = "Nazwa ulicy musi siê sk³adaæ z conajmniej trzech znaków")]
        public String? Ulica { get; set; }


        [Column(TypeName = "nvarchar(5)")]
        [Required(ErrorMessage = "Podaj numer budynku")]
        public String? Numer_budynku { get; set; }


        [Column(TypeName = "varchar(5)")]
        public String? Numer_mieszkania { get; set; }

        public ICollection<Klient>? Klienci { get; set; }
    }
}