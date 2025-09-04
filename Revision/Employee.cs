namespace Revision;

public struct Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }

    override public string ToString()
    {
        return $"Employee(Id: {Id}, Name: {Name}, Salary: {Salary})";
    }

    public static bool operator ==(Employee emp1, Employee emp2)
    {
        return emp1.Id == emp2.Id && emp1.Name == emp2.Name && emp1.Salary == emp2.Salary;
    }

    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2);
    }
    // public override bool Equals(object? obj)
    // {
    //     return obj is Employee employee &&
    //            Id == employee.Id &&
    //            Name == employee.Name &&
    //            Salary == employee.Salary;
    // }
}