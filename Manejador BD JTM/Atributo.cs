using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manejador_BD_JTM
{
    class Atributo
    {
        public char[] nombre_Atributo;
        public char[] nombre_ArchivoLlaveForanea;
        public string nombeAtributo_String, nombre_ArchivoLlaveForaneaString;
        public char tipoDeDato;
        public int longitudDato, tipocve;
        public long DireccionAtributo, DireccionIndice, DireccionSigAtributo;//tipo de dato long para los apuntadores de 8 bytes

        public Atributo()
        {
            nombre_Atributo = new char[35];
           
            nombre_ArchivoLlaveForanea = new char[35];
          
            longitudDato = tipocve = 0;
            DireccionAtributo = DireccionIndice = DireccionSigAtributo = 0;
        }
    }
}
