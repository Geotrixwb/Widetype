using System;
using System.IO;
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
using Microsoft.Win32;
namespace Widetype
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

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            //Enter file name
            SaveFileDialog fileSave = new SaveFileDialog();
            fileSave.DefaultExt = ".txt";      //default extension 
            fileSave.Filter = "Text documents (.txt)|*.txt|HTML file(.html)|*.html";
            if (fileSave.ShowDialog() == true)
            {

                File.WriteAllText(fileSave.FileName, Input.Text);
            }
        }


        private void MinFontSize(object sender, RoutedEventArgs e)
        {
            Input.FontSize = 15;
        }

        private void MedFontSize(object sender, RoutedEventArgs e)
        {
            Input.FontSize = 18;
        }

        private void MaxFontSize(object sender, RoutedEventArgs e)
        {
            Input.FontSize = 24;
        }

        private void NormalText(object sender, EventArgs e)
        {
            Input.FontStyle = FontStyles.Normal;
        }

        private void ItalicText(object sender, EventArgs e)
        {
            Input.FontStyle = FontStyles.Italic;
        }
         
     }
       
 }
