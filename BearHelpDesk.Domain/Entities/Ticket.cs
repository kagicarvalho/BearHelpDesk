using BearHelpDesk.Domain.Enums;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearHelpDesk.Domain.Entities
{
    public class Ticket : BaseEntity
    {
        public Ticket(string title, string description, ETicketStatus status, ETicketType type, Guid idClient, Address address)
        {
            Title = title;
            Description = description;
            Status = status;
            Type = type;
            IdClient = idClient;
            Address = address;

            AddNotifications(new Contract()
                                    .Requires()
                                    .HasMinLen(Title,3, "Title", "Título deve ter mais de 3 caracteres")
                                    .HasMaxLen(Title,60,"Title","Título deve ter menos de 60 caracteres")
                                    .HasMinLen(Description, 3, "Description", "Título deve ter mais de 3 caracteres")
                                    .HasMaxLen(Description, 1024, "Description", "Título deve ter menos de 60 caracteres")
                                    );
        }


        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre e 3 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre e 3 60 caracteres")]
        public string Title { get; private set; }

        [MaxLength(1024, ErrorMessage = "Este campo deve conter no máximo 1024 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre e 3 60 caracteres")]
        public string Description { get; private set; }
        public ETicketStatus Status { get; private set; }
        public ETicketType Type { get; private set; }
        public Guid IdClient { get; private set; }
        public Guid Attendant { get; private set; }
        public Address Address { get; private set; }
        public DateTime CloseTicket { get; set; }
    }
}
