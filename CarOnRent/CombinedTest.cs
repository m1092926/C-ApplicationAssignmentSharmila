using CarOnRent.CarOnRentA;
using CarOnRent.CarOnRentB;
using CarOnRentA;
using CarOnRentB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOnRent.CombinedTest
{
    public class CombinedTest
    {
        private static CombinedTest carOnRents;
        private CombinedTest combined;

        public CombinedTest()
        {

        }
        public object DisplayCombinedTest()
        {

            SingleFamilyTest single = new SingleFamilyTest();
            MultiUnitsTest multiUnits = new MultiUnitsTest();
            List<CombinedTest> carOnRents = new List<CombinedTest>();
            object s = single.DisplaySingleFamily();
            object m = multiUnits.DisplayMultiUnits();


            List<object> newList = new List<object>((IEnumerable<object>)s);
            List<object> newList1 = new List<object>((IEnumerable<object>)m);
            List<object> combined = newList.Concat(newList1).ToList();

            return combined;
        }
    }
}
