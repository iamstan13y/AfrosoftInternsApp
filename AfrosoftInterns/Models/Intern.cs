using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AfrosoftInterns.Models
{
    public class Intern
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName="nvarchar(250)")]
        [Required(ErrorMessage = "Nyora zita rakakwana!")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }
        [Column(TypeName = "varchar(6)")]
        public string Sex { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Email { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Department { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Specialty { get; set; }
    }
}
