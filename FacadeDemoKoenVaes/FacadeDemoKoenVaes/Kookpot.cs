using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDemoKoenVaes
{
    class Kookpot
    {

        public void voegWaterToe()
        {
            Console.WriteLine("Er zit water in de kookpot");
        }

        public void voegGroentenToe(Groenten groenten)
        {
            Console.WriteLine("De groenten zitten in de kookpot");
        }

        public void zetOpVuur(Vuur vuur)
        {
            Console.WriteLine("De kookpot staat op het vuur");
        }

        public void haalVanVuur(Vuur vuur)
        {
            Console.WriteLine("De kookpot is van het vuur gehaald");
        }
    }
}
