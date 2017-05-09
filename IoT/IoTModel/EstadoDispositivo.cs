using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTModel
{
    class EstadoDispositivo
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int Valor { get; set; }
        public int DispositivoId { get; set; }
        public virtual Dispositivo Dispositivo { get; set; }
    }
}
