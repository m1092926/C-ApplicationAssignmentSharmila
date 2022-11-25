using CarOnRent.CarOnRentA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOnRentA
{
    public class SingleFamilyTest 
    {
        private static SingleFamily single;

        public SingleFamilyTest()
        {
          
        }

        public static SingleFamily DisplaySingleFamily()
        {

            List<SingleFamily> singlefamiles
                    = new List<SingleFamily>();
            singlefamiles.Add(item: new SingleFamily { rent_amt = 1000, mileage = 54, number_of_seats = 4, bluetooth_or_wifi = "WIFI", ac_or_nonac = "AC", availability_of_maintainance = "Y" });
            singlefamiles.Add(item: new SingleFamily { rent_amt = 2000, mileage = 54, number_of_seats = 4, bluetooth_or_wifi = "WIFI", ac_or_nonac = "AC", availability_of_maintainance = "Y" });
            singlefamiles.Add(item: new SingleFamily { rent_amt = 3000, mileage = 54, number_of_seats = 4, bluetooth_or_wifi = "WIFI", ac_or_nonac = "AC", availability_of_maintainance = "Y" });
            singlefamiles.Add(item: new SingleFamily { rent_amt = 4000, mileage = 54, number_of_seats = 4, bluetooth_or_wifi = "WIFI", ac_or_nonac = "AC", availability_of_maintainance = "Y" });
            singlefamiles.Add(item: new SingleFamily { rent_amt = 5000, mileage = 54, number_of_seats = 4, bluetooth_or_wifi = "WIFI", ac_or_nonac = "AC", availability_of_maintainance = "Y" });

            foreach (SingleFamily single in singlefamiles)
            {
                Console.WriteLine($"{single.rent_amt}:{single.mileage}:{single.number_of_seats}:{single.bluetooth_or_wifi}:{single.ac_or_nonac}:{single.availability_of_maintainance}");
            }

            return single;
                }


    }


}

