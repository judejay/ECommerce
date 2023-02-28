using easygroceries.Data;

namespace easygroceries.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Customer> Customers { get; }
        IGenericRepository<Product> Products { get; }
        IGenericRepository<PurchaseOrder> PurchaseOrders { get; }
        Task Save();

    }
}
