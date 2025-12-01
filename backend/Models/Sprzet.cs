using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{

	public class Sprzet {
		public int id { get; set; }
		public String typ { get; set; }
		public String marka { get; set; }
		public int rozmiar { get; set; }
		public DateTime data_zakupu { get; set; }
		public int koszt_wypozyczenia { get; set; }
	}
}