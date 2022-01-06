using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataBase.Models;
using Logic_Layer.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Logic_Layer.DataAccess.Access
{
    public class AddresscostumersRepository : GenericDataRepository<Address_costumers>, IAddresscostumersRepository
    {
        public AddresscostumersRepository(DbContext context) : base(context)
        {

        }

        public List<Address_costumers> AddNewAddressAsync(string streetname, int housenumber, int apt, int zipcode, string city)
        {
            try
            {
                Address_costumers newAdd = new Address_costumers { Street_Name = streetname, House_Number = housenumber, Apartment_Number = apt, Zipcode = zipcode, City = city };

                return new List<Address_costumers> { newAdd };

            }
            catch (Exception)
            {

                throw new Exception("Cannot Add new Address. ");

            };
        }

        public async Task<IEnumerable<Address_costumers>> GetAddresses_ByCity(string city)
        {
            try
            {
                return await dbSet.Where(c => c.City == city).Include(i=>i.costumers).ToListAsync();
            }
            catch (Exception)
            {

                throw new Exception("Problem in Providing the Data");
            }
        }
        public async Task<List<Address_costumers>> GetwithuserAsync()
        {
            return await dbSet.Include(i => i.costumers).ToListAsync();
        }


        public async Task UpdateAddressAsync(Address_costumers address)
        {
            try
            {

                  dbSet.Update(address);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
