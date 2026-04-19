using Microsoft.EntityFrameworkCore;
using SupplierApi.Data;
using SupplierApi.Entities;

namespace SupplierApi.Repositories;

public class SupplierRepository : ISupplierRepository
{
    private readonly SupplierContext _context;

    public SupplierRepository(SupplierContext context)
    {
        _context = context;
    }

    public async Task AddSupplierAsync(Supplier supplier)
    {
        await _context.Suppliers.AddAsync(supplier);
        await _context.SaveChangesAsync();
    }

    public async Task<Supplier?> GetSupplierByNameAsync(string companyName)
    {
        return await _context.Suppliers.FirstOrDefaultAsync(s => s.Name.Contains(companyName));
    }

    public async Task<List<Supplier>> SearchSuppliersAsync(string searchTerm)
    {
        return await _context.Suppliers
            .Where(s => s.Name.Contains(searchTerm))
            .ToListAsync();
    }
}