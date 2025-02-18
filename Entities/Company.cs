using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Company
    {
        [Key]
        [Column("CompanyId")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "Company name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Company address is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Address is 60 characters.")]
        public string Address { get; set; } = string.Empty;

        public string? Country { get; set; }

        public virtual ICollection<Employee>? Employees { get; set; }
    }
}
