using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroPrueba.Shared
{
    public class Cliente : Persona
    {
        public string DireccionDomicilio { get; set; }
        public List<string> Mensajes { get; set; }
    }
}
