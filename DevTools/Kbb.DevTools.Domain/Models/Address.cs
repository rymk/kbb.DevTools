namespace Kbb.DevTools.Domain.Models
{
    public class Address
    {
        // TODO: flesh these out, i copied over from DB...
        public int AddressID { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public int StateID { get; set; }
        public int CountryID { get; set; }
    }
}
