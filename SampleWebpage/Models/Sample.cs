using System.ComponentModel.DataAnnotations;

namespace SampleWebpage.Models
{
    public class Sample
    {
     [Key]
        public int ID { get; set; }
        public string  Name { get; set; }
        public string Address { get; set; }
        public string  EmailID { get; set; }
    }
}
