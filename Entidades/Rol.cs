using Entidades.Habilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rol
    {

        // Declaracion de propiedades.
        public int IdRol { get; set; }
        public string Nombre { get; set; }
        public override string ToString()
        {
            return this.Nombre;
        }
    }
}