using SupplierApi.Entities;
using SupplierApi.Models;
using SupplierApi.Repositories;

namespace SupplierApi.Services;

public class SupplierService : ISupplierService
{
    private readonly ISupplierRepository _repository;

    public SupplierService(ISupplierRepository repository)
    {
        _repository = repository;
    }

    public async Task AddSupplierAsync(CreateSupplierRequest request)
    {
        Supplier supplier = new Supplier
        {
            Code        = request.Code,
            Name        = request.Name,
            TelephoneNo = request.TelephoneNo
        };

        await _repository.AddSupplierAsync(supplier);
    }

    public async Task<SupplierResponse?> GetSupplierByNameAsync(string companyName)
    {
        Supplier? supplier = await _repository.GetSupplierByNameAsync(companyName);
        if (supplier == null) return null;

        return new SupplierResponse
        {
            Code        = supplier.Code,
            Name        = supplier.Name,
            TelephoneNo = supplier.TelephoneNo
        };
    }
}