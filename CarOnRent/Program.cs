using System;

namespace CarOnRent
{
    interface IUnits
    {
        int display();
    }
    public partial class Car : IUnits
    {
        String name, model;
        int purchase_year;
        public Car()
        {
            name = "Sharmila";
            model = "BMW";
            purchase_year = 0;
        }

        public Car(string name, String model, int purchase_year)
        {
            this.name = name;
            this.model = model;
            this.purchase_year = purchase_year;
        }
        public virtual decimal ProjectedRentalAmt()
        {
            decimal y = 1.0M;
            Console.WriteLine("This is ProjectedRental amt");
            return y;
        }
        public void addition()
        {
            Console.WriteLine("This is addition method");
        }
        public override string ToString()
        {
            return name + " " + model + " " + purchase_year;
        }

        public int display()
        {
            int number_of_units = 0; ;
            Console.WriteLine(number_of_units);
            return number_of_units;
        }
    }
        namespace CarOnRentB {
        public class MultiUnit : Car, IUnits

        {
            public String complex_name;
            public int number_of_units, rent_amt_per_unit;
            public MultiUnit() {
                complex_name = "Sharmila_Paul";
                number_of_units = 4;
                rent_amt_per_unit = 5;
            }
            public MultiUnit(string complex_name, int number_of_units, int rent_amt_per_unit)
            {
                this.complex_name = complex_name;
                this.number_of_units = number_of_units;
                this.rent_amt_per_unit = rent_amt_per_unit;
            }
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
    }
    namespace CarOnRentA
    {
        public class SingleFamily : Car
        {
            public int rent_amt
                , mileage, number_of_seats;
            public string bluetooth_or_wifi, ac_or_nonac, availability_of_maintainance;

            public SingleFamily()
            {
                rent_amt = 1000;
                mileage = 54;
                number_of_seats = 4;
                bluetooth_or_wifi = "WIFI";
                ac_or_nonac = "AC";
                availability_of_maintainance = "Y";
            }

            public SingleFamily(int rent_amt, int number_of_seats, string bluetooth_or_wifi, string ac_or_nonac, string availability_of_maintainance)
            {
                this.rent_amt = rent_amt;
                this.number_of_seats = number_of_seats;
                this.bluetooth_or_wifi = bluetooth_or_wifi;
                this.ac_or_nonac = ac_or_nonac;
                this.availability_of_maintainance = availability_of_maintainance;
            }
            public override decimal ProjectedRentalAmt()
            {
                decimal y = 1.0M;
                y = rent_amt * 12;
                return y;
            }


            public override string ToString()
            {
                return string.Format(rent_amt + " " + mileage + " " + number_of_seats + " " + bluetooth_or_wifi + " " + ac_or_nonac + " " + availability_of_maintainance);
            }


        }
    }
      

}
