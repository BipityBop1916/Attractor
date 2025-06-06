namespace hw27.ex1;

public class ArrayTool<T> where T : IComparable<T>
{
    private static Random _rng = new Random();
    
    public static void Sort(T[] array)
    {
        int n = array.Length;
        
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j].CompareTo(array[j + 1]) > 0)
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                }
            }
        }
    }

    public static void Reverse(T[] array)
    {
        int n = array.Length;

        for (int i = 0; i < n / 2; i++)
        {
            (array[i], array[n - i - 1]) = (array[n - i - 1], array[i]);
        }
    }
    
    public static void BogoSort(T[] array)
    {
        bool sorted = false;
            
        while (!sorted)
        {
            int n = array.Length;
            for (int i = n - 1; i > 0; i--)
            {
                int j = _rng.Next(i + 1);
                (array[i], array[j]) = (array[j], array[i]);
            }
            
            sorted = true;

            for (int i = 0; i < n - 1; i++)
            {
                if (array[i].CompareTo(array[i + 1]) > 0)
                {
                    sorted = false;
                    break;
                }
            }
        }
    }
}