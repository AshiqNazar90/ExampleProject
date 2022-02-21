using System.ComponentModel.DataAnnotations;

namespace SampleWebpage.Models
{
    public class Collect
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public string Phonenumber { get; set; }
    }
}
