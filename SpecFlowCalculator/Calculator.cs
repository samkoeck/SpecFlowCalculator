using java.lang;
using System;
using System.Linq;

namespace SpecFlowCalculator
{
    public class Calculator
    {
        public string Numbers { get; set; } = "";

        public int Calculate()
        {

            int total = 0;
            if (Numbers.Length == 0)
            {
                total = 0;
            } else {
                var numbers = Numbers.Split(',')?.Select(Int32.Parse).ToList();
                for (int i = 0; i < numbers?.Count; i++)
                {
                    total += numbers[i];
                }
            }
            return total;
        }
    }
}