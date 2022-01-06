namespace Logic_Layer.DataAccess.Interfaces
{
    public interface INewAddress<T> where T :class
    {
        public T AddNewAddressAsync(string streetname,int housenumber,int apt,int zipcode,string city);
    }
}
