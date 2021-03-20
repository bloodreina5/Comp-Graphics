using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Filters_Andrich

{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        public void ShowIntensityHistogram(int[] histogram)
        {
            ChartArea ca = new ChartArea();
            ca.AxisX.Minimum = 0;
            ca.AxisX.Maximum = 256;
            ca.AxisY.Minimum = 0;
            ca.AxisY.Maximum = histogram.Max();
            ca.AxisY.Interval = 500;
            mHistogramChart.ChartAreas.Add(ca);

            mHistogramChart.Series.Add("Intesivity");
            mHistogramChart.Series["Intesivity"].XValueType = ChartValueType.Int32;
            mHistogramChart.Series["Intesivity"].ChartType = SeriesChartType.Column;
            mHistogramChart.Series["Intesivity"]["PointWidth"] = "1";
            mHistogramChart.Series["Intesivity"].Points.DataBindY(histogram);
            Show();
        }

        public void ShowRGBHistogram(int[][] histogram)
        {
            ChartArea ca = new ChartArea();
            ca.AxisX.Minimum = 0;
            ca.AxisX.Maximum = 256;
            ca.AxisY.Minimum = 0;
            ca.AxisY.Maximum = Math.Max(histogram[0].Max(), Math.Max(histogram[1].Max(), histogram[2].Max()));
            ca.AxisY.Interval = 1000;
            mHistogramChart.ChartAreas.Add(ca);

            mHistogramChart.Series.Add("Red");
            mHistogramChart.Series["Red"].XValueType = ChartValueType.Int32;
            mHistogramChart.Series["Red"].ChartType = SeriesChartType.Column;
            mHistogramChart.Series["Red"].Color = Color.FromArgb(85, Color.Red);
            mHistogramChart.Series["Red"].Points.DataBindY(histogram[0]);
            mHistogramChart.Series["Red"]["PointWidth"] = "1";

            mHistogramChart.Series.Add("Green");
            mHistogramChart.Series["Green"].XValueType = ChartValueType.Int32;
            mHistogramChart.Series["Green"].ChartType = SeriesChartType.Column;
            mHistogramChart.Series["Green"].Color = Color.FromArgb(85, Color.Green);
            mHistogramChart.Series["Green"].Points.DataBindY(histogram[1]);
            mHistogramChart.Series["Green"].MarkerSize = 1;
            mHistogramChart.Series["Green"]["PointWidth"] = "1";

            mHistogramChart.Series.Add("Blue");
            mHistogramChart.Series["Blue"].XValueType = ChartValueType.Int32;
            mHistogramChart.Series["Blue"].ChartType = SeriesChartType.Column;
            mHistogramChart.Series["Blue"].Color = Color.FromArgb(85, Color.DarkBlue);
            mHistogramChart.Series["Blue"].Points.DataBindY(histogram[2]);
            mHistogramChart.Series["Blue"]["PointWidth"] = "1";
            Show();
        }
    }
    

}
    

