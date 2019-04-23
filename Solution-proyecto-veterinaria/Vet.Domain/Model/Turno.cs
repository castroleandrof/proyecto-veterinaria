using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet.Domain.Model
{
    class Turno
    {
        public DateTime fecha { get; set; }
        public Cliente cliente { get; set; }
        public Mascota mascota { get; set; }
        public Medico medico { get; set; }
        public Room room { get; set; }
    }
}
