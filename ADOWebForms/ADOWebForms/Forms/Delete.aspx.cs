using ADOWebForms.ADO;
using ADOWebForms.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADOWebForms.Forms
{
    public partial class Delete_aspx : System.Web.UI.Page
    {
        ADOEstatusAlumno _ado = new ADOEstatusAlumno();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                EstatusAlumno estatus = _ado.Consultar(id);
                lblId.Text = estatus.id.ToString();
                lblClave.Text = estatus.clave.ToString();
                lblNombre.Text = estatus.nombre.ToString();
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

           // int id = Convert.ToInt32(Request.QueryString["id"]);
            EstatusAlumno estatus = new EstatusAlumno();
            estatus.id = Convert.ToInt32(Request.QueryString["id"]);
            _ado.Eliminar(estatus);
            Response.Redirect($"Index.aspx");

        }
    }
}