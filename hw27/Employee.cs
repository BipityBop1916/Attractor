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

class EmployeeContainer : IEnumerable<Employee>
{
    private List<Employee> employees = new List<Employee>();
    
    public List<Employee> Employees { get { return employees; } }

    public IEnumerator<Employee> GetEnumerator()
    {
        return new EmployeeContainerEnumerator(this);
    }
    
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() => GetEnumerator();
}

class EmployeeContainerEnumerator : IEnumerator<Employee>
{
    private EmployeeContainer _container;
    private int _index = -1;
    
    public EmployeeContainerEnumerator(EmployeeContainer container) => _container = container;
    
    public Employee Current => _container.Employees[_index];
    object System.Collections.IEnumerator.Current => Current;

    public bool MoveNext()
    {
        return ++_index < _container.Employees.Count;
    }
    
    public void Reset() => _index = -1;
    
    public void Dispose() { }
}