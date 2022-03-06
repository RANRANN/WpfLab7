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

namespace WpfLab7
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
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textbox != null)
            {
                textbox.FontFamily = new FontFamily(fontName);
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (textbox != null)
            {
                double fontSize = Convert.ToDouble(((sender as ComboBox).SelectedItem as TextBlock).Text);
                textbox.FontSize = fontSize;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textbox.FontWeight == FontWeights.Normal)
            {
                textbox.FontWeight = FontWeights.UltraBold;
            }
            else
            {
                textbox.FontWeight = FontWeights.Normal;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (textbox.FontStyle == FontStyles.Normal)
            {
                textbox.FontStyle = FontStyles.Italic;
            }
            else
            {
                textbox.FontStyle = FontStyles.Normal;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (textbox.TextDecorations == null)
            {
                textbox.TextDecorations = TextDecorations.Underline;
            }
            else
            {
                textbox.TextDecorations = null;
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (textbox != null)
            {
                textbox.Foreground = Brushes.Red;
            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (textbox != null)
            {
                textbox.Foreground = Brushes.Black;
            }
        }

        private void OpenExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы(*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                textbox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void SaveExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, textbox.Text);
            }
        }

        private void ExitExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void HelpExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Справочник готов");
        }

        private void ContactsExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Домашняя страницы");
        }
    }
}
