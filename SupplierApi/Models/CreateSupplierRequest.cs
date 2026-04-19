namespace SupplierApi.Models
{
    public class CreateSupplierRequest
    {
        public int Code { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? TelephoneNo { get; set; }

    }
}
