using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    class User
    {
        public int Id { get; set; }              
        public string Login { get; set; }       
        public string Password { get; set; }     
        public string Email { get; set; }       
        public string Phone { get; set; }      
        public string FullName { get; set; }   
        public int Age { get; set; }            
        public string City { get; set; }        
        public DateTime RegisteredAt { get; set; } 
        public bool IsActive { get; set; }      
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User()
            {
                Id = 1,
                Login = "ivan_2024",
                Password = "qwerty123",
                Email = "ivan@mail.ru",
                Phone = "+7 900 123-45-67",
                FullName = "Иванов Иван Иванович",
                Age = 25,
                City = "Москва",
                RegisteredAt = DateTime.Now,
                IsActive = true
            };

            Console.WriteLine($"ID: {user.Id}");
            Console.WriteLine($"Логин: {user.Login}");
            Console.WriteLine($"Email: {user.Email}");
            Console.WriteLine($"ФИО: {user.FullName}");
            Console.WriteLine($"Возраст: {user.Age}");
            Console.WriteLine($"Город: {user.City}");
            Console.WriteLine($"Дата регистрации: {user.RegisteredAt}");
            Console.WriteLine($"Активен: {user.IsActive}");
        }
    }
}
