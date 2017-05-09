using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IoTModel;
using IoTDAL;

namespace IoTPLL
{
    class DispositivoService
    {
        static private DispositivoDAO dispositivoDAO = new DispositivoDAO();

        public int incluir(Dispositivo dispositivo)
        {
            return dispositivoDAO.incluir(dispositivo);
        }
        public void alterar(Dispositivo dispositivo)
        {
            dispositivoDAO.alterar(dispositivo);
        }
        public Dispositivo obter(int id) { return dispositivoDAO.obter(id); }
        public List<Dispositivo> obterTodos() { return dispositivoDAO.obterTodos(); }
    }
}
