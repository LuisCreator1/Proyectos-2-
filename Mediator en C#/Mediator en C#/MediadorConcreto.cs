using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_en_C_
{
    public class MediadorConcreto : IMediador
    {
        private List<Colega> colegas;

        public MediadorConcreto()
        {
            colegas = new List<Colega>();
        }

        public void AddColega(Colega colega)
        {
            colegas.Add(colega);
        }

        public void EnviarMensaje(string mensaje, Colega emisor)
        {
            foreach (var colega in colegas)
            {
                if (colega != emisor)
                {
                    colega.Recibe(mensaje);
                }
            }
        }
    }
}