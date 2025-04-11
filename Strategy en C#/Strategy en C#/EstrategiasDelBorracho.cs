using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_en_C_
{
    public class EstrategiasDelBorracho
    {
        private IBorracho borracho;

        public EstrategiasDelBorracho()
        {
            borracho = new EstrategiaOjitos(); 
        }

        public void EstablecerConquistaOjitos()
        {
            borracho = new EstrategiaOjitos();
        }

        public void EstablecerConquistaInvitarCerveza()
        {
            borracho = new EstrategiaInvitarCerveza();
        }

        public void EstablecerConquistaCaraDeGalan()
        {
            borracho = new EstrategiaHacerCaraDeGalan();
        }

        public void Conquistar()
        {
            borracho.Conquistar();
        }
    }
}