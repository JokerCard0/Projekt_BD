using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models {

    public class Klient {
        public int id { get; set}
        public string kod_pocztowy { get; set}
        public string ulica { get; set}
        public string numer_budynku { get; set}
        public string numer_mieszkania { get; set}
    }
}