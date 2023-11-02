using System.Drawing;

namespace Vehicle.UnitTests
{
    public class VehicleTests
    {
        [Fact]
        public void WhenCreated_HasCorrectProperties()
        {
            Vehicle megansCar = new Vehicle(4, "Green");

            Assert.Equal(4, megansCar.NumberOfWheels);
            Assert.Equal("Green", megansCar.Color);
            Assert.Equal(0, megansCar.MilesDriven);
        }

        // This test needs some work!
        [Fact]
        public void Summary_ReturnsInfoAboutVehicle()
        {
            Vehicle andysBike = new Vehicle(2, "Blue");
            andysBike.Summary();

            Assert.Equal($"This Blue vehicle has 2 wheels, and has driven 0 miles.", andysBike.Summary());
            }

        [Fact]
        public void UpdatingMilesDriven_ForVehicle()
        {
            Vehicle anniesCar = new Vehicle(4, "Grey");
            anniesCar.Drive();

            Assert.Equal(5, anniesCar.MilesDriven);
        }

        [Fact]
        public void UpdatingPaintColor_ForVehicle()
        {
            Vehicle anniesCar = new Vehicle(4, "Grey");
            anniesCar.Paint("Green");

            Assert.Equal("Green", anniesCar.Color);
        }
    }
}