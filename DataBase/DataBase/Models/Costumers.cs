using System;
using System.Collections.Generic;

namespace DataBase.Models
{

    public  class costumers
    {
        
        public int costumers_ID { get; set; }
        public string First_Name { get; set; }
        public string last_Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone_Number { get; set; }
        public ICollection<Address_costumers> Address { get; set; }


    }
}
