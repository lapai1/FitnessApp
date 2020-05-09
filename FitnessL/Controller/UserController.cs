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
        public UserController(string name, User user)
        {
            User = user ?? throw new ArgumentNullException("Пользователь не может быть равен Null", nameof(user));
        }

        public UserController(string name, string gender, DateTime birthdate, double weight, double height)
        {
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
        public User Load()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                // дессиарилизуем только 1 пользователя нужно предусмотреть это в будущем
                if(formatter.Deserialize(fs) is User user)
                {
                    return user;
                }
                else
                {
                    throw new FileLoadException("Не удалось получить данные пользователя из файла", "users.dot");
                }
                // вместо эксепштна можно кидать null тем самым сократить код
            }
        }

    }
}
