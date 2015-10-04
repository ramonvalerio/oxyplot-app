using System.Collections.Generic;
using OxyPlotApp.DomainModel.Model;

namespace OxyPlotApp.DomainModel.Interfaces.Service
{
    public interface IVariavelService
    {
        IList<Variavel> GetVariaveis();
    }
}
