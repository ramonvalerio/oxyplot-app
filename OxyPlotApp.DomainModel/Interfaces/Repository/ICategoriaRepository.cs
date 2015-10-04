using System.Collections.Generic;
using OxyPlotApp.DomainModel.Model;

namespace OxyPlotApp.DomainModel.Interfaces.Repository
{
    public interface ICategoriaRepository
    {
        IList<Categoria> GetCategorias();
        IList<Variavel> GetProdutos();
    }
}
