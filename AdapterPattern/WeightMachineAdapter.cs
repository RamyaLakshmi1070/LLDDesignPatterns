using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class WeightMachineAdapter : IWeightMachineAdapter
    {
        private readonly WeightMachine _weightMachine;
        public WeightMachineAdapter(WeightMachine weightMachine)
        {
            _weightMachine = weightMachine;
        }
        public double GetWeightInKg()
        {
            double pound = _weightMachine.WeightInPound();
            return (pound * .45);

        }
    }
}
