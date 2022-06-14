using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ADOWebForms.ADO;
using ADOWebForms.Entidades;

namespace ADOWebForms.Forms
{
    public partial class Edit : System.Web.UI.Page
    {
        ADOEstatusAlumno _ado = new ADOEstatusAlumno();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                EstatusAlumno estatus = _ado.Consultar(id);

                txtId.Text = estatus.id.ToString();
                txtClave.Text = estatus.clave.ToString();
                txtNombre.Text = estatus.nombre.ToString();

            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {

            EstatusAlumno ac = new EstatusAlumno();

            int id = Convert.ToInt32(txtId.Text);
            string nombre = txtNombre.Text;
            string clave = txtClave.Text;

            ac.clave = clave;
            ac.nombre = nombre;
            ac.id = id;

            _ado.Actualizar(ac);
            Response.Redirect($"Index.aspx");            
        }
    }
}