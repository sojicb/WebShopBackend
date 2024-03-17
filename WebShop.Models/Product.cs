namespace WebShop.Models
{
	public class Product : BaseModel
	{
        public Guid Id { get; set; }
        public string? SerialNumber { get; set; }
        public string? Name { get; set; }
        public string? Price { get; set; }
        public string? Color { get; set; }
        public string? Rating { get; set; }
        public bool InStock { get; set; }
        public string? Description { get; set; }
        public int Units { get; set; }
        public Guid? CategoryId { get; set; }
        public virtual Category? Category { get; set; }
        public virtual List<Tag>? Tags { get; set; }
    }
}
