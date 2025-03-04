namespace WithoutFlyWeightPatternGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating

            int x = 0;
            int y = 0;
            for(int i=0;i<50000;i++)
            {
                Sprite sprite = new Sprite();
                Robot robot = new Robot(x + i, y + i, "Humanoid", sprite);
            }
            for (int i = 0; i < 50000; i++)
            {
                Sprite sprite = new Sprite();
                Robot robot = new Robot(x + i, y + i, "Robot Dog", sprite);
            }
        }
    }
}
