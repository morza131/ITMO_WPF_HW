using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Lesson9
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
        #region event handlers
        private void FontBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            string font = ((sender as ComboBox).SelectedItem as string);
            if (textBox != null)
            {
                textBox.FontFamily = new FontFamily(font);
            }
        }

        private void FontSizeBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            double fontSize = Convert.ToDouble(((sender as ComboBox).SelectedItem as string));
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
                textBox.Foreground = Brushes.Red;
            }
        }

        private void BlackButton_Checked(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Black;
            }
        }
        #endregion

        #region Commands
        private void OpenExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                textBox.Text = File.ReadAllText(openFileDialog.FileName);
            }

        }

        private void SaveExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, textBox.Text);
            }
        }

        private void ExitExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        //private void FontBox_SelectionChangedExecuted(object sender, ExecutedRoutedEventArgs e)
        //{

        //    string font = ((sender as ComboBox).SelectedItem as TextBlock).Text;
        //    if (textBox != null)
        //    {
        //        textBox.FontFamily = new FontFamily(font);
        //    }
        //}


        #endregion

        private void lightModeButton_Checked(object sender, RoutedEventArgs e)
        {
            Uri uriStyle = new Uri("LightMode.xaml", UriKind.Relative);
            Uri uriFonts = new Uri("DictionaryFonts.xaml", UriKind.Relative);
            ResourceDictionary resourceStyle = Application.LoadComponent(uriStyle) as ResourceDictionary;
            ResourceDictionary resourceFonts = Application.LoadComponent(uriFonts) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceStyle);
            Application.Current.Resources.MergedDictionaries.Add(resourceFonts);
        }

        private void darkModeButton_Checked(object sender, RoutedEventArgs e)
        {
            Uri uriStyle = new Uri("DarkMode.xaml", UriKind.Relative);
            Uri uriFonts = new Uri("DictionaryFonts.xaml", UriKind.Relative);
            ResourceDictionary resourceStyle = Application.LoadComponent(uriStyle) as ResourceDictionary;
            ResourceDictionary resourceFonts = Application.LoadComponent(uriFonts) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceStyle);
            Application.Current.Resources.MergedDictionaries.Add(resourceFonts);
        }
    }
}

