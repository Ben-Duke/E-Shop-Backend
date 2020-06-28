using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Shop_Backend.Models
{
    public class Credentials
    {
        public string Username { get; set; }


        public string Password { get; set; }

        public override string ToString() {
            return "Username is " + this.Username + "\npass word is " + this.Password ;
        }
    }
}
