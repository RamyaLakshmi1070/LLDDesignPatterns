namespace WithBridgePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LivingThings livingThings = new Fish(new WaterBreatheImplementor());
            livingThings.Breathe();
        }
    }
}
