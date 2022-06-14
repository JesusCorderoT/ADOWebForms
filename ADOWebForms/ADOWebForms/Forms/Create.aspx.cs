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
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            ADOEstatusAlumno ado = new ADOEstatusAlumno();
            EstatusAlumno ac = new EstatusAlumno();

            string nombre = txtNombre.Text;
            string clave = txtClave.Text;

            ac.clave = clave;
            ac.nombre = nombre;
            ado.Agregar(ac);
            Response.Redirect($"Index.aspx");
        }
    }
}