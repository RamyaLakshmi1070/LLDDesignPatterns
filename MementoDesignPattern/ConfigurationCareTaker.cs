using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern
{
    class ConfigurationCareTaker
    {
        List<ConfigurationMemto> lst;
        public ConfigurationCareTaker()
        {
            lst = new List<ConfigurationMemto>();
        }
        public void AddMemento(ConfigurationMemto memento)
        {
            
            lst.Add(memento);
        }
        public ConfigurationMemto Undo()
        {
           if(lst.Count!=0)
            {
                var configuration = lst[lst.Count-1];
                lst.RemoveAt(lst.Count-1);
                return configuration;
            }
            return null;
        }
    }
}
