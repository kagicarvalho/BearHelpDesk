using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BearHelpDesk.Domain.Enums;
using BearHelpDesk.Domain.ValueObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BearHelpDesk.Tests.Domain.PhonesTests
{
    [TestClass]
    public class PhoneTest
    {
        private readonly Phones _phoneValid = new Phones("27981530274","27981530274");

        [TestMethod]
        [TestCategory("Domain")]
        public void PhoneValid()
        {
            Assert.AreEqual(_phoneValid.Valid, true);
        }
    }
}
