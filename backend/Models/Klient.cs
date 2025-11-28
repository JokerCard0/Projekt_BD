using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models {

    public class Klient {
        public int id { get; set}
        public string imie { get; set}
        public string nazwisko { get; set}
        public int id_adresu { get; set}
    }
}
