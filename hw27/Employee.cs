namespace hw27;

public class Employee : IComparable<Employee>
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Birthyear { get; set; }
    public int Salary { get; set; }

    public Employee(string name, string surname, int birthyear, int salary)
    {
        Name = name;
        Surname = surname;
        Birthyear = birthyear;
        Salary = salary;
    }

    public int CompareTo(Employee? other)
    {
        if (other == null) return 1;
        return String.Compare(Name, other.Name);
    }
}