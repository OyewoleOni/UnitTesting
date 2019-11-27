using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        private DemeritPointsCalculator demeritPoints;

        [SetUp]
        public void SetUp()
        {
            demeritPoints = new DemeritPointsCalculator();
        }

        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void CalculateDemeritPoints_IfSpeedLessThan0OrGreaterThan300_ReturnArgumentOutOfRangeException(int speed)
        {
            Assert.That(() => demeritPoints.CalculateDemeritPoints(speed), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(0,0)]
        [TestCase(64,0)]
        [TestCase(65,0)]
        [TestCase(66, 0)]
        [TestCase(70, 1)]
        public void CalculateDemeritPoints_WhenCalled_ReturnDemeritPoints(int speed, int expectedResult)
        {
            var result = demeritPoints.CalculateDemeritPoints(speed);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void CalculateDemeritPoints_IfValidSpeed_ReturnCalculatedPoint()
        {
            var result = demeritPoints.CalculateDemeritPoints(75);

            Assert.That(result, Is.EqualTo(2));
        }
    }
}
