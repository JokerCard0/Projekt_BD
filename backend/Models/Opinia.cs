using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Opinia
    {
        [Key]
        public int Id { get; set; }


        [Column(TypeName = "int"), Display(Name = "Ocena sprzętu")]
        [Required(ErrorMessage = "Wybierz Ocene"), Range(1, 10, ErrorMessage = "Wybierz z poprawnego zakresu oceny od 1 do 10")]
        public int OcenaSperzetu { get; set; }


        [Column(TypeName = "int"), Display(Name = "Ocena obsługi")]
        [Required(ErrorMessage = "Wybierz Ocene"), Range(1, 10, ErrorMessage = "Wybierz z poprawnego zakresu oceny od 1 do 10")]
        public int OcenaObslugi { get; set; }


        [Column(TypeName = "int"), Display(Name = "Ocena zwrotu sprzętu")]
        [Required(ErrorMessage = "Wybierz Ocene"), Range(1, 10, ErrorMessage = "Wybierz z poprawnego zakresu oceny od 1 do 10")]
        public int OcenaZwrotu { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        public string? Tresc { get; set; }

    }
}
