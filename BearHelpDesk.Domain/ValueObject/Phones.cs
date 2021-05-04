using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearHelpDesk.Domain.ValueObject
{
    public class Phones : BaseValueObject
    {
        public Phones(string phone, string cellPhone)
        {

            Phone = phone;
            CellPhone = cellPhone;


            AddNotifications(new Contract()
                                .Requires()
                                .HasMinLen(Phone, 8, "Email.Phone", "Telefone inválido")
                                .HasMaxLen(Phone, 14, "Email.CellPhone", "Celular inválido")
                                .HasMinLen(CellPhone, 8, "Email.Phone", "Telefone inválido")
                                .HasMaxLen(CellPhone, 14, "Email.CellPhone", "Celular inválido"));
        }

        [Required(ErrorMessage = "Este campo é obrigátorio")]
        [MaxLength(14, ErrorMessage = "Este campo deve conter entre 8 e 14 caracteres")]
        [MinLength(8, ErrorMessage = "Este campo deve conter entre 8 e 14 caracteres")]
        public string Phone { get; private set; }

        [Required(ErrorMessage = "Este campo é obrigátorio")]
        [MaxLength(14, ErrorMessage = "Este campo deve conter entre 8 e 14 caracteres")]
        [MinLength(8, ErrorMessage = "Este campo deve conter entre 8 e 14 caracteres")]
        public string CellPhone { get; private set; }

    }
}
