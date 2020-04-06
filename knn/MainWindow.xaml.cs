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
using System.IO;

namespace knn
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void KValue_TextChanged(object sender, TextChangedEventArgs e)
        {

        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

            Samples sampel = Samples.GetSamples("iris.txt");
            string newObject = newValues.Text+' ';

            string temp = "";

            List<double> attr = new List<double>();
            attr = Samples.fromStringToList(newObject);
   
            Element myObject = new Element(attr);

            

            decision.Content = sampel.Classify(myObject, Convert.ToDouble(kValue.Text));
        }

    }
}
