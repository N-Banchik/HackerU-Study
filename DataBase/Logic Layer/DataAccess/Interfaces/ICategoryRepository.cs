using System.Threading.Tasks;
using DataBase.Models;

namespace Logic_Layer.DataAccess.Interfaces
{
    public  interface ICategoryRepository :IGenericDataRepository<Categories>
    {
        public Task AddNewCategoryAsync(string Cname, string disc);
       
    }
}
