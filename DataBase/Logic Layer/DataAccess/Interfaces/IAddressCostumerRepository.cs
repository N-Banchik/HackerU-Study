using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Models;

namespace Logic_Layer.DataAccess.Interfaces
{
    public interface IAddresscustomersRepository : IGenericDataRepository<Address_customerss>, INewAddresscustomers<Address_customerss>
    {
        public Task<IEnumerable<Address_customerss>> GetAddresses_ByCity(string city);
        public Task UpdateAddressAsync(Address_customerss address);
        public Task<List<Address_customerss>> GetwithuserAsync();

    }
}
