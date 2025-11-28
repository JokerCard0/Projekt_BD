using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models {

	public class Wypozyczenia {

		public int id { get; set}
		public int id_klienta { get; set}
		public int id_sprzetu { get; set}
		public DateTime data_wypoz { get; set}
		public int okres_wypoz { get; set}
	}
}