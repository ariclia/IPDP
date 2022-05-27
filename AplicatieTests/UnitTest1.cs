using Aplicatie;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AplicatieTests
{
    [TestClass]
    public class UnitTest1
    {
        public Pilot ExtractInputsPilot(string first, string last, string number, string localitate)
        {
            return new Pilot { IDPilot = 0, FirstName = first, LastName = last, NrLicense = number, Locality = localitate };
        }

        public Flight ExtractInputsFlight(string name, string TakeOffD, string TakeOffA, string LandingD, string LandingA, string emargencyA)
        {
            return new Flight { IDFlight = 0, Name = name, TakeOffDate = TakeOffD, TakeOffAirport = TakeOffA, LandingDate = LandingD, LandingAirport = LandingA, EmargencyAirport = emargencyA };
        }

        [TestMethod]
        public void TestMethod_1()
        {
            Pilot PilotForm = new Pilot();
            var model = ExtractInputsPilot("FirstName", "LastName", "Number", "NewYork");
            Assert.AreEqual(model.FirstName,"FirstName");
        }
        [TestMethod]
        public void TestMethod_2()
        {
            Pilot PilotForm = new Pilot();
            var model = ExtractInputsPilot("FirstName", "LastName", "Number", "NewYork");
            Assert.AreEqual(model.LastName, "LastName");
        }
        [TestMethod]
        public void TestMethod_3()
        {
            Pilot PilotForm = new Pilot();
            var model = ExtractInputsPilot("FirstName", "LastName", "Number", "NewYork");
            Assert.AreEqual(model.NrLicense, "Number");
        }

        [TestMethod]
        public void TestMethod_4()
        {
            Pilot PilotForm = new Pilot();
            var model = ExtractInputsPilot("FirstName", "LastName", "Number", "NewYork");
            Assert.AreEqual(model.Locality, "NewYork");
        }

        [TestMethod]
        public void TestMethod_5()
        {
            Flight FlightForm = new Flight();
            var model = ExtractInputsFlight("Name", "TakeOffDate", "Ghimbav", "Curand", "Sibiu", "Brasov");
                Assert.AreEqual(model.Name, "Name");
        }

        [TestMethod]
        public void TestMethod_6()
        {
            Flight FlightForm = new Flight();
            var model = ExtractInputsFlight("Name", "TakeOffDate", "Ghimbav", "Curand", "Sibiu", "Brasov");
                Assert.AreEqual(model.TakeOffDate, "TakeOffDate");
        }

        [TestMethod]
        public void TestMethod_7()
        {
            Flight FlightForm = new Flight();
            var model = ExtractInputsFlight("Name", "TakeOffDate", "Ghimbav", "Curand", "Sibiu", "Brasov");
            Assert.AreEqual(model.TakeOffAirport, "Ghimbav");
        }
        [TestMethod]
        public void TestMethod_8()
        {
            Flight FlightForm = new Flight();
            var model = ExtractInputsFlight("Name", "TakeOffDate", "Ghimbav", "Curand", "Sibiu", "Brasov");
            Assert.AreEqual(model.LandingDate, "Curand");
        }
        [TestMethod]
        public void TestMethod_9()
        {
            Flight FlightForm = new Flight();
            var model = ExtractInputsFlight("Name", "TakeOffDate", "Ghimbav", "Curand", "Sibiu", "Brasov");
            Assert.AreEqual(model.LandingAirport, "Sibiu");
        }
        [TestMethod]
        public void TestMethod_10()
        {
            Flight FlightForm = new Flight();
            var model = ExtractInputsFlight("Name", "TakeOffDate", "Ghimbav", "Curand", "Sibiu", "Brasov");
            Assert.AreEqual(model.EmargencyAirport, "Brasov");
        }
    }
}
