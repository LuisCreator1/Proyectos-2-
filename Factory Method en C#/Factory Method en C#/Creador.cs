using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_en_C_
{
    public class Creador
    {
        public const string VINO_TINTO = "vino_tinto";
        public const string CERVEZA = "cerveza";

        public static BebidaEmbriagante CrearBebida(string tipo)
        {
            switch (tipo)
            {
                case VINO_TINTO:
                    return new VinoTinto();
                case CERVEZA:
                    return new Cerveza();
                default:
                    return null;
            }
        }
    }
