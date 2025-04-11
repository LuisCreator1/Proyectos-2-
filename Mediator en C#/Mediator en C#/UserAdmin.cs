using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_en_C_
{
    public class UserAdmin : Colega
    {
        public UserAdmin(IMediador mediador) : base(mediador) { }

        public override void Recibe(string mensaje)
        {
            Console.WriteLine("Un administrador recibe: " + mensaje);
        }
    }
}