using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Models;

namespace Logic_Layer.DataAccess.Interfaces
{
  public  interface IcustomersRepository : IGenericDataRepository<customerss>
    {
        public Task Addnewcustomers(string first, string last, DateTime Birth, string email, string Pass, string phone, List<Address_customerss> address);
        public Task UpdatePasswordAsync(string email, string newpass);
        
    }
}
