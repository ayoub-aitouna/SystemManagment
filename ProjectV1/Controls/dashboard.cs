using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;

namespace ProjectV1
{
    public partial class dashboard : UserControl
    {
        private Random rand = new Random(0);
        public dashboard()
        {
            InitializeComponent();
        }
        
        private double[] RandomWalk(int points = 5, double start = 100, double mult = 50)
        {
            // return an array of difting random numbers
            double[] values = new double[points];
            values[0] = start;
            for (int i = 1; i < points; i++)
                values[i] = values[i - 1] + (rand.NextDouble() - .5) * mult;
            return values;
        }
        private void dashboard_Load(object sender, EventArgs e)
        {
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            // Define a collection of items to display in the chart 
            SeriesCollection piechartData = new SeriesCollection
    {
        new PieSeries
        {
            Title = "entree",
            PushOut = 5,
            Values = new ChartValues<double> {25},
            DataLabels = true,
            LabelPoint = labelPoint
        },
        new PieSeries
        {
            Title = "sortee",
            Values = new ChartValues<double> {25},
            DataLabels = true,
            LabelPoint = labelPoint
        },
        new PieSeries
        {
            Title = "stock",
            Values = new ChartValues<double> {25},
            DataLabels = true,
            LabelPoint = labelPoint
        }
    };

  
            pieChart1.Series = piechartData;
          
            pieChart1.LegendLocation = LegendLocation.Right;


            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,10),      //First Point of First Line
                        new ObservablePoint(4,7),       //2nd POint
                        new ObservablePoint(5,3),     //------
                        new ObservablePoint(7,6),
                        new ObservablePoint(10,8)
                    },
                    PointGeometrySize = 25
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,2),      //First Point of 2nd Line
                        new ObservablePoint(2,5),       //2nd POint
                        new ObservablePoint(3,6),     //------
                        new ObservablePoint(6,8),
                        new ObservablePoint(10,5)
                    },
                    PointGeometrySize = 15
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,4),      //First Point of 3rd Line
                        new ObservablePoint(5,5),       //2nd POint
                        new ObservablePoint(7,7),     //------
                        new ObservablePoint(9,10),
                        new ObservablePoint(10,9)
                    },
                    PointGeometrySize = 15,
                    LineSmoothness = 1
                    
                }
            };
            cartesianChart2.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,1),      //First Point of First Line
                        new ObservablePoint(4,2),       //2nd POint
                        new ObservablePoint(5,3),     //------
                        new ObservablePoint(7,7),
                        new ObservablePoint(10,82)
                    },
                    PointGeometrySize = 25
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,0),      //First Point of 2nd Line
                        new ObservablePoint(2,0),       //2nd POint
                        new ObservablePoint(3,0),     //------
                        new ObservablePoint(6,8),
                        new ObservablePoint(10,5)
                    },
                    PointGeometrySize = 15
                },
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,7),      //First Point of 3rd Line
                        new ObservablePoint(5,0),       //2nd POint
                        new ObservablePoint(7,0),     //------
                        new ObservablePoint(9,10),
                        new ObservablePoint(10,19)
                    },
                    PointGeometrySize = 15,
                    LineSmoothness = 1

                }
            };


            // generate some random Y data
            int pointCount = 5;
            double[] ys1 = RandomWalk(pointCount);
            double[] ys2 = RandomWalk(pointCount);

            // create series and populate them with data
            var series1 = new LiveCharts.Wpf.ColumnSeries
            {
                Title = "Group A",
                Values = new LiveCharts.ChartValues<double>(ys1)
            };

            var series2 = new LiveCharts.Wpf.ColumnSeries()
            {
                Title = "Group B",
                Values = new LiveCharts.ChartValues<double>(ys2)
            };

            // display the series in the chart control
            chart1.Series.Clear();
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);

        }

      
    }
}
