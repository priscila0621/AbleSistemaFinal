using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbleSistemaFinal.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // Puede ser "Admin", "Coordinator" o "Principal"
    }
}
