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
                var banco = new clsBanco();
                GridCarros.DataSource = banco.RetornaDS(@"
                    select c.*, m.Nome as Marca from carros c 
                        inner join marca m on m.Id = c.IdMarca
                ");
                GridCarros.DataBind();
            }
        }
    }
}