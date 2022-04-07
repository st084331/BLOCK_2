using System.Collections;

namespace DLL;

public class ListEnumerator<T> : IEnumerator<T>
{
    private readonly T[] array;
    private readonly int count;
    private int position;
    private IEnumerator<T> _enumeratorImplementation;

    public ListEnumerator(T[] array, int count)
    {
        this.array = array;
        this.count = count;
        position = -1;
    }

    public void Reset()
    {
        position = -1;
    }

    public T Current
    {
        get
        {
            return array[position];
            
        }
    }

    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }

    public void Dispose()
    {
    }

    public bool MoveNext()
    {
        position++;
        return position < count;
    }
}