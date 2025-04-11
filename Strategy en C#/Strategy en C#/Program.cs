using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_en_C_
{
    class Program
    {
        static void Main()
        {
            EstrategiasDelBorracho borracho = new EstrategiasDelBorracho();

            borracho.Conquistar(); // Ojitos
            borracho.EstablecerConquistaInvitarCerveza();
            borracho.Conquistar(); // Invitar cerveza
            borracho.EstablecerConquistaCaraDeGalan();
            borracho.Conquistar(); // Cara de galán
        }
    }
}