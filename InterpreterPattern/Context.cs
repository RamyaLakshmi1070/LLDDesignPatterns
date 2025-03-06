using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    class Context
    {
        Dictionary<char, int> map = new Dictionary<char, int>();
        public void Put(char  a,int a1)
        {
            map.Add(a, a1);
        }
        public int GetInteger(char a)
        {
            if (map.ContainsKey(a))
                return map[a];

            return 0;
        }
    }
}
