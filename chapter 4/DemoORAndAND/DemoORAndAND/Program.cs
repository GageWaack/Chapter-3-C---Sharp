using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace DemoORAndAND
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Zone1 = 1, Zone2 = 2;
            const int LowQuantity = 10;
            string inputString;
            int quantity;
            int deliveryZone;

            Write("Delivery is free for zone {0} or {1}",Zone1, Zone2);
            Write("when the number of boxes is less than {0}",LowQuantity);
            Write("Enter delivery zone ");
            inputString = ReadLine();
            deliveryZone = Convert.ToInt32(inputString);
            Write("Enter number of boxes in shipment ");
            inputString = ReadLine();
            quantity = Convert.ToInt32(inputString);

            if ((deliveryZone == Zone1 || deliveryZone == Zone2) && quantity < LowQuantity)
                Write("Delivery is free ");
            else
                Write("A delivery charge applies ");
        }
    }
}
