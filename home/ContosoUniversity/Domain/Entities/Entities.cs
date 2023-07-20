public class Course
{
    public int Id { get; set; }
    public int Credits { get; set; }
    public string Name { get; set; } = string.Empty;
}

public class Department
{
    public int Id { get; set; }
    public double Budget { get; set; }
    public int InstructorId { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
}

public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateTime HireDate { get; set; }
    public DateTime EnrollmentDate { get; set; }
    public string Address { get; set; } = string.Empty;
    public bool? HasParkingLot { get; set; }
}
