using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public class Bil : Kørertøj
    {
        public override int Pris(int pris) 
        { 
            if (Dato.DayOfWeek == DayOfWeek.Saturday || Dato.DayOfWeek == DayOfWeek.Sunday && HarBrobizz )
                {
                    return pris - ((pris /100*20) + (pris /100*5));
                }
            if (Dato.DayOfWeek == DayOfWeek.Saturday || Dato.DayOfWeek == DayOfWeek.Sunday && !HarBrobizz)
                    {
                        return pris - (pris /100*20);
                    }
            if (HarBrobizz)
            {
                return pris - pris /100*5;
            }
            return pris;
        }

        public override string TypeAfKørertøj()
        {
            return "Bil";
        }


        public Bil(string nummerplade, DateTime dato) : base(nummerplade, dato)
        {
        }
    }
}
