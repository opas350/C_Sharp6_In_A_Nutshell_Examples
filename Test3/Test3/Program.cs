using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    public class UnitConverter
    {
        int ratio;

        public UnitConverter(int unitRatio) { ratio = unitRatio; }      // Constructor
        public int Convert(int unit) { return unit * ratio; }           // Method
    }

    class Program
    {
        static void Main(string[] args)
        {
            UnitConverter feetToInchesConverter = new UnitConverter(12);
            UnitConverter milesToFeetConverter = new UnitConverter(5280);

            Console.WriteLine(feetToInchesConverter.Convert(30));       // 360
            Console.WriteLine(feetToInchesConverter.Convert(100));      // 1200
            Console.WriteLine(feetToInchesConverter.Convert(milesToFeetConverter.Convert(1)));      // 63360
            Console.ReadKey();
        }
    }
}
