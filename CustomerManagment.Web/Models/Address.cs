namespace CustomerManagment.Web.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; } = default!;
        public string City { get; set; } = default!;
        public string State { get; set; } = default!;
        public string ZipCode { get; set; } = default!;
        public AddressType AddressType { get; set; }
        public int CustomerId { get; set; }
    }
}
