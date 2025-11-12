using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databinding.Coleccion.Models
{
    class OrigenDePaquete
    {
        public string Nombre { get; set; } = string.Empty;
        public string Origen { get; set; } = string.Empty;
        public bool EstadoHabilitado { get; set; } = false;

        public override string ToString()
        {
            return $"{Nombre}, {Origen}";
        }
    }
}
