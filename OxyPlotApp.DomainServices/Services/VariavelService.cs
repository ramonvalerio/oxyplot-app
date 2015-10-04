using System;
using System.Collections.Generic;
using OxyPlotApp.DomainModel.Interfaces.Repository;
using OxyPlotApp.DomainModel.Interfaces.Service;
using OxyPlotApp.DomainModel.Model;

namespace OxyPlotApp.DomainServices.Services
{
    public class VariavelService : IVariavelService
    {
        private IVariavelRepository _variavelRepository;

        public VariavelService(IVariavelRepository variavelRepository)
        {
            _variavelRepository = variavelRepository;
        }

        public IList<Variavel> GetVariaveis()
        {
            return _variavelRepository.GetVariaveis();
        }
    }
}
