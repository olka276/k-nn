using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace knn
{
    class Samples
    {
        public List<Element> Objects;

        public Samples (List<Element> objects)
        {
            this.Objects = objects;
        }

        public static Samples GetSamples(string path)
        {
            string text;
            double num;

            List<double> attr = new List<double>();
            List<string> pattern = new List<string>();

            List<Element> elementy = new List<Element>();

            StreamReader read = new StreamReader(path);
            StringBuilder sb = new StringBuilder();

            while ((text = read.ReadLine()) != null)
            {
                pattern.Add(text);
            }

            foreach (string item in pattern)
            {
                sb.Append(item).Append("\n");
            }

            text = sb.ToString();

            string temp = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '\n')
                {
                    temp = temp.Replace('.', ',');
                    temp = temp.Trim();
                    num = Convert.ToDouble(temp);
                    
                    elementy.Add(new Element(new List<double>(attr), num));
                    attr.Clear();
                    temp = "";
                }

                if (text[i] == '\t')
                {


                    temp = temp.Replace('.', ',');
                    temp = temp.Trim();
                    num = Convert.ToDouble(temp);
                    attr.Add(num);
                    temp = "";
                }
                else
                {
                    temp += text[i];
                }

            }

            return new Samples(elementy);

        }

        public static List<double> fromStringToList(string newObject)
        {
            string temp = "";
            double num = 0;
            List<double> attr = new List<double>();

            for (int i = 0; i < newObject.Length; i++)
            {

                if (newObject[i].Equals('\n'))
                {
                    temp = temp.Replace('.', ',');
                    temp = temp.Trim();
                    num = Convert.ToDouble(temp);
                    attr.Add(num);
                    temp = "";
                }

                if (newObject[i].Equals(' '))
                {
                    temp = temp.Replace('.', ',');
                    temp = temp.Trim();
                    num = Convert.ToDouble(temp);
                    attr.Add(num);temp = "";
                }
                else
                {
                    temp += newObject[i];
                }

            }

            return attr;
        }

        public static List<double> sort(List<double> numbers)
        {
            double tmp;
            List<double> wynik = new List<double>();
            wynik = numbers;
            for (int i = 0; i < wynik.Count - 1; i++)
            {
                for (int j = 0; j < wynik.Count - 1; j++)
                {
                    if (wynik[j] > wynik[j + 1])
                    {
                        tmp = wynik[j];
                        wynik[j] = wynik[j + 1];
                        wynik[j + 1] = tmp;

                    }
                }
            }

            return wynik;
        }

        public string showSamples()
        {
            string value = "";
            foreach (Element elem in Objects)
            {
                foreach (double aaa in elem.Attributes)
                {
                    value += aaa + " ";
                }
                value += elem.Decision+"\n";
            }

            return value;
        }

        public double? Classify(Element myObject, double k, string metryka)
        {

            string temp = "";
            double distance;
            Dictionary<double, List<double>> classAndListOfDistance = new Dictionary<double, List<double>>();

            foreach (Element elem in Objects)
            {
              
                    distance = Element.distance(metryka, elem, myObject);

                    if (classAndListOfDistance.ContainsKey(elem.Decision))
                    {
                        classAndListOfDistance[elem.Decision].Add(distance);
                    }
                    else
                    {
                        classAndListOfDistance.Add(elem.Decision, new List<double>());
                        classAndListOfDistance[elem.Decision].Add(distance);
                    }
            }

           

            Dictionary<double, double> results = new Dictionary<double, double>();
            double? minValueKey = null;
            List<double> list = new List<double>();
            List<double> sorted = new List<double>();
            double sum=0;
            double minValue=0;
            foreach (KeyValuePair<double, List<double>> pair in classAndListOfDistance)
            {
              
                foreach (double elem in pair.Value)
                {
                    list.Add(elem);
                    sort(list);
                }

                for (int i= 0; i<k; i++)
                {
                    sum += list[i];
                }

                results[pair.Key] = sum;
                minValue = sum;
                sum = 0;
                list.Clear();
                
                
            }
            foreach(KeyValuePair<double,double> pair in results)
            {
                if(minValue>pair.Value)
                {
                    minValue = pair.Value;
                    minValueKey = pair.Key;
                }
                temp += pair.Key + " " + pair.Value + "\n";
            }

            

            return minValueKey;
        }


    }
}
