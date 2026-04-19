using SupplierApi.Entities;

namespace SupplierApi.Repositories
{
    public interface ISupplierRepository
    {
        Task AddSupplierAsync(Supplier supplier);

        Task<Supplier?> GetSupplierByNameAsync(string companyName);

        Task<List<Supplier>> SearchSuppliersAsync(string searchTerm);

    }
}
