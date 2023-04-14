using System.ComponentModel.DataAnnotations;

namespace _06Repository.Models
{
    public class Article
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
