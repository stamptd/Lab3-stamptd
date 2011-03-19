using System;
using Expedia;
using NUnit.Framework;

namespace ExpediaTest
{
	[TestFixture()]
	public class FlightTest
	{
        private readonly DateTime startDate = new DateTime(2011,6,15);
        private readonly DateTime endDate = new DateTime(2011, 7, 20);
        private readonly int miles = 5;
        [Test()]
        public void TestThatFlightInitializes()
        {
            var target = new Flight(startDate,endDate,miles);
            Assert.IsNotNull(target);
        }
        [Test()]
        public void TestThatFlightSetsLeaveDate()
        {
            var target = new Flight(startDate, endDate, miles);
            Assert.AreEqual(startDate, target.dateThatFlightLeaves);
        }
        [Test()]
        public void TestThatFlightSetsReturnDate()
        {
            var target = new Flight(startDate, endDate, miles);
            Assert.AreEqual(endDate, target.dateThatFlightReturns);
        }
        [Test()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestThatFlightThrowsErrorForOutOfOrderDates()
        {
            var target = new Flight(endDate, startDate, miles);
        }
        [Test()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestThatFlightThrowsErrorForNegativeMiles()
        {
            var target = new Flight(startDate, endDate, -miles);
        }
        [Test()]
        public void TestThatFlightSetsMiles()
        {
            var target = new Flight(startDate, endDate, miles);
            Assert.AreEqual(miles, target.Miles);
        }
        [Test()]
        public void TestEquals()
        {
            var target1 = new Flight(startDate, endDate, miles);
            var target2 = new Flight(startDate, endDate, miles);
            Assert.AreEqual(target1, target2);
        }
        [Test()]
        public void TestGetBasePrice()
        {
            var target = new Flight(startDate, endDate, miles);
            Assert.AreEqual(900, target.getBasePrice());
        }


       
	}
}
