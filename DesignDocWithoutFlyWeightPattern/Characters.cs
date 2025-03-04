using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignDocWithoutFlyWeightPattern
{
    class Characters
    {
        int row;
        int col;
        char character;
        String font;
        public Characters(int row,int col,char
            character,String Font)
        {
            this.row = row;
            this.col = col;
            this.character = character;
            this.font = Font;
        }
    }
}
