namespace hw27;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter string: ");
        string? input = Console.ReadLine().MyTrim();
        
        if (input.MyIsNullOrWhiteSpace()) Console.WriteLine("String is empty");
        else
        {
            Console.WriteLine("Enter choice: (1, 2) \n1.Turn uppercase \n2.Turn lowercase");
            string? choice = Console.ReadLine().MyTrim();

            switch (choice)
            {
                case "1":
                    Console.WriteLine(input.MyToUpper());
                    break;
            
                case "2":
                    Console.WriteLine(input.MyToLower());
                    break;
                
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}