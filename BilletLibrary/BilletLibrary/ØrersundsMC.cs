using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public class ØrersundsMC : Kørertøj
    {
        public ØrersundsMC(string nummerplade, DateTime dato) : base(nummerplade, dato)
        {
        }

        public override int Pris(int pris)
        {
            if (HarBrobizz)
            {
                return 73;
            }
            return 210;
        }

        public override string TypeAfKørertøj()
        {
            return "Ørersund MC";
        }
    }
}
