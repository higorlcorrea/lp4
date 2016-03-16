using Dapper;
using System;
using System.Data;
using System.Linq;
using System.Data.Entity;
using WebCadastro;
using System.Collections.Generic;

namespace WebVehicles.classes
{
    public class Carro : clsBanco
    {
        #region Propriedades Públicas

        public int Id { get; set; }

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
            return _conexao.Query<int>("insert into Carros values (@IdCategoria,@IdMarca,@IdTipo,@Modelo,@Ano,@Preco,@Proprietario,@Placa,@Cor,@Observacoes,@DataAquisicao,@Foto)", this).FirstOrDefault();
        }

        public Carro Carregar(int id)
        {
            var lista = _conexao.Query<Carro>("select * from carros where Id = @Id;", new { Id = id }).ToList();

            return lista.First();
        }

        #endregion


    }
}