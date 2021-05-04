using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using BearHelpDesk.Domain.Enums;
using BearHelpDesk.Domain.ValueObject;

namespace BearHelpDesk.Domain.Entities
{
    public class User : IdentityUser<string>
    {
        public EDocumentType Document { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
