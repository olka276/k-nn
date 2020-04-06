using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knn
{
    class Element
    {
        public List<float> Attributes;
        private float Decision;

        public Element (List<float> attrib)
        {
            Attributes = attrib;
            Decision = 9999;
        }
    }
}
