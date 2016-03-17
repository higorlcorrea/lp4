using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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
        protected string Sql { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {

            Sql = @"select c.*, m.Nome as Marca, t.Nome as Tipo from carros c 
                    inner join marca m on m.Id = c.IdMarca
                    inner join tipo t on t.Id = c.IdTipo";

            if (!IsPostBack)
            {
                PopularGridView(true);
            }
        }

        private void PopularGridView(bool substituirDrops)
        {
            GerarBusca();
            var banco = new clsBanco();
            var ds = banco.RetornaDS(Sql);

            if (ds.Tables.Count > 0)
            {
                GridCarros.DataSource = ds;
                GridCarros.DataBind();
            }

            if (substituirDrops)
            {

                ds = banco.RetornaDS("select * from categoria");
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    Categorias.DataSource = ds;
                    Categorias.DataBind();
                }

                ds = banco.RetornaDS("select * from tipo");
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    Tipos.DataSource = ds;
                    Tipos.DataBind();
                }

                ds = banco.RetornaDS("select * from marca");
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    Marcas.DataSource = ds;
                    Marcas.DataBind();
                }

                Categorias.Items.Add(new ListItem { Selected = true, Value = "", Text = "Selecione" });
                Marcas.Items.Add(new ListItem { Selected = true, Value = "", Text = "Selecione" });
                Tipos.Items.Add(new ListItem { Selected = true, Value = "", Text = "Selecione" });
            }
        }

        protected void GridCarros_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridCarros.PageIndex = e.NewPageIndex;
            PopularGridView(false);
        }

        protected void GridCarros_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("/visualizar.aspx?Id=" + GridCarros.Rows[GridCarros.SelectedIndex].Cells[2].Text);
        }

        private void GerarBusca()
        {
            var query = new List<string>();
            if (!string.IsNullOrEmpty(Valor.Text))
            {
                var valor = 0M;
                if (decimal.TryParse(Valor.Text, out valor))
                {
                    var valorBanco = valor.ToString("0.00").Replace(",", ".");
                    if (MaiorQue.Checked)
                    {
                        query.Add("Preco > " + valorBanco);
                    }
                    else
                    {
                        if (MenorQue.Checked)
                        {
                            query.Add("Preco < " + valorBanco);
                        }
                        else
                        {
                            query.Add("Preco = " + valorBanco);
                        }
                    }

                }

            }

            if (Marcas.SelectedValue != "")
            {
                query.Add("IdMarca = " + Marcas.SelectedValue);
            }

            if (Tipos.SelectedValue != "")
            {
                query.Add("IdTipo = " + Tipos.SelectedValue);
            }

            if (Categorias.SelectedValue != "")
            {
                query.Add("IdCategoria = " + Categorias.SelectedValue);
            }

            if (query.Count > 0)
            {
                Sql += " Where " + string.Join(" AND ", query);
            }
        }

        protected void Buscar_Click(object sender, EventArgs e)
        {
            PopularGridView(false);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MaiorQue.Checked = false;
            MenorQue.Checked = false;
            Valor.Text = "";

            DataSet ds = null;

            var banco = new clsBanco();

            ds = banco.RetornaDS("select * from categoria");
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                Categorias.DataSource = ds;
                Categorias.DataBind();
            }

            ds = banco.RetornaDS("select * from tipo");
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                Tipos.DataSource = ds;
                Tipos.DataBind();
            }

            ds = banco.RetornaDS("select * from marca");
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                Marcas.DataSource = ds;
                Marcas.DataBind();
            }

            Categorias.Items.Add(new ListItem { Selected = true, Value = "", Text = "Selecione" });
            Marcas.Items.Add(new ListItem { Selected = true, Value = "", Text = "Selecione" });
            Tipos.Items.Add(new ListItem { Selected = true, Value = "", Text = "Selecione" });
        }
    }
}