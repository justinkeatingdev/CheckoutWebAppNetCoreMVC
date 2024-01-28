namespace ShoppingCartCSET4100.Models
{
    public class Customer
    {
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerAddress { get; set; }
        public List<Item> CustomerItems { get; set; }
        public List<string> CustomerItemNames { get; set; }

    }
}

