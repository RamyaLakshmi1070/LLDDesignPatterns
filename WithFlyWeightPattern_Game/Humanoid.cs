using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithFlyWeightPattern_Game
{
    class Humanoid : IRobot
    {
        private String type;
        private Sprite sprite;
        public Humanoid(String type,Sprite sprite)
        {
            this.type = type;
            this.sprite = sprite;
        }
        public void Display(int x, int y)
        {
            Console.WriteLine("Placed a Humanoid at {0} and {1}",x,y);
        }
        public String GetType()
        {
            return type;
        }
    }
}
