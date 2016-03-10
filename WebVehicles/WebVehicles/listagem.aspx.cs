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
    public partial class cadastrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var banco = new clsBanco();
                Categoria.DataSource = banco.RetornaDS("select * from categoria");
                Categoria.DataBind();
                Tipo.DataSource = banco.RetornaDS("select * from tipo");
                Tipo.DataBind();
                Marca.DataSource = banco.RetornaDS("select * from marca");
                Marca.DataBind();

                Categoria.Items.Add(new ListItem { Selected = true, Value = "", Text = "Selecione" });
                Marca.Items.Add(new ListItem { Selected = true, Value = "", Text = "Selecione" });
                Tipo.Items.Add(new ListItem { Selected = true, Value = "", Text = "Selecione" });

            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            var carro = CarregarDadosDb();

            carro.Inserir();
            LabelMsg.Text = "Inserido com sucesso!";

            LimparCampos();
        }

        #region Métodos Privados

        private void LimparCampos()
        {
            Codigo.Text = "";
            Categoria.SelectedValue = "";
            Marca.SelectedValue = "";
            Tipo.SelectedValue = "";
            Modelo.Text = "";
            Ano.Text = "";
            Preco.Text = "";
            Proprietario.Text = "";
            Placa.Text = "";
            Cor.Text = "";
            Observacoes.Text = "";
            DataAquisicao.Text = "";
            Foto = new FileUpload();
        }

        private Carro CarregarDadosDb()
        {
            var c = new Carro();

            if (Codigo.Text != "")
            {
                c.Codigo = Convert.ToInt32(Codigo.Text);
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

            return c;
        }

        #endregion

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            LabelMsg.Text = "";
            LimparCampos();
        }
    }
}