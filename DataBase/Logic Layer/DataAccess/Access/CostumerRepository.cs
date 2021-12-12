using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Models;
using Logic_Layer.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Logic_Layer.DataAccess.Access
{
    public class customersRepository : GenericDataRepository<customerss>, IcustomersRepository, IPassword
    {
        public customersRepository(DbContext context) : base(context)
        {

        }

        public async Task Addnewcustomers(string first, string last, DateTime Birth, string email, string Pass, string phone, List<Address_customerss> address)
        {
            try
            {
                customerss Toadd = new customerss { First_Name = first, last_Name = last, Birthdate = Birth, Email = email, Password = Pass, Phone_Number = phone, Address = address };

                await base.Add(Toadd);




            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task UpdatePasswordAsync(string Email, string newpass)
        {
            try
            {

                customerss user = await GetOneByCondition(i => i.Email == Email);
                user.Password = user.Password != newpass ? newpass : throw new Exception("Password cannot be the same");
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
