namespace hw27;

public static class ListSort
{
    private static Random random = new Random();
    
    public static List<T> MySort<T>(this List<T> array) where T : IComparable<T>
    {
        int n = array.Count;

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
        
        return array;
    }

    public static List<T> BogoSort<T>(this List<T> array) where T : IComparable<T>
    {
        bool sorted = false;
            
        while (!sorted)
        {
            int n = array.Count;
            for (int i = n - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
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
        
        return array;
    }
}