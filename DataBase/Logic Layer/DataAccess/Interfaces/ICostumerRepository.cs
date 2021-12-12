using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Models;

namespace Logic_Layer.DataAccess.Interfaces
{
  public  interface IcostumersRepository : IGenericDataRepository<costumers>
    {
        public Task Addnewcostumers(string first, string last, DateTime Birth, string email, string Pass, string phone, List<Address_costumers> address);
        public Task UpdatePasswordAsync(string email, string newpass);
        
    }
}
