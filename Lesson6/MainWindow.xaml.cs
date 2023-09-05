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

namespace Lesson6
{
    public enum Precipitation
    {
        Sunny,
        Cloudy,
        Rainy,
        Snowy
    }
    public class WeaterControl:DependencyObject
    {
        private Precipitation precipitation;
        public static readonly DependencyProperty TempratureProperty;        
        public string WindowDirection { get; set; }
        public int WindSpeed { get; set; }
        
        public WeaterControl(string windowDirection, int windSpeed, Precipitation precipitation)
        { 
            WindowDirection= windowDirection;
            WindSpeed= windSpeed;
            this.precipitation = precipitation;
        }
        public double Temprature {
            get => (double) GetValue(TempratureProperty);
            set => SetValue(TempratureProperty, value); 
        }
        static WeaterControl()
        {
            TempratureProperty = DependencyProperty.Register(
                nameof(Temprature),
                typeof(double),
                typeof(WeaterControl),
                new FrameworkPropertyMetadata(
                    0,
                    FrameworkPropertyMetadataOptions.AffectsMeasure |
                    FrameworkPropertyMetadataOptions.AffectsRender,
                    null,
                    new CoerceValueCallback(CoerceTemprature)),
                    new ValidateValueCallback(ValidateTemprature)
                );
        }

        private static bool ValidateTemprature(object value)
        {
            double t = (double)value;
            if (t >= -50 && t <= 50)
                return true;
            else
                return false;
        }

        private static object CoerceTemprature(DependencyObject d, object baseValue)
        {
            double t = (double)baseValue;
            if (t >= -273.3 && t <= 100)
                return t;
            else
                return 0;
        }
    }
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
