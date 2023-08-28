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

namespace Lesson3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FontBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            string font = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
            {
                textBox.FontFamily = new FontFamily(font);
            }
        }

        private void FontSizeBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            double fontSize = Convert.ToDouble(((sender as ComboBox).SelectedItem as TextBlock).Text);
            if (textBox != null)
            {
                textBox.FontSize = fontSize;
            }
        }
        private bool isBoilButtonClicked = false;
        private bool isItalicButtonClicked = false;
        private bool isUnderlineButtonClicked = false;

        private void BoilButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (isBoilButtonClicked)
            {
                isBoilButtonClicked = false;
                BoilButton.Background = Brushes.AliceBlue;
                if (textBox != null)
                {
                    textBox.FontWeight = FontWeights.Normal;
                }
            }
            else
            {
                isBoilButtonClicked = true;
                BoilButton.Background = Brushes.Beige;
                if (textBox != null)
                {
                    textBox.FontWeight = FontWeights.Bold;
                }

            }

        }

        private void ItalicButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (isItalicButtonClicked)
            {
                isItalicButtonClicked = false;
                ItalicButton.Background = Brushes.AliceBlue;
                if (textBox != null)
                {
                    textBox.FontStyle = FontStyles.Normal;
                }
            }
            else
            {
                isItalicButtonClicked = true;
                ItalicButton.Background = Brushes.Beige;
                if (textBox != null)
                {
                    textBox.FontStyle = FontStyles.Italic;
                }
            }
        }

        private void UnderlineButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (isUnderlineButtonClicked)
            {
                isUnderlineButtonClicked = false;
                UnderlineButton.Background = Brushes.AliceBlue;
                if (textBox != null)
                {
                    textBox.TextDecorations = null;
                }
            }
            else
            {
                isUnderlineButtonClicked = true;
                UnderlineButton.Background = Brushes.Beige;
                if (textBox != null)
                {
                    textBox.TextDecorations = TextDecorations.Underline;
                }
            }
        }

        private void RedButton_Checked(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground= Brushes.Red;
            }
        }

        private void BlackButton_Checked(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Black;
            }
        }
    }
}
