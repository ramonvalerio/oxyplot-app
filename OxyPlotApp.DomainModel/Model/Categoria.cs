using System;
using System.Collections.Generic;

namespace OxyPlotApp.DomainModel.Model
{
    public class Categoria
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public IList<Variavel> Variaveis { get; set; }

        public Categoria()
        {
            Variaveis = new List<Variavel>();
        }
    }
}
