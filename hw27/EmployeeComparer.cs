namespace hw27;

public class EmployeeComparer : IComparer<Employee>
{
    private string _type;

    public EmployeeComparer(string type)
    {
        _type = type;
    }
    
    public int Compare(Employee? x, Employee? y)
    {
        switch (_type)
        {
            case "name":
                return String.Compare(x.Name, y.Name);
            
            case "surname":
                return String.Compare(x.Surname, y.Surname);
            
            case "birthyear":
                if (x.Birthyear > y.Birthyear)

                    return 1;

                if (x.Birthyear < y.Birthyear)

                    return -1;

                return 0;
            
            case "salary":
                if (x.Salary > y.Salary)

                    return -1;

                if (x.Salary < y.Salary)

                    return 1;

                return 0;
            
            default:
                return 0;
        }
    }
}