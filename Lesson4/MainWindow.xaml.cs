using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using System.Xml.Linq;

namespace Lesson4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void dollarCalculate_Click(object sender, RoutedEventArgs e)
        {
            dollarResult.Text = (Convert.ToDouble(dollarExRate.Text)*Convert.ToDouble(dollarValue.Text)).ToString();
            /*WebClient client = new WebClient();
            var xml = client.DownloadString("https://www.cbr-xml-daily.ru/daily.xml");
            XDocument xdoc = XDocument.Parse(xml);
            var el = xdoc.Element("ValCurs").Elements("Valute");
            string dollar = el.Where(x => x.Attribute("ID").Value == "R01235").Select(x => x.Element("Value").Value).FirstOrDefault();
            string eur = el.Where(x => x.Attribute("ID").Value == "R01239").Select(x => x.Element("Value").Value).FirstOrDefault();
            MessageBox.Show($"Евро: {eur} Доллар: {dollar}");*/
        }

        private void euroCalculate_Click(object sender, RoutedEventArgs e)
        {
            euroResult.Text = (Convert.ToDouble(euroExRate.Text) * Convert.ToDouble(euroValue.Text)).ToString();
        }

        private void hryvniaCalculate_Click(object sender, RoutedEventArgs e)
        {
            hryvniaResult.Text = (Convert.ToDouble(hryvniaExRate.Text) * Convert.ToDouble(hryvniaValue.Text)).ToString();
        }

        private void dramaCalculate_Click(object sender, RoutedEventArgs e)
        {
            dramaResult.Text = (Convert.ToDouble(dramaExRate.Text) * Convert.ToDouble(dramaValue.Text)).ToString();
        }

     

        private void meters_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (meters.Text != "")
                {
                    double _meters = Convert.ToDouble(meters.Text);
                    foots.Text = (_meters * 0.3048).ToString();
                    arshins.Text = (_meters * 0.7112).ToString();
                    miles.Text = (_meters / 1609.34).ToString();
                }
            }
        }

        private void foots_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (foots.Text != "")
                {
                    double _foots = Convert.ToDouble(foots.Text);
                    meters.Text = (_foots * 3.28084).ToString();
                    arshins.Text = (_foots * 2.33333).ToString();
                    miles.Text = (_foots / 5280).ToString();
                }
            }
        }

        private void arshins_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.Key == Key.Enter)
                {
                    if (arshins.Text != "")
                    {
                        double _arshins = Convert.ToDouble(arshins.Text);
                        foots.Text = (_arshins * 0.42857).ToString();
                        meters.Text = (_arshins * 1.406).ToString();
                        miles.Text = (_arshins / 2262.857).ToString();
                    }
                }
        }
        private void miles_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.Key == Key.Enter)
                {
                    if (miles.Text != "")
                    {
                        double _miles = Convert.ToDouble(miles.Text);
                        foots.Text = (_miles / 0.0001893939393939).ToString();
                        arshins.Text = (_miles / 0.0004419191919192).ToString();
                        meters.Text = (_miles / 0.0006213711922372).ToString();
                    }
                }
        }
    }
}
