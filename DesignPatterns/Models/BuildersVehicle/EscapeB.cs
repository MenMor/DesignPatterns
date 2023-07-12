namespace DesignPatterns.Models.BuildersVehicle
{
    public class EscapeB : CarB
    {

        public override CarB SetBrand(string brand)
        {
            Brand = brand;
            return this;
        }

        public override CarB SetModel(string model)
        {
            Model = model;
            return this;
        }

        public override CarB SetColor(string color)
        {
            Color = color;
            return this;
        }

        public override CarB SetYear(int year)
        {
            Year = year;
            return this;
        }
    }
}