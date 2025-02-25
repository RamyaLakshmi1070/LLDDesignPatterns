namespace AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWeightMachineAdapter weightMachineAdapter = new WeightMachineAdapter(new WeightMachine());
            Console.WriteLine(weightMachineAdapter.GetWeightInKg());
            
        }
    }
}
