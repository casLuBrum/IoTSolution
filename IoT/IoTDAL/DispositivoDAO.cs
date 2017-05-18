using System.Collections.Generic;
using IoTModel;

namespace IoTDAL
{
    public class DispositivoDAO
    {
        static internal List<Dispositivo> dispositivos = new List<Dispositivo>();

        public int incluir(Dispositivo dispositivo) {
            dispositivo.Id = dispositivos.Count + 1;
            dispositivo.Historico = new List<EstadoDispositivo>();
            dispositivos.Add(dispositivo);
            return dispositivo.Id;
        }
        public void alterar(Dispositivo dispositivo) { }
        public Dispositivo obter(int id) {
            if (id <= dispositivos.Count)
            {
                return dispositivos[id - 1];
            }
            return null;
        }
        public List<Dispositivo> obterTodos() { return dispositivos; }
    }
}
