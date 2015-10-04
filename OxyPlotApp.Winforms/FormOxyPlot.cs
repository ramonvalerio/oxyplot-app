using System;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Extensions;
using OxyPlot.Series;
using OxyPlot.Axes;
using OxyPlotApp.DomainModel.Model;

namespace OxyPlotApp.Winforms
{
    public partial class FormOxyPlot : Form
    {
        public FormOxyPlot()
        {
            InitializeComponent();

            cbLegenda.CheckedChanged += cbLegenda_CheckedChanged;
            btnLines.Click += btnLines_Click;
            btnFunctionSeries.Click += btnFunctionSeries_Click;
            btnLimpar.Click += btnLimpar_Click;
        }

        private void cbLegenda_CheckedChanged(object sender, System.EventArgs e)
        {
            plotView1.Model.IsLegendVisible = ((CheckBox)sender).Checked;
            plotView1.Update();
        }

        private void btnLimpar_Click(object sender, System.EventArgs e)
        {
            plotView1.Model = null;
        }

        private void configurarPlotModel(PlotModel plotModel)
        {
            plotModel.Background = OxyColors.White;
        }

        private void btnLines_Click(object sender, System.EventArgs e)
        {
            plotView1.Focus();

            var xseries = new double[] { 1, 2, 3 };
            var yseries1 = new double[] { 1, 2, 3 };
            var yseries2 = new double[] { 0.5, 1, 1.5 };
            var zseries3 = new double[] { 1, 2, 3, 4, 5 };

            var plotModel = new PlotModel { Title = "LinesSeries with ScatterSeries" };
            plotModel.AddScatterSeries(xseries, yseries1, OxyColors.Red);
            plotModel.AddHighlightedPoint(2.5, 2.5, OxyColors.Blue);
            plotModel.AddLineSeries(xseries, yseries2);
            plotModel.AddLineSeries(xseries, zseries3);

            plotView1.Model = plotModel;
            configurarPlotModel(plotModel);
        }

        private void btnFunctionSeries_Click(object sender, System.EventArgs e)
        {
            plotView1.Focus();

            var xseries = new double[] { 1, 2, 3 };
            var yseries1 = new double[] { 1, 2, 3 };
            var yseries2 = new double[] { 0.5, 1, 1.5 };
            var zseries3 = new double[] { 1, 2, 3, 4, 5 };

            var plotModel = new PlotModel { Title = "BarSeries" };
            plotModel.AddScatterSeries(xseries, yseries1, OxyColors.Red);
            plotModel.AddHighlightedPoint(2.5, 2.5, OxyColors.Blue);
            plotModel.AddLineSeries(xseries, yseries2);
            plotModel.AddLineSeries(xseries, zseries3);

            plotModel.Series.Add(new FunctionSeries(Math.Cos, 0, 10, 0.1, "cos(x)"));

            plotView1.Model = plotModel;
            configurarPlotModel(plotModel);
        }

        private void btnPointSeries_Click(object sender, EventArgs e)
        {
            plotView1.Focus();

            var dateAxis = new DateTimeAxis(AxisPosition.Bottom, "Date", "dd/MM/yyyy") { MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot, IntervalLength = 80 };
            var valueAxis = new LinearAxis(AxisPosition.Left, 0) { MajorGridlineStyle = LineStyle.Solid, MinorGridlineStyle = LineStyle.Dot, Title = "Value" };           

            var plotModel = new PlotModel { Title = "BarSeries" };
            plotModel.LegendTitle = "Legend";
            plotModel.LegendOrientation = LegendOrientation.Horizontal;
            plotModel.LegendPlacement = LegendPlacement.Outside;
            plotModel.LegendPosition = LegendPosition.TopRight;
            plotModel.LegendBackground = OxyColor.FromAColor(200, OxyColors.White);
            plotModel.LegendBorder = OxyColors.Black;
            plotModel.Axes.Add(dateAxis);
            plotModel.Axes.Add(valueAxis);

            plotView1.Model = plotModel;
            configurarPlotModel(plotModel);
        }

        private void btnColumnSeries_Click(object sender, EventArgs e)
        {
            plotView1.Focus();

            var categoria = new Categoria();
            var produtos = categoria.GetProdutos();

            var categoriaAxis = new CategoryAxis();
            categoriaAxis.ItemsSource = produtos;
            categoriaAxis.LabelField = "Nome";

            var linearAxis = new LinearAxis();
            linearAxis.Position = AxisPosition.Left;
            linearAxis.MinimumPadding = 0;
            linearAxis.AbsoluteMinimum = 0;

            var plotModel = new PlotModel { Title = "ColumnSeries" };
            plotModel.Axes.Add(categoriaAxis);
            plotModel.Axes.Add(linearAxis);

            foreach (var produto in produtos)
            {
                var columnSeries = new ColumnSeries();
                columnSeries.Title = produto.Data.ToString("dd/MM/yyyy");
                columnSeries.ItemsSource = produtos;
                columnSeries.ValueField = "Valor";
                plotModel.Series.Add(columnSeries);
            }

            plotView1.Model = plotModel;
            configurarPlotModel(plotModel);
        }

        private void btnLineSeries_Click(object sender, EventArgs e)
        {
            plotView1.Focus();

            var lineSeries = new LineSeries();
            lineSeries.Points.Add(new DataPoint(0, 0));
            lineSeries.Points.Add(new DataPoint(10, 4));
            lineSeries.Points.Add(new DataPoint(30, 2));
            lineSeries.Points.Add(new DataPoint(40, 12));

            var plotModel = new PlotModel { Title = "LineSeries" };
            plotModel.Series.Add(lineSeries);

            plotView1.Model = plotModel;
            configurarPlotModel(plotModel);
        }
    }
}
