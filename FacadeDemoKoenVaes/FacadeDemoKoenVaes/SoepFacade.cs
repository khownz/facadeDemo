using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDemoKoenVaes
{
    class SoepFacade
    {
        Vuur vuur;
        Kookpot kookpot;
        Groenten groenten;

        public SoepFacade(Vuur vuur, Kookpot kookpot, Groenten groenten)
        {
            this.vuur = vuur;
            this.kookpot = kookpot;
            this.groenten = groenten;
        }

        public void maakSoep()
        {
            groenten.afspoelen();
            groenten.snijden();
            vuur.zetAan();
            kookpot.voegWaterToe();
            kookpot.voegGroentenToe(groenten);
            kookpot.zetOpVuur(vuur);

            Console.WriteLine("De soep is aan het koken...");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("De soep is klaar");
        }

        public void ruimOp()
        {
            kookpot.haalVanVuur(vuur);
            vuur.zetUit();

            Console.WriteLine("Eet smakelijk");
        }
    }
}
