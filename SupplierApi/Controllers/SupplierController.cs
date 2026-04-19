using Microsoft.AspNetCore.Mvc;
using SupplierApi.Models;
using SupplierApi.Services;

namespace SupplierApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SuppliersController : ControllerBase
{
    private readonly ISupplierService _service;

    public SuppliersController(ISupplierService service)
    {
        _service = service;
    }

    // POST: api/suppliers
    [HttpPost]
    public async Task<IActionResult> AddSupplier([FromBody] CreateSupplierRequest request)
    {
        await _service.AddSupplierAsync(request);
        return CreatedAtAction(nameof(GetSupplierByName), new { companyName = request.Name }, request);
    }

    // GET: api/suppliers?search=CompanyName
    [HttpGet]
    public async Task<ActionResult<SupplierResponse>> GetSupplierByName([FromQuery] string search)
    {
        var result = await _service.GetSupplierByNameAsync(search);
        return result == null ? NotFound() : Ok(result);
    }
}