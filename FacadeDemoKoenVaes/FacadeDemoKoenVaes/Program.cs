using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDemoKoenVaes
{
    class Program
    {
        static void Main(string[] args)
        {
            Vuur vuur = new Vuur();
            Kookpot kookpot = new Kookpot();
            Groenten groenten = new Groenten();

            SoepFacade sf = new SoepFacade(vuur, kookpot, groenten);

            sf.maakSoep();

            sf.ruimOp();




            Console.ReadLine();
        }
    }
}
