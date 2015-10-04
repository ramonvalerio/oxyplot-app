using System;
using System.Collections.Generic;

namespace OxyPlotApp.DomainModel.Model
{
    public class Categoria
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public IList<Variavel> Produtos { get; private set; }

        public Categoria()
        {
            
            Produtos = new List<Variavel>();
        }

        public IList<Categoria> GetCategorias()
        {
            var categorias = new List<Categoria>();

            for (int i = 0; i < 5; i++)
            {
                var categoria = new Categoria();
                categoria.Id = Faker.NumberFaker.Number();
                categoria.Nome = Faker.CompanyFaker.Name();
                categorias.Add(categoria);
            }

            return categorias;
        }

        public IList<Variavel> GetProdutos()
        {
            var Apple = new Variavel { Id = Faker.NumberFaker.Number(), Nome = Faker.NameFaker.Name(), Valor = Faker.NumberFaker.Number(), Data = Faker.DateTimeFaker.DateTimeBetweenYears(1994) };
            var Pears = new Variavel { Id = Faker.NumberFaker.Number(), Nome = Faker.NameFaker.Name(), Valor = Faker.NumberFaker.Number(), Data = Faker.DateTimeFaker.DateTimeBetweenYears(2008) };
            var Bananas = new Variavel { Id = Faker.NumberFaker.Number(), Nome = Faker.NameFaker.Name(), Valor = Faker.NumberFaker.Number(), Data = Faker.DateTimeFaker.DateTimeBetweenYears(2014) };

            Produtos.Add(Apple);
            Produtos.Add(Pears);
            Produtos.Add(Bananas);

            return Produtos;
        }
    }
}
