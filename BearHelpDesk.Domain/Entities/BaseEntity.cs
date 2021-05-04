using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearHelpDesk.Domain.Entities
{
    public class BaseEntity : Notifiable
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }


        [Key]
        public Guid Id { get; set; }
        public DateTime DateCreate { get; private set; }
        public DateTime DateUpdate { get; private set; }
    }
}
