using SupplierApi.Models;

namespace SupplierApi.Services
{
    public interface ISupplierService
    {
        Task AddSupplierAsync(CreateSupplierRequest request);

        Task<SupplierResponse?> GetSupplierByNameAsync(string companyName);

    }
}
