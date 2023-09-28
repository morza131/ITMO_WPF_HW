using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Lesson14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProductName = "Ice-cream",
                ProductPicturePath = "/ProductData/Ice_cream.jpg",
                Price= 100,
                ProductType = ProductType.Food                
            });
            products.Add(new Product()
            {
                ProductName = "Oranges",
                ProductPicturePath = "/ProductData/Oranges.png",
                Price = 219,
                ProductType = ProductType.Food
            });
            products.Add(new Product()
            {
                ProductName = "Dishwasher",
                ProductPicturePath = "/ProductData/Dishwasher.jpg",
                Price = 29990,
                ProductType = ProductType.Appliances
            });
            lstBox.ItemsSource = products;
        }
    }
}
