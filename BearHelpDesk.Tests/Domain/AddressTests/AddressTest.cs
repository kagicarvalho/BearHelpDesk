using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BearHelpDesk.Domain.Entities;
using BearHelpDesk.Domain.Enums;

namespace BearHelpDesk.Tests.Domain.AddressTests
{
    [TestClass]
    public class AddressTest
    {
        private readonly Address addressValid = new Address(ETypeAddress.Residence, "Rua Trinta e Quatro 36"," Perto do hospital", "95", "Santa Mônica", "Vila Velha", "ES", "Brazil");

        [TestMethod]
        [TestCategory("Domain")]
        public void EnderecoCorreto()
        {
            Assert.AreEqual(addressValid.Valid, true);
        }
    }
}
