
using System.ComponentModel.DataAnnotations;
namespace TestApi.API.Models
{
    public class Value
    {
        
        [Key]
        public int MyProperty { get; set; }
       
        public string Name { get; set; }

    }
}