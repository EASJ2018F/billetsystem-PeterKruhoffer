using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public class Bil : Kørertøj
    {
        public override int Pris() 
        {
            if (HarBrobizz && Dato.DayOfWeek == DayOfWeek.Saturday || Dato.DayOfWeek == DayOfWeek.Sunday)
            {

                return 240 - (20 / 100) - (5 / 100);
            }
            if (Dato.DayOfWeek == DayOfWeek.Saturday || Dato.DayOfWeek == DayOfWeek.Sunday)
            {
                return 240 - (20 / 100);
            }
            if (HarBrobizz)
            {
                return 240 - (5 / 100);
            }

            return 240;
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
