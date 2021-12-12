using DataBase.Models;
using Logic_Layer.DataAccess.Access;
using Logic_Layer.Encrypt;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Layer.Log_in
{
    public class LogIn_customers : Ilogin<customerss>
    {
        public UnitOfWork_customers customers { get; private set; }

        public LogIn_customers()
        {
            this.customers = new UnitOfWork_customers();
        }

        public async Task<customerss> LogInAsync(string Email, string password)
        {
            try
            {

                return await customers.customers.GetOneByCondition(i => i.Email == Email && i.Password == Enscryption(password, Email));

            }

            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> ChackIfExsistsAsync(string Email)
        {
            try
            {

                return await customers.customers.GetOneByCondition(i => i.Email == Email) != null;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task RegistarAsync(string streetname, int housenumber, int apt, int zipcode, string city, string first, string last, DateTime Birth, string Pass, string phone, bool manager, string Email)
        {
            await customers.customers.Addnewcustomers(first, last, Birth, Email, Enscryption(Pass, Email), phone, customers.addresscustomers.AddNewAddressAsync(streetname, housenumber, apt, zipcode, city));
            await customers.CompleteAsync();

        }

        public string Enscryption(string password, string salt)
        {
            return new ToHash().HashString(password, salt);
        }

        public async Task ChangePasswordasync(string Email, string newpass)
        {
            try
            {
                

                    await customers.customers.UpdatePasswordAsync(Email, Enscryption(newpass, Email));

                
                

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
