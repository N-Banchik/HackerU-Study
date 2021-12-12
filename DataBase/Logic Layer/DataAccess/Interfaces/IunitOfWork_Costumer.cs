using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Layer.DataAccess.Interfaces
{
   public interface IunitOfWork_customers :IAsyncDisposable
    {
        IAddresscustomersRepository addresscustomers { get;  }
        IBrandsRepository brands { get; }
        ICategoryRepository category { get; }
        IcustomersRepository customers { get; }
        IItemsRepository items { get; }

        Task CompleteAsync();
        
    }
}
