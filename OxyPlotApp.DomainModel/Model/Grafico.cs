using System.Collections.Generic;

namespace OxyPlotApp.DomainModel.Model
{
    public class Grafico
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public IList<double> SeriesX { get; set; }

        public IList<double> SeriesY { get; set; }
    }
}
