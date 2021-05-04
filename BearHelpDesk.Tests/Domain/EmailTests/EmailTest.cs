using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BearHelpDesk.Domain.Entities;
using BearHelpDesk.Domain.ValueObject;

namespace BearHelpDesk.Tests.Domain.EmailTests
{
    [TestClass]
    public class EmailTest
    {
        private readonly Email addressValid = new Email("kagiadrian@gmail.com");
        private readonly Email addressInValid = new Email("kagiadrian@gmail");

        [TestMethod]
        [TestCategory("Domain")]
        public void EmailCorreto()
        {
            Assert.AreEqual(addressValid.Valid, true);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void EmailIncorreto()
        {
            Assert.AreEqual(addressInValid.Valid, false);
        }
    }
}
