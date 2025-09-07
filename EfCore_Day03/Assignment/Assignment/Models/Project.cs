using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; }

        //[Range(minimum: 500000, maximum: 3500000)]
        public decimal Cost { get; set; }
    }
}
