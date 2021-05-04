using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BearHelpDesk.Domain.ValueObject
{
    public class Email : BaseValueObject
    {
        public Email(string address)
        {
            Address = address;

            AddNotifications(new Contract().Requires().IsEmailOrEmpty(Address, "Address", "E-mail inválido"));
        }

        [Required(ErrorMessage = "Este campo é obrigátorio")]
        [MaxLength(100, ErrorMessage = "Este campo deve conter entre 10 e 100 caracteres")]
        [MinLength(10, ErrorMessage = "Este campo deve conter entre 10 e 100 caracteres")]
        public string Address { get; set; }
    }
}
