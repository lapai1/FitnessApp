using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessL.Model
{
    [Serializable] 
    public class User
    {
        public string Name { get; }
        public Gender Gender { get; }
        /// <summary>
        /// дата рождения
        /// </summary>
        public DateTime BirthDate { get; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public User(string name, Gender gender, DateTime birthDate, double weight, double height)
        {
            //проверка условий
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым или равным null", nameof(name));
            }
            if (gender == null)
            {
                throw new ArgumentNullException("Пол не может быть пустым или равен null", nameof(gender));
            }
            if (birthDate < DateTime.Parse("01.01.1900") || birthDate >= DateTime.Now)
            {
                throw new ArgumentException("Невозможная дата рождения", nameof(birthDate));
            }
            if (weight <= 0 || weight >= 500)
            {
                throw new ArgumentException("Невозможный вес", nameof(weight));
            }
            if (height <= 30 || height >= 300)
            {
                throw new ArgumentException("Невозможный рост", nameof(height));
            }
            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
