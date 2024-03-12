namespace WebShop.Models
{
    public class Tag : BaseModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public virtual List<Product>? Products { get; set; }
    }
}
