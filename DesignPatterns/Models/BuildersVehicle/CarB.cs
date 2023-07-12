using System;

namespace DesignPatterns.Models.BuildersVehicle
{
    public abstract class CarB
    {
        public string Brand = "Ford";
        public string Model = "Mustang";
        public string Color = "Red";
        public int Year = DateTime.Now.Year;

        public abstract CarB SetBrand(string brand);
        public abstract CarB SetModel(string model);

        public abstract CarB SetColor(string color);

        public abstract CarB SetYear(int year);

        public Car Build()
        {
            return new Car(Color, Brand, Model, Year);
        }
    }
}