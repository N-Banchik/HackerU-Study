using Logic_Layer.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using DataBase.Context;

namespace Logic_Layer.DataAccess.Access
{
    public  class UnitOfWork_costumers: IunitOfWork_costumers
    {
        private readonly DbContext context;

        public UnitOfWork_costumers()
        {
            
            this.context = new FactoryDbContext();
            this.brands = new BrandsRepository(context);
            this.category = new CategoryRepository(context);
            this.items = new ItemsRepository(context);
            this.costumers = new costumersRepository(context);
            this.addresscostumers = new AddresscostumersRepository(context);
        }

        public IAddresscostumersRepository addresscostumers { get; private set; }
        public IBrandsRepository brands { get; private set; }
        public ICategoryRepository category { get; private set; }
        public IcostumersRepository costumers { get; private set; }
        public IItemsRepository items { get; private set; }

        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }
        
        public async ValueTask DisposeAsync()
        {
            await DisposeAsync();
        }
    }
}
