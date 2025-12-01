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

	public class Sprzet {
		[Key]
		public int Id { get; set; }
		[Column(TypeName="nvarchar(20)")]
		public String Typ { get; set; }
		[Column(TypeName = "nvarchar(30)")]
		public String Marka { get; set; }
		[Column(TypeName = "int")]
		public int Rozmiar { get; set; }
		[Column(TypeName="date")]
		public DateTime Data_zakupu { get; set; }
		[Column(TypeName ="intintiger")]
		public int Koszt_wypozyczenia { get; set; }
	}
}