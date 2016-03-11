using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebCadastro;
using WebVehicles.classes;

namespace WebVehicles
{
    public partial class listagem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PopularGridView();
            }
        }

        private void PopularGridView()
        {
            var banco = new clsBanco();
            var ds = banco.RetornaDS(@"
                    select c.*, 1 as Marca from carros c 
                        inner join marca m on m.Id = c.IdMarca
                ");

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                GridCarros.DataSource = ds;
                GridCarros.DataBind();
            }
        }

        protected void GridCarros_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridCarros.PageIndex = e.NewPageIndex;
            PopularGridView();
        }
    }
}