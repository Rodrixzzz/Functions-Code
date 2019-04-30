using System;
using System.Collections.Generic;
namespace Functions_Code.SharedCode.Models
{
    public class User
    {
        public int Id { get; set; }         
        public string Email { get; set; }         
        public string Role {get;set;}
        public DateTime Birthdate {get;set;}
    }
    public static class UsersRepo
    {
        public static List<User> Users = new List<User>();
        static UsersRepo()
        {
            Users.Add(new User()
            {
                Id = 1,
                Email = "rodcejas@gmail.com",
                Role = "Admin",
                Birthdate = new DateTime(1993, 05, 24)
            });
            Users.Add(new User()
            {
                Id = 2,
                Email = "PedroTorres@gmail.com",
                Role = "Vendor",
                Birthdate = new DateTime(1988, 01, 2)
            });
            Users.Add(new User()
            {
                Id = 3,
                Email = "ClaudiaGomez@gmail.com",
                Role = "Customer",
                Birthdate = new DateTime(1984, 08, 12)
            });
        }
        public static List<User> GetAll()
        {
            return UsersRepo.Users;
        }
    }
}