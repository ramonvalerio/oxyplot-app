using System.Collections.Generic;
using OxyPlotApp.DomainModel.Model;

namespace OxyPlotApp.DomainModel.Interfaces.Repository
{
    public interface IVariavelRepository
    {
        IList<Variavel> GetVariaveis();
    }
}
