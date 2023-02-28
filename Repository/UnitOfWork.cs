using easygroceries.Data;
using easygroceries.IRepository;

namespace easygroceries.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;
        public UnitOfWork(DataContext context)
        {
            _context = context;
        }

        private IGenericRepository<Customer> _customers;
        private IGenericRepository<Product> _products;
        private IGenericRepository<PurchaseOrder> _purchaseOrders;


        public IGenericRepository<Customer> Customers => _customers ??= new GenericRepository<Customer>(_context);



        public IGenericRepository<Product> Products => _products ??= new GenericRepository<Product>(_context);

        public IGenericRepository<PurchaseOrder> PurchaseOrders => _purchaseOrders ??= new GenericRepository<PurchaseOrder>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);

        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
