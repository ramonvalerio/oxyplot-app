using OxyPlotApp.DomainModel.Interfaces.Repository;
using OxyPlotApp.DomainModel.Model;
using System.Collections.Generic;
using System;

namespace OxyPlotApp.Infrastructure.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        public IList<Categoria> GetCategorias()
        {
            throw new NotImplementedException();
        }

        public IList<Variavel> GetProdutos()
        {
            var Apple = new Variavel { Id = Faker.NumberFaker.Number(), Nome = Faker.NameFaker.Name(), Valor = Faker.NumberFaker.Number(), Data = Faker.DateTimeFaker.DateTimeBetweenYears(1994) };
            var Pears = new Variavel { Id = Faker.NumberFaker.Number(), Nome = Faker.NameFaker.Name(), Valor = Faker.NumberFaker.Number(), Data = Faker.DateTimeFaker.DateTimeBetweenYears(2008) };
            var Bananas = new Variavel { Id = Faker.NumberFaker.Number(), Nome = Faker.NameFaker.Name(), Valor = Faker.NumberFaker.Number(), Data = Faker.DateTimeFaker.DateTimeBetweenYears(2014) };

            var produtos = new List<Variavel>();

            produtos.Add(Apple);
            produtos.Add(Pears);
            produtos.Add(Bananas);

            return produtos;
        }
    }
}
