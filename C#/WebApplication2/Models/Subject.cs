using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace WebApplication2.Models
{

    [Table("Subjects")]
    public class Subject
    {
        [Display(Name = "Subject ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string SubjectId { get; set; }
        [Display(Name ="Name Of Subject")]
        [Required]
        public string SubjectName { get; set; }

        #region Navigation Propertyes to the department Model

        [Display(Name ="DepartmentName")]

        [Required]
        [ForeignKey(nameof(Subject.Department))]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }
        #endregion
    }
}
