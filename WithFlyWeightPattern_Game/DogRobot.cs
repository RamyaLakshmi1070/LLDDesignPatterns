using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithFlyWeightPattern_Game
{
    class DogRobot : IRobot
    {
        private String type;
        private Sprite sprite;
        public DogRobot(String type, Sprite sprite)
        {
            this.type = type;
            this.sprite = sprite;
        }
        public void Display(int x, int y)
        {
            Console.WriteLine("Placed a Robotic Dog at {0} and {1}",x,y);
        }
        public String GetType()
        {
            return type;
        }
    }

}
