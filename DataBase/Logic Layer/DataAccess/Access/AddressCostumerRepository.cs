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
    public class AddresscustomersRepository : GenericDataRepository<Address_customerss>, IAddresscustomersRepository
    {
        public AddresscustomersRepository(DbContext context) : base(context)
        {

        }

        public List<Address_customerss> AddNewAddressAsync(string streetname, int housenumber, int apt, int zipcode, string city)
        {
            try
            {
                Address_customerss newAdd = new Address_customerss { Street_Name = streetname, House_Number = housenumber, Apartment_Number = apt, Zipcode = zipcode, City = city };

                return new List<Address_customerss> { newAdd };

            }
            catch (Exception)
            {

                throw new Exception("Cannot Add new Address. ");

            };
        }

        public async Task<IEnumerable<Address_customerss>> GetAddresses_ByCity(string city)
        {
            try
            {
                return await dbSet.Where(c => c.City == city).Include(i=>i.customers).ToListAsync();
            }
            catch (Exception)
            {

                throw new Exception("Problem in Providing the Data");
            }
        }
        public async Task<List<Address_customerss>> GetwithuserAsync()
        {
            return await dbSet.Include(i => i.customers).ToListAsync();
        }


        public async Task UpdateAddressAsync(Address_customerss address)
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
