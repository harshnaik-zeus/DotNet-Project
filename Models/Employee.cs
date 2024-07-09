using System.ComponentModel.DataAnnotations;

namespace MVCProject.Models;

public class Employee
{
    [Key]
    public string Email { get; set; }

    public string Name { get; set; }

    public string Country { get; set; }

    public string State { get; set; }

    public string City { get; set; }

    public int Number { get; set; }

    public string Addone { get; set; }

    public string Addtwo { get; set; }

    public DateTime Dob { get; set; }

    public int Yearone { get; set; }

    public int Yeartwo { get; set; }

    public int Yearthree { get; set; }

    public int Yearfour { get; set; }

}
