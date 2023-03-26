namespace CustomerManagment.Web.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; } = default!;
        public PhoneType PhoneType { get; set; }
        public int CustomerId { get; set; }
    }
}
