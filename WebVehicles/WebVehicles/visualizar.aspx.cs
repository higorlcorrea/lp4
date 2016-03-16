using System;
using System.Data;
using System.Web.UI.WebControls;
using WebCadastro;
using WebVehicles.classes;

namespace WebVehicles
{
    public partial class visualizar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var valido = false;

            if (Request["Id"] != null)
            {

                var banco = new clsBanco();
                DataSet ds = null;

                ds = banco.RetornaDS("select * from categoria");
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    Categoria.DataSource = ds;
                    Categoria.DataBind();
                }

                ds = banco.RetornaDS("select * from tipo");
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    Tipo.DataSource = ds;
                    Tipo.DataBind();
                }

                ds = banco.RetornaDS("select * from marca");
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    Marca.DataSource = ds;
                    Marca.DataBind();
                }

                Categoria.Items.Add(new ListItem { Selected = true, Value = "", Text = "Selecione" });
                Marca.Items.Add(new ListItem { Selected = true, Value = "", Text = "Selecione" });
                Tipo.Items.Add(new ListItem { Selected = true, Value = "", Text = "Selecione" });

                var id = 0;

                if (int.TryParse(Request["Id"].ToString(), out id))
                {
                    valido = true;
                    CarregarDados(id);
                }
            }

            if (!valido)
            {
                Response.Redirect("listagem.aspx");
            }
        }

        private void CarregarDados(int id)
        {
            var c = new Carro();
            try
            {
                c = c.Carregar(id);

                Codigo.Text = c.Id.ToString();

                Categoria.SelectedValue = c.IdCategoria.ToString();
                Marca.SelectedValue = c.IdMarca.ToString();
                Tipo.SelectedValue = c.IdTipo.ToString();

                Modelo.Text = c.Modelo;

                Ano.Text = c.Ano.ToString();

                Preco.Text = "R$ " + c.Preco.ToString("#,0.00");

                Proprietario.Text = c.Proprietario;

                Placa.Text = c.Placa;


                Cor.Text = c.Cor;

                Observacoes.Text = c.Observacoes;

                DataAquisicao.Text = c.DataAquisicao.ToString("dd/MM/yyyy");
                Image1.ImageUrl = "~/" + c.Foto;
            }
            catch (Exception e)
            {
                Response.Redirect("/listagem.aspx");
            }
        }

    }
}