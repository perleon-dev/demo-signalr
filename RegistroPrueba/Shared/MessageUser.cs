using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroPrueba.Shared
{
    public class MessageUser : Persona
    {
        public bool Emisor { get; set; }
        public string Mensaje { get; set; }
        //public Message Mesanje { get; set; } = new();
    }
}
