using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Layer.DataAccess.Interfaces
{
   public interface IunitOfWork_costumers :IAsyncDisposable
    {
        IAddresscostumersRepository addresscostumers { get;  }
        IBrandsRepository brands { get; }
        ICategoryRepository category { get; }
        IcostumersRepository costumers { get; }
        IItemsRepository items { get; }

        Task CompleteAsync();
        
    }
}
