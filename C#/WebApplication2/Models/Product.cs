using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace WebApplication2.Models
{
    
    [Table("Product")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PId { get; set; } 
        
        [Display(Name = " name of the product")]
        [Required(ErrorMessage ="{0} can not br empty")]
        [StringLength(100 , ErrorMessage = "{0} is required")]
        [MinLength(3)]
        public string PName { get; set; }
         

        [Required(ErrorMessage = "{0} is  empty")]
        [Range(minimum:1,maximum:100,ErrorMessage ="{0 } is need between {1} and {2}")]
        public int Quantity{ get; set; }

        [Required(ErrorMessage = "{0} is  empty")]
        [Range(minimum: 1, maximum: 100000, ErrorMessage = "{0 } is need between {1} and {2}")]
        public int Price { get; set; }

        
    }
}
