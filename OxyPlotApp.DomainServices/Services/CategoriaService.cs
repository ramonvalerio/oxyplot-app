using OxyPlotApp.DomainModel.Interfaces.Repository;

namespace OxyPlotApp.DomainServices.Services
{
    public class CategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }
    }
}
