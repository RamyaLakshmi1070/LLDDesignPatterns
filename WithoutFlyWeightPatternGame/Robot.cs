using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutFlyWeightPatternGame
{
    class Robot
    {
        int x;
        int y;
        String Type;
        Sprite body;
        public Robot(int x,int y,String Type,Sprite body)
        {
            this.x = x;
            this.y = y;
            this.Type = Type;
            this.body = body;
        }
    }
}
