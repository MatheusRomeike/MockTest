using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("M_Employee")]
public class Employee
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}