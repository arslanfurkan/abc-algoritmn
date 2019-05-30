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

namespace ABCalgoritmn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      

        private void btnStart_Click(object sender, EventArgs e)
        {
            int popSize = (int)numKoloniBuyuklugu.Value;
            int iterasyon = (int)numIterasyon.Value;
            int denemeLimit = (int)numDenemeLimit.Value;
            int olasilik = (int)numOlasilik.Value;
            ABCManager manager = new ABCManager(popSize, iterasyon, denemeLimit, olasilik);
            ChartItems items=manager.Run();
            SetChart(items);
        }

        public void SetChart(ChartItems items)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            chart1.Series.Clear();
            try
            {
                Series ort = chart1.Series.Add("Ortalama Uygunluk");
                ort.ChartType = SeriesChartType.Line;
                ort.BorderWidth = 2;
                ort.Color = Color.Red;


                Series min = chart1.Series.Add("En İyi Uygunluk");
                min.ChartType = SeriesChartType.Line;
                min.Color = Color.Blue;
                min.BorderWidth = 2;
            }
            catch (Exception)
            { }

            foreach (var item in items.BestFit)
            {
                this.chart1.Series["En İyi Uygunluk"].Points.Add(item);
            }
            foreach (var item in items.OrtFit)
            {
                this.chart1.Series["Ortalama Uygunluk"].Points.Add(item);
            }
        }



    }

     
}
