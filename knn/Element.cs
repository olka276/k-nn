using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knn
{
    class Element
    {
        public List<double> Attributes;
        public double Decision;

        public Element (List<double> attrib, double decision)
        {
            Attributes = attrib;
            Decision = decision;
        }

        public Element(List<double> attrib)
        {
            Attributes = attrib;
            Decision = -999;
        }


        public static double distance (string method, Element obj1, Element obj2)
        {
            double value = 0;
            if (obj1.Attributes.Count != obj2.Attributes.Count)
            {
                return 99999999999;
            }
            else
            { 
               
                switch (method)
                {
                    case "euklides":

                        for (int i = 0; i < obj1.Attributes.Count; i++)
                        {
                            value += Math.Pow((obj1.Attributes[i] - obj2.Attributes[i]), 2);
                        }

                        value = Math.Sqrt(value);
                        break;
                }
            }
            return Math.Round(value, 2);
        }
    }
}
