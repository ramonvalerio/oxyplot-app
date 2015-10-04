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
    }
}
