using System;
using System.Collections.Generic;
using OxyPlotApp.DomainModel.Interfaces.Repository;
using OxyPlotApp.DomainModel.Model;

namespace OxyPlotApp.Infrastructure.Repository
{
    public class VariavelRepository : IVariavelRepository
    {
        public IList<Variavel> GetVariaveis()
        {
            var variaveis = new List<Variavel>();

            var Apple = new Variavel { Id = Faker.NumberFaker.Number(), Nome = Faker.NameFaker.Name(), Valor = Faker.NumberFaker.Number(), Data = Faker.DateTimeFaker.DateTimeBetweenYears(1994) };
            var Pears = new Variavel { Id = Faker.NumberFaker.Number(), Nome = Faker.NameFaker.Name(), Valor = Faker.NumberFaker.Number(), Data = Faker.DateTimeFaker.DateTimeBetweenYears(2008) };
            var Bananas = new Variavel { Id = Faker.NumberFaker.Number(), Nome = Faker.NameFaker.Name(), Valor = Faker.NumberFaker.Number(), Data = Faker.DateTimeFaker.DateTimeBetweenYears(2014) };

            variaveis.Add(Apple);
            variaveis.Add(Pears);
            variaveis.Add(Bananas);

            return variaveis;
        }
    }
}
