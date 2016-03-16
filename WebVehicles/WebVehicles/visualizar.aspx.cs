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

            c.Carregar(new CarroFilter { Id = id });
            if (Codigo.Text != "")
            {
                c.Id = Convert.ToInt32(Codigo.Text);
            }

            c.IdCategoria = Convert.ToInt32(Categoria.SelectedValue);
            c.IdMarca = Convert.ToInt32(Marca.SelectedValue);
            c.IdTipo = Convert.ToInt32(Tipo.SelectedValue);

            c.Modelo = Modelo.Text;

            if (Ano.Text != "")
            {
                c.Ano = Convert.ToInt32(Ano.Text);
            }

            if (Preco.Text != "")
            {
                c.Preco = Convert.ToDecimal(Preco.Text);
            }

            c.Proprietario = Proprietario.Text;
            c.Placa = Placa.Text;
            c.Cor = Cor.Text;
            c.Observacoes = Observacoes.Text;

            if (DataAquisicao.Text != "")
            {
                c.DataAquisicao = Convert.ToDateTime(DataAquisicao.Text);
            }

        }
    }
}