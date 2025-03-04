using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignDocWithFlyWeightPattern
{
    class CharacterFactory
    {
        public static Dictionary<char, Characters> map = new Dictionary<char, Characters>();
        public Characters CreateCharacter(char character)
        {
            if(map.ContainsKey(character))
            {
                return map[character];
            }
            else
            {
                Characters obj = new Characters("Arial", character);
                map.Add(character, obj);
                return map[character];
            }
        }
    }
}
