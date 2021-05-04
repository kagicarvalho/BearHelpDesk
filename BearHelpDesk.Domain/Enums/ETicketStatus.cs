using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearHelpDesk.Domain.Enums
{
    public enum ETicketStatus
    {
        New = 0,
        Open = 1,
        Urgent = 2,
        Approved = 3,
        InProgress = 4,
        Concluded = 5,
        Paused = 6,
        Pending = 7,
        Cancelad = 8,
        Closed = 9
    }
}
