using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models {

    public class Adresy {
        public int id { get; set; }
        public String kod_pocztowy { get; set; }
        public String ulica { get; set; }
        public String numer_budynku { get; set; }
        public String numer_mieszkania { get; set; }
    }
}