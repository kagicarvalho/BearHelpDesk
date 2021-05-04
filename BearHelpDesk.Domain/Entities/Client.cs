using BearHelpDesk.Domain.ValueObject;
using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearHelpDesk.Domain.Entities
{
    public class Client : BaseEntity
    {
        public Client(string companyName, string trandingName, Document document, Phones phone, Email email)
        {

            CompanyName = companyName;
            TrandingName = trandingName;
            Document = document;
            Phone = phone;
            Email = email;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(companyName, 4, "CompanyName", "Nome fantasia tem que ter no minimo 4 caracateres")
                .HasMaxLen(companyName, 60, "CompanyName", "Nome fantasia tem que ter no maximo 60 caracateres")
                .HasMinLen(trandingName, 4, "CompanyName", "Nome fantasia tem que ter no minimo 4 caracateres")
                .HasMaxLen(trandingName, 60, "CompanyName", "Nome fantasia tem que ter no maximo 60 caracateres"));

        }


        [Required(ErrorMessage = "Este campo é obrigátorio")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 4 e 60 caracteres")]
        [MinLength(4, ErrorMessage = "Este campo deve conter entre 4 e 60 caracteres")]
        public string CompanyName { get; private set; }

        [Required(ErrorMessage = "Este campo é obrigátorio")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 4 e 60 caracteres")]
        [MinLength(4, ErrorMessage = "Este campo deve conter entre 4 e 60 caracteres")]
        public string TrandingName { get; private set; }

        public Document Document { get; set; }
        public Phones Phone { get; private set; }
        public Email Email { get; private set; }

        public virtual ICollection<Address> Addresses { get; set; }

    }
}
