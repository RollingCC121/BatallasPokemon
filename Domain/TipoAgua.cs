using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batallasPokemon.Domain
{
    public class TipoAgua : ITipo
    {
        // DECISIÓN POR FALTA DE DETALLE EN UML: Id constante para identificar el tipo
        public string Id => "Agua";
    }
}
