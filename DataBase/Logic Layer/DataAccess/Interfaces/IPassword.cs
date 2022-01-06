using System.Threading.Tasks;

namespace Logic_Layer.DataAccess.Interfaces
{
    interface IPassword
    {
        public Task UpdatePasswordAsync(string email, string newpass);
    }
}
