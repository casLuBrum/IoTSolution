using System;

namespace IoTModel
{
    public class EstadoDispositivo
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int Valor { get; set; }
        public int DispositivoId { get; set; }
        public virtual Dispositivo Dispositivo { get; set; }
    }
}
