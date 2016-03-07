using Dapper;
using System;
using System.Linq;
using WebCadastro;

namespace WebVehicles.classes
{
    public class Carro : clsBanco
    {
        #region Propriedades Públicas

        public int Codigo { get; set; }

        public int IdCategoria { get; set; }

        public int IdMarca { get; set; }

        public int IdTipo { get; set; }

        public string Modelo { get; set; }

        public int Ano { get; set; }

        public decimal Preco { get; set; }

        public string Proprietario { get; set; }

        public string Placa { get; set; }

        public string Cor { get; set; }

        public string Observacoes { get; set; }

        public DateTime DataAquisicao { get; set; }

        public string Foto { get; set; }

        #endregion

        #region Métodos Públicos

        public int Inserir()
        {
            return _conexao.Query<int>("insert into Carros values (@IdCategoria,@IdMarca,@IdTipo,@Modelo,@Ano,@Preco,@Proprietario,@Placa,@Cor,@Observacoes,@DataAquisicao )", this).First();
        }

        #endregion
    }
}