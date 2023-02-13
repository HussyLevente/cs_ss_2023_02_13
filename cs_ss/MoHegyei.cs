using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_ss
{
    internal class MoHegyei
    {
        public string HegyCsucsNeve;
        public string Hegyseg;
        public int Magassag;

        public MoHegyei(string hegycsucsNeve, string hegyseg, string magassag)
        {
            HegyCsucsNeve = hegycsucsNeve;
            Hegyseg = hegyseg;
            Magassag = int.Parse(magassag);
        }
    }
}
