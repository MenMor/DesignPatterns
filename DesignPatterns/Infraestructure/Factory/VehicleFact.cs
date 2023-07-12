using DesignPatterns.Models;
using DesignPatterns.Models.BuildersVehicle;

namespace DesignPatterns.Infraestructure.Factory
{
	public class VehicleFact
	{

		public static Vehicle CreateVehicle(string modelToCreate)
		{
			CarBuilder builder;
			Vehicle vehicle;

			switch (modelToCreate)
			{
				case "Escape":
					builder = new EscapeB();
					break;
				case "Explorer":
					builder = new ExploreB();
					break;
				default:
					builder = new MustangB();
					break;
			}

			vehicle = builder.SetModel(modelToCreate).Build();
			return vehicle;
		}
	}
}