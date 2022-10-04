
namespace LifeBankAuth.Models
{
    public class Client
    {
        public string Name { get; set; }
        public bool IsCompany { get; set; }
        public CurrencyEnum Currency { get; set; }
    }
}
