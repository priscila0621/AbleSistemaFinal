using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbleSistemaFinal.Models;

namespace AbleSistemaFinal.Dao
{
    public static class UserDao
    {
        public static List<User> Users = new List<User>
        {
            new User { Id = "admin1", Password = "admin123", Role = "Admin" },
            new User { Id = "admin2", Password = "admin456", Role = "Admin" },
            new User { Id = "coord1", Password = "coord123", Role = "Coordinator" },
            new User { Id = "coord2", Password = "coord456", Role = "Coordinator" },
            new User { Id = "principal", Password = "director123", Role = "Principal" }
        };

        public static User Authenticate(string id, string password)
        {
            return Users.Find(user => user.Id == id && user.Password == password);
        }
    }
}
