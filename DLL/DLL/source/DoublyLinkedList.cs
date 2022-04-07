using System.Collections;

namespace DLL;

public class DoublyLinkedList<T>: IEnumerable<T>
{
    protected DoublyLinkedNode<T> first;
    private DoublyLinkedNode<T> last;
    protected int count;
    protected T[] items;

    public DoublyLinkedList()
    {
        first = null;
        last = null;
        count = 0;
    }
    
    public DoublyLinkedList(T[] array)
    {
        count = array.Length;
        first = new DoublyLinkedNode<T>(array[0]);
        DoublyLinkedNode<T> prev = null;
        DoublyLinkedNode<T> current = first;
        for (int i = 1; i < count; i++)
        {
            current.setNext(new DoublyLinkedNode<T>(array[i]));
            current.setPrev(prev);
            prev = current;
            current = current.getNext();
        }
        current.setNext(null);
        current.setPrev(prev);
        last = current;
    }

    public DoublyLinkedNode<T> getLast()
    {
        return last;
    }
    
    public DoublyLinkedNode<T> getFirst()
    {
        return first;
    }
    
    // Получить узел по номеру
    public DoublyLinkedNode<T> getNode(int i)
    {
        if (i >= 0 && i < count)
        {
            DoublyLinkedNode<T> current = first;
            for (int j = 0; j < i; j++)
            {
                current = current.getNext();
            }

            return current;
        }

        return null;
    }

    public void AddLast(T data)
    {
        DoublyLinkedNode<T> newNode = new DoublyLinkedNode<T>(data);

        if (first == null)
            first = newNode;
        else
        {
            last.setNext(newNode);
            newNode.setPrev(last);
        }

        last = newNode;
        count++;
    }
    
    public void AddLast(DoublyLinkedNode<T> newNode)
    {
        if (first == null)
            first = newNode;
        else
        {
            last.setNext(newNode);
            newNode.setPrev(last);
        }

        last = newNode;
        count++;
    }

    public void AddAfter(DoublyLinkedNode<T> parent, T data)
    {
        if (first == null)
        {
            return;
        }

        DoublyLinkedNode<T> newNode = new DoublyLinkedNode<T>(data);
        DoublyLinkedNode<T> current = parent.getNext();
        parent.setNext(newNode);
        newNode.setPrev(parent);
        if (current == null)
        {
            last = newNode;
            newNode.setNext(null);
        }
        else
        {
            newNode.setNext(current);
            current.setPrev(newNode);
        }
        count++;
    }
    
    public void AddAfter(DoublyLinkedNode<T> parent, DoublyLinkedNode<T> newNode)
    {
        if (first == null)
        {
            return;
        }
        DoublyLinkedNode<T> current = parent.getNext();
        parent.setNext(newNode);
        newNode.setPrev(parent);
        if (current == null)
        {
            last = newNode;
            newNode.setNext(null);
        }
        else
        {
            newNode.setNext(current);
            current.setPrev(newNode);
        }
        count++;
    }

    public void AddBefore(DoublyLinkedNode<T> parent, T data)
    {
        if (first == null)
        {
            return;
        }

        DoublyLinkedNode<T> newNode = new DoublyLinkedNode<T>(data);
        DoublyLinkedNode<T> current = parent.getPrev();
        parent.setPrev(newNode);
        newNode.setNext(parent);
        if (current == null)
        {
            first = newNode;
            newNode.setPrev(null);
        }
        else
        {
            newNode.setPrev(current);
            current.setNext(newNode);
        }
        count++;
    }
    
    public void AddBefore(DoublyLinkedNode<T> parent, DoublyLinkedNode<T> newNode)
    {
        if (first == null)
        {
            return;
        }
        DoublyLinkedNode<T> current = parent.getPrev();
        parent.setPrev(newNode);
        newNode.setNext(parent);
        if (current == null)
        {
            first = newNode;
            newNode.setPrev(null);
        }
        else
        {
            newNode.setPrev(current);
            current.setNext(newNode);
        }
        count++;
    }
    
    public void AddFirst(T data)
    {
        DoublyLinkedNode<T> newNode = new DoublyLinkedNode<T>(data);
        DoublyLinkedNode<T> current = first;
        newNode.setNext(current);
        first = newNode;
        if (count == 0)
            last = first;
        else
            current.setPrev(newNode);
        count++;
    }
    
    public void AddFirst(DoublyLinkedNode<T> newNode)
    {
        DoublyLinkedNode<T> current = first;
        newNode.setNext(current);
        first = newNode;
        if (count == 0)
            last = first;
        else
            current.setPrev(newNode);
        count++;
    }

    public void Clear()
    {
        DoublyLinkedNode<T> current = first;
        for (int i = 1; i < count; i++)
        {
            current.setPrev(null);
            current = current.getNext();
            current.getPrev().setNext(null);
        }
        current = null;
        first = null;
        last = null;
        count = 0;
    }

    public bool Containts(T data)
    {
        DoublyLinkedNode<T> current = first;
        if (count > 0)
        {
            for (int i = 0; i < count; i++)
            {
                if (Equals(current.getData(), data))
                {
                    return true;
                }

                current = current.getNext();
            }
        }
        return false;
    }

    public DoublyLinkedNode<T> Find(T data)
    {
        DoublyLinkedNode<T> current = first;
        for (int i = 0; i < count; i++)
        {
            if (Equals(current.getData(), data))
            {
                return current;
            }
            current = current.getNext();
        }

        return null;
    }
    
    public DoublyLinkedNode<T> FindLast(T data)
    {
        DoublyLinkedNode<T> current = last;
        for (int i = 0; i < count; i++)
        {
            if (Equals(current.getData(), data))
            {
                return current;
            }
            current = current.getPrev();
        }
        return null;
    }

    public bool Equals(Object obj)
    {
        if ((obj == null) || !this.GetType().Equals(obj.GetType()))
        {
            return false;
        }
        else
        {
            DoublyLinkedList<T> p = (DoublyLinkedList<T>) obj;
            DoublyLinkedNode<T> current = first;
            DoublyLinkedNode<T> currentObj = p.first;
            if (p.count == this.count)
            {
                if (this.count > 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (!Equals(current.getData(), currentObj.getData()) ||
                            current.getPrev() != currentObj.getPrev() ||
                            current.getNext() != currentObj.getNext())
                        {
                            return false;
                        }
                        current = current.getNext();
                        currentObj = currentObj.getNext();
                    }

                    return true;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }

    public void RemoveNode(T data)
    {
        DoublyLinkedNode<T> current = first;
        while (current != null)
        {
            if (Equals(current.getData(), data))
            {
                break;
            }

            current = current.getNext();
        }

        if (current != null)
        {
            if (current.getNext() != null)
            {
                current.getNext().setPrev(current.getPrev());
            }
            else
            {
                last = current.getPrev();
            }

            if (current.getPrev() != null)
            {
                current.getPrev().setNext(current.getNext());
            }
            else
            {
                first = current.getNext();
            }

            count--;
        }
    }
    
    public void RemoveNode(DoublyLinkedNode<T> node)
    {
        DoublyLinkedNode<T> current = first;
        while (current != null)
        {
            if (Equals(current, node))
            {
                break;
            }

            current = current.getNext();
        }

        if (current != null)
        {
            if (current.getNext() != null)
            {
                current.getNext().setPrev(current.getPrev());
            }
            else
            {
                last = current.getPrev();
            }

            if (current.getPrev() != null)
            {
                current.getPrev().setNext(current.getNext());
            }
            else
            {
                first = current.getNext();
            }

            count--;
        }
    }

    public void RemoveFirst()
    {
        DoublyLinkedNode<T> current = first.getNext();
        first.setNext(null);
        if (current != null)
        {
            current.setPrev(null);
            first = current;
        }
        else
        {
            first = null;
            last = null;
        }

        count--;
    }

    public void RemoveLast()
    {
        DoublyLinkedNode<T> current = last.getPrev();
        first.setPrev(null);
        if (current != null)
        {
            current.setNext(null);
            last = current;
        }
        else
        {
            first = null;
            last = null;
        }

        count--;
    }

    public int getCount()
    {
        return count;
    }

    public void printAll()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine((i + 1) + ". " + getNode(i).getData());
        }
    }
    
    public IEnumerator<T> GetEnumerator()
    {
        items = new T[count];
        DoublyLinkedNode<T> current = first;
        int i = 0;
        while (current != null)
        {
            items[i] = current.getData();
            i++;
            current = current.getNext();
        }
        return new ListEnumerator<T>(items, count);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}