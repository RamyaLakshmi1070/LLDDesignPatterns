using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern
{
    class ConfigurationMemto
    {
        public int h, w;
        public ConfigurationMemto(int height,int weight)
        {
            h = height;
            w = weight;
        }
        public int GetHeight()
        {
            return h;
        }
        public int GetWeight()
        {
            return w;   
        }
        
    }
}
