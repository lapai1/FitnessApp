using FitnessL.Controller;
using System;

namespace FitnessC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует Calorie counter");
            Console.WriteLine("Введите Ваше имя:");
            var name = Console.ReadLine();
            Console.WriteLine("Введите Ваш пол:");
            var gender = Console.ReadLine();
            Console.WriteLine("Введите Вашу дату рождения (типа: DD.MM.YYYY):");
            var birthdate =  DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите Ваш вес:");
            var weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите Ваш рост:");
            var height = double.Parse(Console.ReadLine());

            var userController = new UserController(name, gender, birthdate, weight, height);
            userController.Save();




        }
    }
}
