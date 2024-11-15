using System.Collections.Generic;
using System;

namespace Case_Opgave
{
    public class Fag
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public Lærer Lærer { get; set; }
        public List<Elev> Elever { get; set; }
    }
}

