using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employee
    {
        [Key]
        [Column("EmployeeId")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "Employee name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length of the Name is 60 characters")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Age is a required field.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Position is required field.")]
        [MaxLength(20, ErrorMessage = "Maximum length of the Position is 20 characters")]
        public string Position { get; set; } = string.Empty;

        [ForeignKey(nameof(Company))]
        public Guid CompanyId { get; set; }
        public Company? Company { get; set; }
    }
}
