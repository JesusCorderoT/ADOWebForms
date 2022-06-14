using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ADOWebForms.Entidades;
using ADOWebForms.ADO;
namespace ADOWebForms.Forms
{
    public partial class Index : System.Web.UI.Page
    {

        





        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack) {

                ADOEstatusAlumno ado = new ADOEstatusAlumno();
                List<EstatusAlumno> estatusAlumnos = ado.Consultar();
                drpAlumnos.DataSource = ado.Consultar();
                drpAlumnos.DataValueField = "id";
                drpAlumnos.DataTextField = "nombre";
                drpAlumnos.DataBind();
                //cbxEstados.DataSource = ado.Consultar();
                //cbxEstados.DisplayMember = "nombre";
                //cbxEstados.ValueMember = "id";
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect($"Create.aspx");
        }

        protected void btnDetalles_Click(object sender, EventArgs e)
        {
            string id = drpAlumnos.SelectedValue;
            Response.Redirect($"Details.aspx?id={id}");
        }

        protected void btnEdita_Click(object sender, EventArgs e)
        {
            string id = drpAlumnos.SelectedValue;
            Response.Redirect($"Edit.aspx?id={id}");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = drpAlumnos.SelectedValue;
            Response.Redirect($"Delete.aspx?id={id}");
        }
    }
}