using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace backend.Models
{

	public enum Rodzaje
	{
		Snowboard,
		Narty
	}
	
	public enum Marki
	{
		Head,
		Atomic,
		Rossignol,
		Salomon,
		Fischer,
		Volk,
		K2,
		Blizzard
	}

	public class Sprzet {
		[Key]
		public int Id { get; set; }


		[Column(TypeName="nvarchar(30)")]
		[Required(ErrorMessage = "Wybierz typ z listy"),EnumDataType(typeof(Rodzaje),ErrorMessage = "Nie wybrano typu z listy")]
		public Rodzaje? Typ { get; set; }


		[Column(TypeName = "nvarchar(30)")]
		[Required(ErrorMessage = "Wybierz marke z listy"),EnumDataType(typeof(Marki),ErrorMessage = "Nie wybrano marki z listy")]
		public Marki? Marka { get; set; }


		[Column(TypeName = "int")]
		[Required(ErrorMessage = "Wybierz rozmiar"),Range(60,220,ErrorMessage = "Wybierz z poprawnego zakresu rozmiar sprzêtu")]
		public int Rozmiar { get; set; }


		[Column(TypeName="date")]
		[Required(ErrorMessage = "podaj date"),DataType(DataType.Date,ErrorMessage = "Wybierz wartoœæ która jest dat¹")]
		public DateOnly Data_zakupu { get; set; }

		[Column(TypeName ="int")]
		[Required(ErrorMessage = "Podaj koszt wypo¿yczenia"),Range(1,int.MaxValue,ErrorMessage = "Podaj ca³kowit¹ wartoœæ liczbow¹")]
		public int Koszt_wypozyczenia { get; set; }

		public ICollection<Wypozyczenie>? Wypozyczenie { get; set; }
	}
}