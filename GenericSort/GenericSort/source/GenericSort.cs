namespace GenericSort;

public static class GenericSort
{
    // Обычный BubbleSort с возможностью выбора функции сравнения
    public static IEnumerable<T> GenericBubbleSort<T>(IEnumerable<T> array) where T : IComparable
    {
        T[] sorted = array.ToArray();
        if (sorted.Length > 1)
        {
            bool swapFlag = true;
            while (swapFlag)
            {
                swapFlag = false;
                for (int i = 1; i < sorted.Length; i++)
                {
                    T current = sorted[i];
                    T prev = sorted[i - 1];
                    if (current.CompareTo(prev) < 0)
                    {
                        sorted[i - 1] = current;
                        sorted[i] = prev;
                        swapFlag = true;
                    }
                }
            }
        }

        return sorted;
    }

    public static IEnumerable<T> GenericBubbleSort<T>(IEnumerable<T> array, Func<T, T, int> compareFunc)
    {
        T[] sorted = array.ToArray();
        if (sorted.Length > 1)
        {
            bool swapFlag = true;
            while (swapFlag)
            {
                swapFlag = false;
                for (int i = 1; i < sorted.Length; i++)
                {
                    T current = sorted[i];
                    T prev = sorted[i - 1];
                    if (compareFunc(current, prev) < 0)
                    {
                        sorted[i - 1] = current;
                        sorted[i] = prev;
                        swapFlag = true;
                    }
                }
            }
        }

        return sorted;
    }
    
    public static void PrintIt<T>(IEnumerable<T> array)
    {
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}