using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Wpf;
using System.Net;
using System.IO;
using System.Windows.Threading;
using LiveCharts.Defaults;
using LiveCharts.Configurations;

namespace Portafolio_Escritorio.Views
{
    /// <summary>
    /// Lógica de interacción para UserControlEstadisticaPago.xaml
    /// </summary>
    public partial class UserControlEstadisticaPago : UserControl
    {
        public UserControlEstadisticaPago()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(30);
            timer.Tick += timer_Tick;
            timer.Start();

            PointLabel = chartPoint =>
    string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            DataContext = this;
        }

        public Func<ChartPoint, string> PointLabel { get; set; }

        private void Chart_OnDataClick(object sender, ChartPoint chartpoint)
        {
            var chart = (LiveCharts.Wpf.PieChart)chartpoint.ChartView;

            //clear selected slice.
            foreach (PieSeries series in chart.Series)
                series.PushOut = 0;

            var selectedSeries = (PieSeries)chartpoint.SeriesView;
            selectedSeries.PushOut = 8;
        }

        private string strData;
        private string Segments;

        

            void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                String Str = "https://api.thingspeak.com/channels/";
                String End = "/feeds.json?results=1";
                String Mid = "308573";  //Channel ID Go's Here - Must be set to public

                String All1 = String.Join(Mid, Str, End);


                WebRequest request = WebRequest.Create(All1);
                HttpWebResponse responce = (HttpWebResponse)request.GetResponse();
                Stream datastream = responce.GetResponseStream();
                StreamReader reader = new StreamReader(datastream);
                strData = reader.ReadToEnd();
            }
            catch (Exception)
            {


            }


            try
            {
                int start = strData.LastIndexOf("field1");
                Segments = strData.Substring(start + 9, 4);

            }
            catch (Exception)
            {


            }

            try
            {
                var convertDouble = Convert.ToDouble(Segments);
                GaugeIOT.Value = convertDouble;
            }
            catch (Exception)
            {

            }


        }
    }
}
