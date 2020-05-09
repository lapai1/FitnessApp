using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace FitnessL.Model
{ 
    [Serializable]
    public class Gender
    {
        public string Name { get;}
        public Gender(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Пол не может быть пустым или равен Null", nameof(name));
            }
            Name = name;
        }
            public override string ToString()
        {
            return Name;
        }
    }                          
}
