using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            AirLines AirLinesMM = new AirLines();
            AirLines AirLinesML = new AirLines(2, 13, "Monday", "23:00", "London");
            AirLines AirLinesWM = new AirLines(4);
            AirLines AirLinesFB = new AirLines();
            AirLines AirLinesSM = new AirLines();
            AirLinesMM.Input(1, 23, "Monday", "Moskow");
            AirLinesWM.Input(1, 11, "Wednesday", "Moskow");
            AirLinesFB.Input(3, 15, "Friday", "Berlin");
            AirLinesSM.Input(2, 12, "Sunday", "Moskow");
            if(AirLinesSM is AirLines)
            {
                Console.Write("Object is AirLine \n");
            }
            AirLinesSM.Equals(AirLinesFB);
            AirLines[] Poletaem = { AirLinesMM, AirLinesML, AirLinesWM, AirLinesFB, AirLinesSM };
            foreach (AirLines i in Poletaem)
            {
                if(i.GetDay().Equals("Monday"))
                {
                    i.About();
                }
            }
            Console.WriteLine();
            foreach (AirLines i in Poletaem)
            {
                if (i.GetDestination().Equals("Moskow"))
                {
                    i.About();
                }
            }
        }
    }
}
