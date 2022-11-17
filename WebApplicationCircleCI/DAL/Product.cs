using System.ComponentModel.DataAnnotations;

namespace WebApplicationCircleCI.DAL
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; } = null!;
    }
}
