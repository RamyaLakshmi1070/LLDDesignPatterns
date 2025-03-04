using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignDocWithFlyWeightPattern
{
    class Characters : ILetter
    {
        private String font;
        private char character;
        public Characters(String font,char character)
        {
            this.font = font;
            this.character = character;
        }
        public void Display(int r, int c)
        {
            Console.WriteLine("Character has been placed at {0} {1}",r,c);
        }
    }
}
