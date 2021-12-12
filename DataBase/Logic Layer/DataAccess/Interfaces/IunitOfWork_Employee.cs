using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Layer.DataAccess.Interfaces
{
    interface IunitOfWork_Employee :IAsyncDisposable
    {
        IAddressEmployeeRepository addressEmployee { get; }
        IAddresscustomersRepository addresscustomers { get; }
        IBrandsRepository brands { get; }
        ICategoryRepository category { get; }
        IEmployeeRepository employee { get; }
        IcustomersRepository customers { get; }
        IItemsRepository items { get; }
        IShiftsRepository shifts { get; }
        IEDIREpository EDI { get; }



        Task CompleteAsync();
        
    }
}
