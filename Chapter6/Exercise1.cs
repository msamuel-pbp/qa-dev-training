using NUnit.Framework;

namespace Chapter6
{
    [TestFixture]
    class Exercise1
    {
        public abstract class Vehicle
        {
            protected int maxPassengers;
            protected int fuelType;

            protected void Move()
            {
                
            }

            protected void Stop()
            {
                
            }
        }

        public class Car : Vehicle
        {
            private int numDoors;
            private bool stickShift;

            public void Honk()
            {
                
            }

            public void HaulTrailer()
            {
                
            }
        }

        public class Plane : Vehicle
        {
            private int numEngines;
            private string jetOrProp;

            public void Bank()
            {
                
            }

            public void GainAltitude()
            {
                
            }
        }

        public class Boat : Vehicle
        {
            private float keelDepth;
            private string sailsOrMotor;

            public void DropAnchor()
            {
                
            }

            public void PumpBilge()
            {
                
            }
        }

        [Test]
        public void makevehicles()
        {
            Car porsche = new Car();
            Plane boeing747 = new Plane();
            Boat yacht = new Boat();

            // Vehicle vehicle = new Vehicle();

            porsche.HaulTrailer();
            porsche.Honk();

            boeing747.Bank();
            boeing747.GainAltitude();

            yacht.DropAnchor();
            yacht.PumpBilge();
        }
    }
}
