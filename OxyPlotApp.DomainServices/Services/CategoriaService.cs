using System.Collections.Generic;
using OxyPlotApp.DomainModel.Interfaces.Repository;
using OxyPlotApp.DomainModel.Interfaces.Service;
using OxyPlotApp.DomainModel.Model;

namespace OxyPlotApp.DomainServices.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public IList<Categoria> GetCategorias()
        {
            return _categoriaRepository.GetCategorias();
        }
    }
}
