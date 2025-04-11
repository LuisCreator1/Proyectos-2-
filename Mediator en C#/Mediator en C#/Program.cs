using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_en_C_
{
    class Program
    {
        static void Main()
        {
            var mediador = new MediadorConcreto();

            var pepe = new User(mediador);
            var admin1 = new UserAdmin(mediador);
            var admin2 = new UserAdmin(mediador);

            mediador.AddColega(pepe);
            mediador.AddColega(admin1);
            mediador.AddColega(admin2);

            pepe.Comunicar("Oye admin, tengo un problema");
        }
    }
}