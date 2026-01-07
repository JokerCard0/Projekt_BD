using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models {

    public class Klient {

        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        [Required(ErrorMessage = "Podaj Imie"), MaxLength(20, ErrorMessage = "Za d³ugie nazwisko")]
        public String? Imie { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        [Required(ErrorMessage = "Podaj Nazwisko"), MaxLength(30, ErrorMessage = "Za d³ugie nazwisko")]
        public String? Nazwisko { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        [Required(ErrorMessage = "Podaj pesel"),RegularExpression(@"^\d{11}$",ErrorMessage = "Podaj prawid³owy pesel")]
        public String? Pesel {  get; set; }

        [Column(TypeName = "int")]
        [Required(ErrorMessage = "B³¹d dodawania relacji z Adres.cs")]
        public int AdresId { get; set; }
        public Adres? Adres { get; set; }

        public ICollection<Wypozyczenie>? Wypozyczenie { get; set; }
    }
}
