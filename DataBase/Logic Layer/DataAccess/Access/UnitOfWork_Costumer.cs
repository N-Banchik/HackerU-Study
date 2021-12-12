using Logic_Layer.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Context;

namespace Logic_Layer.DataAccess.Access
{
   public  class UnitOfWork_customers: IunitOfWork_customers
    {
        private readonly DbContext context;

        public UnitOfWork_customers()
        {
            
            this.context = new FactoryDbContext();
            this.brands = new BrandsRepository(context);
            this.category = new CategoryRepository(context);
            this.items = new ItemsRepository(context);
            this.customers = new customersRepository(context);
            this.addresscustomers = new AddresscustomersRepository(context);
        }

        public IAddresscustomersRepository addresscustomers { get; private set; }
        public IBrandsRepository brands { get; private set; }
        public ICategoryRepository category { get; private set; }
        public IcustomersRepository customers { get; private set; }
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
