using FitnessL.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace FitnessL.Controller
{
    public class UserController
    {
        public User User { get;  }
        public UserController(string userName, string genderName,  DateTime birthDate, double weight, double height)
        {
            // make a check
            var gender = new Gender(genderName);
            User = new User(userName, gender, birthDate, weight, height);
        }

       
        
        
        //в будещем создат класс для сохранения
        public void Save()
        {
            var formatter = new BinaryFormatter();
            using(var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                   formatter.Serialize(fs, User);
            }
        }
        public UserController()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                // дессиарилизуем только 1 пользователя нужно предусмотреть это в будущем
                if(formatter.Deserialize(fs) is User user)
                {
                    User = user;
                }
            }
        }

    }
}
