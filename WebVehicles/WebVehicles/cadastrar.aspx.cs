using System;
using System.Collections.Generic;
using System.Data;
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

            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            var carro = CarregarDadosDb();
            if (Foto.HasFile)
            {

                var caminho = Server.MapPath("images\\carros\\" + Foto.FileName);

                if (System.IO.File.Exists(caminho))
                {
                    System.IO.File.Delete(caminho);
                }

                Foto.SaveAs(caminho);
                carro.Foto = "/images/carros/" + Foto.FileName;
                carro.Inserir();

                LimparCampos();

                LabelMsg.Text = "Inserido com sucesso!";
                Response.Redirect("/listagem.aspx");
            }
            else
            {
                LabelMsg.Text = "A foto é obrigatória";
                LabelMsg.Visible = true;
            }

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