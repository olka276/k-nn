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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            float stringTofloat(string x)
            {
                float result;
                result = float.Parse(x);
                return result;
            }

            
            string line;
            List<string> pattern = new List<string>();
            StreamReader read = new StreamReader("iris.txt");
            StringBuilder sb = new StringBuilder();

            while ((line = read.ReadLine()) != null)
                {
                    pattern.Add(line);
                }

            foreach (string item in pattern)
                {
                    sb.Append(item).Append("\n");
                }

            line = sb.ToString();


            string temp = "";
            string control = "";
            List<float> attr = new List<float>();
            List<Element> source = new List<Element>();

            for (int i = 0; i < line.Length; i++)
            {
                
                if (line[i].Equals("\n"))
                {
                    Element element = new Element(attr);
                    source.Add(element);
                    attr.Clear();
                }

                else
                {
                    if (line[i].Equals(" "))
                    {
                        control += temp;
                        attr.Add(stringTofloat(temp));
                        temp = "";
                    }

                    else
                    {
                      

                        if (line[i].Equals("."))
                        {
                            temp += ",";
                        }
                        temp += line[i];
                    }
                }
               
            }
            Samples wzorzec = new Samples(source);
            string value="";
            foreach (Element elem in wzorzec.Objects)
            {
                foreach (float aaa in elem.Attributes)
                {
                    value += string.Join(" ", elem.Attributes.ToArray()) + "\n";
                }
            }

            nums.Content = control;
        }
    }
}
