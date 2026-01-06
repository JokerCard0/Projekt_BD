using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using backend.Validation;

namespace backend.Models {

	public class Wypozyczenie {
		[Key]
		public int Id { get; set; }


		[Column(TypeName = "int")]
		[Required()]
		public int KlientId { get; set; }
        public Klient? Klient { get; set; }


        [Column(TypeName = "int")]
        [Required()]
        public int SprzetId { get; set; }
        public Sprzet? Sprzet { get; set; }


        [Column(TypeName = "date"),Display(Name = "Data wypo¿yczenia")]
        [Required(ErrorMessage = "podaj date"), DataType(DataType.Date, ErrorMessage = "Wybierz wartoœæ która jest dat¹"),TodayOrFuture(ErrorMessage = "Wybierz nadchodz¹c¹ date (nie przesz³¹!)")]
        public DateOnly Data_wypoz { get; set; } = DateOnly.FromDateTime(DateTime.Today);

        [Column(TypeName = "int"),Display(Name = "Okres wypo¿yczenia")]
        [Required(),Range(1,14,ErrorMessage = "W wypadku wynajmu na d³u¿szy okres ni¿ dwa tygodnie prosimy o kontakt telefoniczny.")]
        public int Okres_wypoz { get; set; }

        [Column(TypeName = "int")]
        [Required]
        public int Aktywne { get; set; } = 1;
    }
}