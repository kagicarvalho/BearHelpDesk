using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearHelpDesk.Domain.Entities
{
    public class Work : BaseEntity
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Observation { get; private set; }
        public string InternalObservation { get; private set; }
        public string CustomerNotice { get; private set; }
        public decimal Price { get; private set; }
        public Address Address { get; private set; }
        public string Client { get; private set; }
        public string Atendente { get; private set; }
    }
}
