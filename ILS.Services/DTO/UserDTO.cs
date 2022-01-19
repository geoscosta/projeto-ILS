using System;

namespace ILS.Services.DTO
{
    public class UserDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public DateTime BirthDate { get; set; }

        public UserDTO()
        { }

        public UserDTO(long id, string name, string cpf, DateTime birthDate)
        {
            Id = id;
            Name = name;
            Cpf = cpf;
            BirthDate = birthDate;
        }
    }
}