namespace WebShop.Models
{
    public class Category : BaseModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public virtual List<Product>? Products { get; set; }
    }
}
