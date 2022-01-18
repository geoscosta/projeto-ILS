using System;
using System.Collections.Generic;

namespace ILS.Domain.Entities
{
    public class User : Base {
        public string Name { get; private set; }
        public string Cpf { get; private set; }
        public DateTime BirthDate { get; private set; }

        public User(string name, string cpf, DateTime birthDate)
        {
            Name = name;
            Cpf = cpf;
            BirthDate = birthDate;
            _errors = new List<string>();
        }

        public void ChangeUser(string name, string cpf, DateTime birthDate){
            Name = name;
            Cpf = cpf;
            BirthDate = birthDate;
        }

        public override bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}