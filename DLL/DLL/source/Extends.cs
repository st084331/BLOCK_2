namespace DLL;

public class Extends<T> where T: IComparable<T>
{
    public bool Any<TSource> (IEnumerable<TSource> source)
    {
        var enumerator = source.GetEnumerator();
        return enumerator.MoveNext();
    }

    public bool Any<TSource> (IEnumerable<TSource> source, Func<TSource, Boolean> func)
    {
        var enumerator = source.GetEnumerator();
        while (enumerator.MoveNext())
        {
            Console.WriteLine(enumerator.Current);
            if (func(enumerator.Current))
            {
                return true;
            }
        }
        return false;
    }

    public int Count<TSource> (IEnumerable<TSource> source)
    {
        int count = 0;
        var enumerator = source.GetEnumerator();
        while (enumerator.MoveNext()) count++;
        return count;
    }

    public object ElementAt<TSource>(IEnumerable<TSource> source, Int32 position)
    {
        var enumerator = source.GetEnumerator();
        for (int i = 0; i <= position; i++)
        {
            if (!enumerator.MoveNext())
            {
                return null;
            }
        }
        return enumerator.Current;
    }

    public TSource ElementAtOrDefault<TSource> (IEnumerable<TSource> source, Int32 position)
    {
        var enumerator = source.GetEnumerator();
        for (int i = 0; i <= position; i++)
        {
            if (!enumerator.MoveNext())
            {
                return default;
            }
        }
        return enumerator.Current;
    }

    public TSource First<TSource>(IEnumerable<TSource> source)
    {
        var enumerator = source.GetEnumerator();
        enumerator.MoveNext();
        return enumerator.Current;
    }

    public TSource Last<TSource>(IEnumerable<TSource> source)
    {
        var enumerator = source.GetEnumerator();
        TSource prev = default;
        while (enumerator.MoveNext())
        {
            prev = enumerator.Current;
        }
        return prev;
    }

    public TSource LastOrDefault<TSource>(IEnumerable<TSource> source)
    {
        int count = Count(source);
        if (count > 0)
        {
            var enumerator = source.GetEnumerator();
            TSource prev = default;
            while (enumerator.MoveNext())
            {
                prev = enumerator.Current;
            }

            return prev;
        }
        return default;
    }

    
    public TSource FirstOrDefault<TSource>(IEnumerable<TSource> source)
    {
        int count = Count(source);
        if (count > 0)
        {
            var enumerator = source.GetEnumerator();
            enumerator.MoveNext();
            return enumerator.Current;
        }
        return default;
    }
    
    public TSource Max<TSource> (IEnumerable<TSource> source, Func<TSource, TSource, bool> func)
    {
        var enumerator = source.GetEnumerator();
        enumerator.MoveNext();
        TSource max = enumerator.Current;
        while (enumerator.MoveNext())
        {
            if (func(max, enumerator.Current))
            {
                max = enumerator.Current;
            }
        }

        return max;
    }
    
    public TSource Min<TSource> (IEnumerable<TSource> source, Func<TSource, TSource, bool> func)
    {
        var enumerator = source.GetEnumerator();
        enumerator.MoveNext();
        TSource min = enumerator.Current;
        while (enumerator.MoveNext())
        {
            if (!func(min, enumerator.Current))
            {
                min = enumerator.Current;
            }
        }

        return min;
    }

    public TSource[] Reverse<TSource>(IEnumerable<TSource> source)
    {
        int count = Count(source);
        TSource[] reversed = new TSource[count];
        var enumerator = source.GetEnumerator();
        int k = 0;
        for (int j = count; j > 0; j--)
        {
            for (int i = 0 ; i < j; i++)
            {
                enumerator.MoveNext();
            }
            reversed[k] = enumerator.Current;
            enumerator.Reset();
            k++;
        }
        return reversed;
    }
}