using System.Collections.Generic;

namespace Logic_Layer.DataAccess.Interfaces
{
    public interface INewAddresscostumers<T> where T :class
    {
        public List<T> AddNewAddressAsync(string streetname,int housenumber,int apt,int zipcode,string city);
    }
}
