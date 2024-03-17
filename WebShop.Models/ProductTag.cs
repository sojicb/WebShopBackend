namespace WebShop.Models
{
    public class ProductTag : BaseModel
    {
        public Guid Id { get; set; }
        public Guid? TagId { get; set; }
        public Guid? ProductId { get; set; }
    }
}
