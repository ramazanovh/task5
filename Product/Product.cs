namespace Product
{
    public class Product
    {
        private int Id { get; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public Product(int id,string? name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
