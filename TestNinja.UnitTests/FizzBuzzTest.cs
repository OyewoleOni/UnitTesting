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
    public class FizzBuzzTests
    {

        [Test]
        public void GetOutput_Should_Return_String_AndNotEmpty()
        {
            var result = FizzBuzz.GetOutput(3);

            Assert.That(result, Is.TypeOf<string>());
            Assert.That(result,Is.Not.Empty);
        }

        [Test]
       
        public void GetOutputIfDivisibleBy3And5_Should_ReturnFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutputIfDivisibleByThree_Should_Return_Fizz()
        {
            var result = FizzBuzz.GetOutput(3);

            Assert.That(result, Is.EqualTo("Fizz"));
        }
        [Test]
        public void GetOutputIfDivisibleByFive_Should_Return_Fizz()
        {
            var result = FizzBuzz.GetOutput(5);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutputIfNotDivisibleByThreeOrFive_Should_Return_TheSameNumber()
        {
            var result = FizzBuzz.GetOutput(1);

            Assert.That(result, Is.EqualTo("1"));
        }
    }
}
