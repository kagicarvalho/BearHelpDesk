using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BearHelpDesk.Domain.Enums;
using System.Collections.Generic;
using BearHelpDesk.Domain.Entities;
using BearHelpDesk.Domain.ValueObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BearHelpDesk.Tests.Domain.ClientTests
{
    [TestClass]
    public class ClientTest
    {
        private static readonly Document _document = new Document("19470054000149", EDocumentType.cnpj);
        private static readonly Phones _phones = new Phones("2730903898", "27981530275");
        private static readonly Email _email = new Email("kagi.carvalho@outlook.com");

        private readonly Client clientValid = new Client("Andrea e Milena Financeira ME", "Andrea e Milena Financeira", _document, _phones, _email );

        [TestMethod]
        [TestCategory("Domain")]
        public void ClientCorreto()
        {
            Assert.AreEqual(clientValid.Valid, true);
        }
    }
}
