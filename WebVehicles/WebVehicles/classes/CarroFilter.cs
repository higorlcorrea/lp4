using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebVehicles.classes
{
    public class CarroFilter
    {
        public int? Id { get; set; }

        public int? IdCategoria { get; set; }

        public int? IdMarca { get; set; }

        public int? IdTipo { get; set; }

        public string Modelo { get; set; }

        public int? Ano { get; set; }

        public decimal? Preco { get; set; }

        public string Proprietario { get; set; }

        public string Placa { get; set; }

        public string Cor { get; set; }

        public DateTime? DataAquisicao { get; set; }

    }
}