using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_en_C_
{
    public abstract class Colega
    {
        private IMediador mediador;

        public Colega(IMediador mediador)
        {
            this.mediador = mediador;
        }

        public IMediador Mediador => mediador;

        public void Comunicar(string mensaje)
        {
            mediador.EnviarMensaje(mensaje, this);
        }

        public abstract void Recibe(string mensaje);
    }
}