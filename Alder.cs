using System.Collections.Generic;
using System;

namespace Case_Opgave
{
    public struct Alder
    {
        public static int BeregnAlder(DateTime fødselsdato)
        {
            return (DateTime.Now - fødselsdato).Days / 365;
        }
    }
}
