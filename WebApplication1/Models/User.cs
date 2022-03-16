namespace WebApplication1.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Email { get; set; } = string.Empty;

        public virtual List<Order>? Orders { get; set; }
    }
}
