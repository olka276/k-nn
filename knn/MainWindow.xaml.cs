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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            allNums.Content += newValue.Text + " ";
            newValue.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string k = kValue.Text;
            string metryka = (metric.SelectedItem as ComboBoxItem).Content.ToString();
            alert.Content = "";
            decision.Content = "";
            Samples sampel = Samples.GetSamples("iris.txt");
            string newObject = allNums.Content.ToString();

            if (String.IsNullOrEmpty(k))
            {
                alert.Content = "Podaj liczbę k";
            }

            else {
                double klasyf = Convert.ToDouble(kValue.Text);
                if (String.IsNullOrEmpty(newObject.Trim()))
                {
                    alert.Content = "Nie podano atrybutów!";
                    decision.Content = "";
                }

                else
                {
                    double countAttributes = 0;
                    List<double> attr = new List<double>();
                    attr = Samples.fromStringToList(newObject);

                    foreach (Element elem in sampel.Objects)
                    {
                        countAttributes = elem.Attributes.Count;
                    }

                    if (attr.Count != countAttributes)
                    {
                        alert.Content = "Podano nieprawidłową ilość atrybutów! Podaj " + countAttributes + " atrybutów!";
                    }

                    else
                    {

                        Element myObject = new Element(attr);
                        double? sol = sampel.Classify(myObject, klasyf, metryka);
                        decision.Content = sol;
                    }

                }
            }
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {

            Samples sampel = Samples.GetSamples("iris.txt");
            double? result = 0;
            double accuracyGood = 0;
            string metryka = (metric.SelectedItem as ComboBoxItem).Content.ToString();
            double accuracyBad = 0;
            foreach (Element elem in sampel.Objects)

            {
                result = sampel.Classify(elem, elem.Attributes.Count, metryka);
                if (result==elem.Decision)
                {
                    accuracyGood++;
                }
                else
                {
                    accuracyBad++;
                }
            }

            double accuracyWhole = 0;

            accuracyWhole = accuracyGood / (accuracyGood + accuracyBad)*100;

           // accuracy.Content = metryka;
            accuracy.Content = "Trafność metryki: " + Math.Round(accuracyWhole,2).ToString()+ "%";
        }

        
    }
}
