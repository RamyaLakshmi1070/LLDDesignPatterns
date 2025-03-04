using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithFlyWeightPattern_Game
{
    class RobotFactory
    {
        private static Dictionary<String, IRobot> map = new Dictionary<string, IRobot>();

        public IRobot CreateRobot(String type)
        {
            if(map.ContainsKey(type))
            {
                return map[type];
            }
            else
            {
                if(type=="Humanoid")
                {
                    Sprite humanoidSprite = new Sprite();
                    IRobot robot = new Humanoid(type, humanoidSprite);
                    map.Add(type, robot);
                }
                else
                {
                    Sprite dogSprite = new Sprite();
                    IRobot robot = new DogRobot(type, dogSprite);
                    map.Add(type, robot);
                }
                return map[type];
            }
        }
    }
}
