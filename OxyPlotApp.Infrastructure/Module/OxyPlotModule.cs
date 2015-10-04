using Ninject.Modules;
using OxyPlotApp.DomainModel.Interfaces.Repository;
using OxyPlotApp.DomainModel.Interfaces.Service;
using OxyPlotApp.DomainServices.Services;
using OxyPlotApp.Infrastructure.Repository;

namespace OxyPlotApp.Infrastructure.Module
{
    public class OxyPlotModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICategoriaService>().To<CategoriaService>();
            Bind<ICategoriaRepository>().To<CategoriaRepository>();
        }
    }
}
