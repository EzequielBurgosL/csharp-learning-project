using oopTutorial.Interfaces;

namespace oopTutorial.Interfaces.Test
{
    public class VehicleTests
    {
        [Fact]
        public void Accelerate_ShouldReturnCorrectSpeeds()
        {
            var vehicles = new List<IVehicle>
            {
                new Car(),
                new Motorcycle(),
                new Truck()
            };

            var expectedSpeeds = new List<int> { 100, 80, 60 };

            for (int i = 0; i < vehicles.Count; i++)
            {
                Assert.Equal(expectedSpeeds[i], vehicles[i].Accelerate());
            }
        }
    }
}