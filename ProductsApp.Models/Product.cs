namespace ProductsApp.Models
{
    public class Product
    {
        public Product()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }
        public string PhotoUrl { get; set; } = string.Empty;
    }
}