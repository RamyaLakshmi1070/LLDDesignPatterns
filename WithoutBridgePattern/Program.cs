namespace WithoutBridgePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LivingThings livingThings = new Fish();
            livingThings.BreatheProcess();
        }
    }
}
