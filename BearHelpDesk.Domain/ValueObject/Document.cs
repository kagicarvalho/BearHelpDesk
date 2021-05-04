using BearHelpDesk.Domain.Enums;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearHelpDesk.Domain.ValueObject
{
    public class Document : BaseValueObject
    {
        public Document(string number, EDocumentType type)
        {

            Number = number;
            Type = type;

            AddNotifications(new Contract().Requires().IsTrue(Validate(), "Document.Number", "Documento Inválido"));
        }

        [Required(ErrorMessage = "Este campo é obrigátorio")]
        [MaxLength(14, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(11, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        public string Number { get; private set; }
        public EDocumentType Type { get; set; }

        private bool Validate()
        {
            if (Type == EDocumentType.cnpj && Number.Length == 14)
                return true;

            if (Type == EDocumentType.cpf && Number.Length == 11)
                return true;

            return false;
        }
    }
}
