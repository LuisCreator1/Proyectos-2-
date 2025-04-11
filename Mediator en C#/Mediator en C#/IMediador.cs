using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_en_C_
{
    public interface IMediador
    {
        void EnviarMensaje(string mensaje, Colega colega);
    }


