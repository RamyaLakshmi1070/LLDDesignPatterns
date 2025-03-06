using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern
{
    class ConfigurationOriginator
    {
        public int h, w;
        public ConfigurationOriginator(int height,int weight)
        {
            h = height;
            w = weight;
        }
        public void SetHeight(int height)
        {
            h = height;
        }
        public void SetWeight(int weight)
        {
            w = weight;
        }
        public ConfigurationMemto CreateMemento()
        {
            return new ConfigurationMemto(h, w);
        }
        public void RestoreMemento(ConfigurationMemto memto)
        {
            h = memto.GetHeight();
            w = memto.GetWeight();
        }

    }
}
