using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models.ViewModels
{
    public class WypozyczViewModel
    {
        public int SprzetId { get; set; }


        //KLIENT
        [Column(TypeName = "nvarchar(20)")]
        [Required(ErrorMessage = "Podaj Imie")]
        public String? Imie { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        [Required(ErrorMessage = "Podaj Nazwisko")]
        public String? Nazwisko { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        [Required(ErrorMessage = "Podaj pesel"), RegularExpression(@"^\d{11}$", ErrorMessage = "Podaj prawidłowy pesel")]
        public String? Pesel { get; set; }

        [Column(TypeName = "int")]
        [Required(ErrorMessage = "Błąd dodawania relacji z Adres.cs")]
        public int AdresId { get; set; }

        

        //ADRES
        [Column(TypeName = "nvarchar(6)")]
        [Required(ErrorMessage = "Wpisz kod pocztowy"), RegularExpression(@"^\d{2}-\d{3}$", ErrorMessage = "Kod pocztowy musi być w formacie 00-000")]
        public String? Kod_pocztowy { get; set; }


        [Column(TypeName = "nvarchar(40)")]
        [Required(ErrorMessage = "Podaj miasto")]
        public String? Miasto { get; set; }


        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "Podaj ulice"), MinLength(3, ErrorMessage = "Nazwa ulicy musi się składać z conajmniej trzech znaków")]
        public String? Ulica { get; set; }


        [Column(TypeName = "nvarchar(5)")]
        [Required(ErrorMessage = "Podaj numer budynku")]
        public String? Numer_budynku { get; set; }


        [Column(TypeName = "varchar(5)")]
        public String? Numer_mieszkania { get; set; }


        //WYPOZYCZENIE
        [Column(TypeName = "date")]
        [Required(ErrorMessage = "podaj date"), DataType(DataType.Date, ErrorMessage = "Wybierz wartość która jest datą")]
        public DateOnly Data_wypoz { get; set; } = DateOnly.FromDateTime(DateTime.Today);

        [Column(TypeName = "int")]
        [Required(), Range(1, 14, ErrorMessage = "W wypadku wynajmu na dłuższy okres niż dwa tygodnie prosimy o kontakt telefoniczny.")]
        public int Okres_wypoz { get; set; }
    }
}
