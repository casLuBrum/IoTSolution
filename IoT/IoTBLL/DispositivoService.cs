using System.Collections.Generic;

using IoTDAL;
using IoTModel;

namespace IoTBLL
{
    public class DispositivoService
    {
        static private DispositivoDAO dispositivoDAO = new DispositivoDAO();
        static private EstadoDispositivoDAO estadoDispositivoDAO = new EstadoDispositivoDAO();

        public int incluir(Dispositivo dispositivo) { return dispositivoDAO.incluir(dispositivo); }
        public void alterar(Dispositivo dispositivo) { dispositivoDAO.alterar(dispositivo); }
        public Dispositivo obter(int id) { return dispositivoDAO.obter(id); }
        public List<Dispositivo> obterTodos() { return dispositivoDAO.obterTodos(); }
        public int alterarEstado(EstadoDispositivo estado) { return estadoDispositivoDAO.incluir(estado); }
        public EstadoDispositivo ultimoEstado(int dispositivoId) { return estadoDispositivoDAO.obterUltimo(dispositivoId); }
    }
}
