using System;
using IoTBLL;
using IoTModel;

namespace IoTWeb
{
    public partial class DetalheDispositivo : System.Web.UI.Page
    {
        static private DispositivoService dispositivoService = new DispositivoService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["id"] != null)
            {
                int id = (int)Session["id"];
                if (id > 0)
                {
                    LabelResultadoMsg.Text = (string)Session["msg"];
                    Dispositivo dispositivo = dispositivoService.obter(id);
                    TextId.Text = "" + dispositivo.Id;
                    TextNome.Text = dispositivo.Nome;
                    RadioButtonTipo.SelectedValue = (dispositivo.Tipo == 0) ? "0" : "1";
                }
            }
        }
    }
}