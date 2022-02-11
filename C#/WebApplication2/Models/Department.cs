using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.Models
{
    [Table("Departments")]
    public class Department
    {
       
        
        
            /* crate table [Departments]
             ([DepartmentId] int not null identity(1,1)
            ,[DepartmentName] varchar(100) not null
            ,constant[pk_Departments}
             )
              */
            [Display(Name ="Department ID")]
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int DepartmentId { get; set; }
            [Display(Name = "dept name")]

            [Required(ErrorMessage = "{0} can not empty")]

            [StringLength(100, ErrorMessage = "{0} it  not be  more then {1} charector")]
             [MinLength(4, ErrorMessage = "{0} atlisr {1} char")]
        public string DepartmentName { get; set; }

        //#region Navigation properties to the Subject model

        //public ICollection<Product> Products { get; set; }
        //#endregion


        #region Navigation properties to the Subject model

        public ICollection<Subject> Subjects { get; set; }
        #endregion
    }

}

