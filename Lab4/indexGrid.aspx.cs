using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaDatos.Entidades;
using System.Drawing;



namespace Lab4
{
    public partial class indexGrid : System.Web.UI.Page
    {
        GestionBD objFactura;
        List<Facturas> auxListado;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cargarDatos();
            }
        }

        void cargarDatos()
        {
            objFactura = new GestionBD();
            auxListado = objFactura.listaFacturas();
            GridFactura.DataSource = auxListado;
            GridFactura.DataBind();
        }


        protected void GridFactura_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(GridFactura, "Select$" + e.Row.RowIndex);
            }

        }

        protected void GridFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow fila in GridFactura.Rows)
            {

                if (fila.RowIndex == GridFactura.SelectedIndex)
                {
                    txtidFactura.Text = fila.Cells[0].Text; //obtengo el codigo de herramienta
                    txtnumLinea.Text = fila.Cells[1].Text;
                    txtcodProducto.Text = fila.Cells[2].Text;
                    txtdetProducto.Text = fila.Cells[3].Text;
                    txtcantProducto.Text = fila.Cells[4].Text;
                    txtcostUnitario.Text = fila.Cells[5].Text;
                    txttotalLinea.Text = fila.Cells[6].Text;

                    fila.BackColor = ColorTranslator.FromHtml("#A1DCF2");
                }
                else
                {
                    fila.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                }

            }

            cargarDatos();

        }


    }
}