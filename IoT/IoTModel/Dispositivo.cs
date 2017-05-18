using System.Collections.Generic;

namespace IoTModel
{
    public class Dispositivo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Tipo { get; set; }
        public virtual ICollection<EstadoDispositivo> Historico { get; set; }
    }
}
