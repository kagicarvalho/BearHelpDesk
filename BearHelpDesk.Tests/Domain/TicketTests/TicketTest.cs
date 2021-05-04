using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BearHelpDesk.Domain.Enums;
using System.Collections.Generic;
using BearHelpDesk.Domain.Entities;
using BearHelpDesk.Domain.ValueObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BearHelpDesk.Tests.Domain.TicketTests
{
    [TestClass]
    public class TicketTest
    {
        private static readonly Address _address = new Address(ETypeAddress.Residence, "Rua Trinta e Quatro 36", " Perto do hospital", "95", "Santa Mônica", "Vila Velha", "ES", "Brazil");
        private static readonly Guid idTest = Guid.NewGuid();

        private readonly Ticket _ticketValid = new Ticket("Test Model", "testagem", ETicketStatus.New, ETicketType.Suggestion, ESeverityLevel.LowPriority, idTest, _address);

        [TestMethod]
        [TestCategory("Domain")]
        public void TicketValid()
        {
            Assert.AreEqual(_ticketValid.Valid, true);
        }
    }
}
