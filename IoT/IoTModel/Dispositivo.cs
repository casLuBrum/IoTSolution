using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTModel
{
    class Dispositivo
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Tipo { get; set; }
        public virtual ICollection<EstadoDispositivo> Historico { get; set; }
    }
}
