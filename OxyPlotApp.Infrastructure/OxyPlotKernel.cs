using OxyPlotApp.Infrastructure.Module;
using Ninject;

namespace OxyPlotApp.Infrastructure
{
    public class OxyPlotKernel
    {
        private IKernel _kernel { get; set; }

        public OxyPlotKernel()
        {
            _kernel = new StandardKernel(new OxyPlotModule());
        }

        public T Get<T>()
        {
            return _kernel.Get<T>();
        }
    }
}
