using CarOnRent.CarOnRentB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOnRentB
{
  public  class MultiUnitsTest
    {
        private static MultiUnit single;

        public MultiUnitsTest()
        {

        }

        public static MultiUnit DisplayMultiUnits()
        {

            List<MultiUnit> multiUnits
                    = new List<MultiUnit>();
            multiUnits.Add(item: new MultiUnit { complex_name ="Sharmila_paul", number_of_units = 54, rent_amt_per_unit = 4});
multiUnits.Add(item: new MultiUnit { complex_name ="Sharmila1_paul", number_of_units = 54, rent_amt_per_unit = 4});
multiUnits.Add(item: new MultiUnit { complex_name ="Sharmila2_paul", number_of_units = 54, rent_amt_per_unit = 4});
multiUnits.Add(item: new MultiUnit { complex_name ="Sharmila3_paul", number_of_units = 54, rent_amt_per_unit = 4});
multiUnits.Add(item: new MultiUnit { complex_name ="Sharmila4_paul", number_of_units = 54, rent_amt_per_unit = 4});
          
          
          
            foreach (MultiUnit single in multiUnits)
            {
                Console.WriteLine($"{single.complex_name}:{single.number_of_units}:{single.rent_amt_per_unit}");
            }

            return single;
        }
    }
}
