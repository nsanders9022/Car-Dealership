using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    class Car
    {
        private string _MakeModel;
        private int _Price;
        private int _Miles;

        public void SetMakeModel(string newMakeModel)
        {
            _MakeModel = newMakeModel;
        }
        public string GetMakeModel()
        {
            return _MakeModel;
        }

        public void SetPrice(int newPrice)
        {
            _Price = newPrice;
        }

        public int GetPrice()
        {
            return _Price;
        }


        public void SetMiles(int newMileage)
        {
            _Miles = newMileage;
        }

        public int GetMiles()
        {
            return _Miles;
        }


        public Car(string carMakeModel, int carPrice, int carMileage=20000)
        {
            _MakeModel = carMakeModel;
            _Price = carPrice;
            _Miles = carMileage;
        }

        public bool WorthBuying(int maxPrice, int maxMileage)
        {
            return (_Price < maxPrice && _Miles < maxMileage);
        }
    }

    public class Program
    {
        public static void Main()
        {
            Car porsche = new Car("2014 Porsche 911", 114991, 7864);
            Car ford = new Car("2011 Ford F450", 55995, 14241);
            Car lexus = new Car("2013 Lexus RX 350", 44700);
            Car mercedes = new Car("Mercedes Benz CLS550", 39900, 37979);

            List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes };

            foreach(Car automobile in Cars)
            {
                Console.WriteLine(automobile.GetMakeModel());
            }

            Console.WriteLine("Enter maximum price: ");
            string stringMaxPrice = Console.ReadLine();
            int maxPrice = int.Parse(stringMaxPrice);

            Console.WriteLine("Enter maximum mileage: ");
            string stringMaxMileage = Console.ReadLine();
            int maxMileage = int.Parse(stringMaxMileage);

            List<Car> CarsMatchingSearch = new List<Car>();

            foreach (Car automobile in Cars)
            {
                if (automobile.WorthBuying(maxPrice,maxMileage))
                {
                    CarsMatchingSearch.Add(automobile);
                }
            }

            foreach (Car automobile in CarsMatchingSearch)
            {
                Console.WriteLine(automobile.GetMakeModel());
            }
        }
    }


}
