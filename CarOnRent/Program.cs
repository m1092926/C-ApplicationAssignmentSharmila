using System;

namespace CarOnRent
{
    interface IUnits
    {
        int display();
    }
  public partial class Car: IUnits
    {
        String name, model;
        int purchase_year;
        public virtual decimal ProjectedRentalAmt()
        {
            decimal y = 1.0M;
            Console.WriteLine("This is subtraction method");
            return y;
         }
        public void addition()
        {
            Console.WriteLine("This is addition method");
        }
        public override string ToString()
        {
            return   name + " " + model +" "+ purchase_year;
        }

        public int display()
        {
            int number_of_units = 0;
            Console.WriteLine(number_of_units);
            return number_of_units;
        }
     public   class MultiUnit: Car, IUnits

        {
            String complex_name;
            int number_of_units, rent_amt_per_unit;
            public int GetNumUnits()
            {
                int x = 0;
                Console.WriteLine(x);
                return x;
            }
            public override string ToString()
            {
                return complex_name + " " + number_of_units + " " + rent_amt_per_unit;
            }
            public override decimal ProjectedRentalAmt()
            {
                decimal y = 1.0M;
                Console.WriteLine("This is subtraction method");
                y = rent_amt_per_unit * number_of_units * 12;
                return y;
            }
        }


      
       


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car car = new Car();
           car. ProjectedRentalAmt();
            car.addition();
            car.ToString();
            car.display();

        }
    }
}
