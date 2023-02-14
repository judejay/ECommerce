using easygroceries.Data;

namespace easygroceries.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Customer> Customers { get; }
        IGenericRepository<Grocery> Groceries { get; }
        IGenericRepository<PurchaseOrder> PurchaseOrders { get; }
        Task Save();

    }
}
