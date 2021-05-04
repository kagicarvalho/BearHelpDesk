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
    public class Address : BaseEntity
    {
        public Address(ETypeAddress typeAddress, string street, string complement, string number, string district, string city, string state, string country)
        {
            TypeAddress = typeAddress;
            Street = street;
            Complement = complement;
            Number = number;
            District = district;
            City = city;
            State = state;
            Country = country;


            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(Street, 3, "Street", "Nome da rua tem que ter no minimo 3 caracateres")
                .HasMaxLen(Street, 60, "Street", "Nome da rua tem que ter no maximo 60 caracateres")
                .HasMinLen(Complement, 3, "Complement", "O complemento tem que ter no minimo 3 caracateres")
                .HasMaxLen(Complement, 60, "Complement", "O complemento tem que ter no maximo 60 caracateres")
                .HasMinLen(Number, 1, "Number", "O numero tem que ter no minimo 1 caracateres")
                .HasMaxLen(Number, 60, "Number", "O numero tem que ter no maximo 60 caracateres")
                .HasMinLen(District, 3, "District", "O nome do bairro tem que ter no minimo 3 caracateres")
                .HasMaxLen(District, 60, "District", "O nome do bairro tem que ter no maximo 60 caracateres")
                .HasMinLen(City, 3, "City", "O nome da cidade tem que ter no minimo 3 caracateres")
                .HasMaxLen(City, 60, "City", "O nome da cidade tem que ter no maximo 60 caracateres")
                .HasMinLen(State, 2, "State", "O nome do Estado tem que ter no minimo 3 caracateres")
                .HasMaxLen(State, 60, "State", "O nome do Estado tem que ter no maximo 60 caracateres")
                .HasMinLen(Country, 3, "Country", "O nome do Pais tem que ter no minimo 3 caracateres")
                .HasMaxLen(Country, 60, "Country", "O nome do Pais tem que ter no maximo 60 caracateres"));

        }

        public ETypeAddress TypeAddress { get; private set; }

        [Required(ErrorMessage = "Este campo é obrigátorio")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        public string Street { get; private set; }

        [Required(ErrorMessage = "Este campo é obrigátorio")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        public string Complement { get; private set; }

        [Required(ErrorMessage = "Este campo é obrigátorio")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(1, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        public string Number { get; set; }

        [Required(ErrorMessage = "Este campo é obrigátorio")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        public string District { get; private set; }

        [Required(ErrorMessage = "Este campo é obrigátorio")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        public string City { get; private set; }

        [Required(ErrorMessage = "Este campo é obrigátorio")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(2, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        public string State { get; private set; }

        [Required(ErrorMessage = "Este campo é obrigátorio")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        public string Country { get; private set; }
    }
}
