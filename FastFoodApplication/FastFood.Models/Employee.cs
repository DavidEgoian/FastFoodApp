using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FastFood.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="ველის შევსება სავალდებულოა")]
        public string Pin { get; set; }

        public override bool Equals(object obj)
        {
            return new EmployeeEqualityComparer().Equals(this, obj as Employee);
        }
        public override int GetHashCode()
        {
            return new EmployeeEqualityComparer().GetHashCode(this);
        }
    }

    public class EmployeeEqualityComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            return x.Pin == y.Pin;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return obj.Id;
        }
    }
}
