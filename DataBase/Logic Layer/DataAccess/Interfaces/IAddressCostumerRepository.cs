using System.Collections.Generic;
using System.Threading.Tasks;
using DataBase.Models;

namespace Logic_Layer.DataAccess.Interfaces
{
    public interface IAddresscostumersRepository : IGenericDataRepository<Address_costumers>, INewAddresscostumers<Address_costumers>
    {
        public Task<IEnumerable<Address_costumers>> GetAddresses_ByCity(string city);
        public Task UpdateAddressAsync(Address_costumers address);
        public Task<List<Address_costumers>> GetwithuserAsync();

    }
}
