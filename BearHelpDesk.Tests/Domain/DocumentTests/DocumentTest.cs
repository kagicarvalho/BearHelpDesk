using BearHelpDesk.Domain.Enums;
using BearHelpDesk.Domain.ValueObject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearHelpDesk.Tests.Domain.DocumentTests
{
    [TestClass]
    public class DocumentTest
    {
        private readonly Document _documentCNPJ = new Document("19470054000149", EDocumentType.cnpj);
        private readonly Document _documentCPF = new Document("13172906744", EDocumentType.cpf);
        private readonly Document _documentCNPJInValid = new Document("1947005400014", EDocumentType.cnpj);
        private readonly Document _documentCPFInValid = new Document("131729067444", EDocumentType.cpf);

        [TestMethod]
        [TestCategory("Domain")]
        public void DocumentCNPJValid()
        {
            Assert.AreEqual(_documentCNPJ.Valid, true);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void DocumentCPFValid()
        {
            Assert.AreEqual(_documentCPF.Valid, true);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void DocumentCNPJInValid()
        {
            Assert.AreEqual(_documentCNPJInValid.Valid, false);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void DocumentCPFInValid()
        {
            Assert.AreEqual(_documentCPFInValid.Valid, false);
        }
    }
}
