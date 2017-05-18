using System.Collections.Generic;
using IoTModel;
namespace IoTDAL
{
    public class EstadoDispositivoDAO
    {
        public int incluir(EstadoDispositivo estado)
        {
            Dispositivo dispositivo = DispositivoDAO.dispositivos[estado.DispositivoId - 1];
            estado.Id = dispositivo.Historico.Count + 1;
            estado.Dispositivo = dispositivo;
            dispositivo.Historico.Add(estado);
            return estado.Id;
        }
        public EstadoDispositivo obterUltimo(int dispositivoId)
        {
            if (dispositivoId <= DispositivoDAO.dispositivos.Count)
            {
                Dispositivo dispositivo = DispositivoDAO.dispositivos[dispositivoId - 1];
                int max = 0;
                EstadoDispositivo retorno = null;
                foreach (EstadoDispositivo estado in dispositivo.Historico)
                {
                    if (estado.Id > max)
                    {
                        max = estado.Id;
                        retorno = estado;
                    }
                }
                return retorno;
            }
            return null;
        }
    }
}
