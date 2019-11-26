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
   public class CustomerConhtrollerTest
    {
        [Test]
        public void GetCustomer_IdIsZero_ShouldRetunNotFound()
        {
            var controller = new CustomerController();

            var result = controller.GetCustomer(0);

            // NotFound
            Assert.That(result, Is.TypeOf<NotFound>());

            // NotFound or one of its derivatives
            // Assert.That(result, Is.InstanceOf<NotFound>());
        }
        [Test]
        public void GetCustomer_IdIsNptZero_ShouldRetunOk()
        {
            var controller = new CustomerController();

            var result = controller.GetCustomer(1);

            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}
