using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_en_C_
public class Cerveza : BebidaEmbriagante
{
    public override int CuantoMeEmbriaga()
    {
        return 5;
    }
}