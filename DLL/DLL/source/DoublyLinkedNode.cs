using System.Runtime.CompilerServices;

namespace DLL;

public class DoublyLinkedNode<T>
{
    private T data;
    private DoublyLinkedNode<T> prev;
    private DoublyLinkedNode<T> next;

    public DoublyLinkedNode(T data)
    {
        this.data = data;
    }

    public T getData()
    {
        return data;
    }

    public DoublyLinkedNode<T> getPrev()
    {
        return prev;
    }

    public DoublyLinkedNode<T> getNext()
    {
        return next;
    }

    public void setData(T data)
    {
        this.data = data;
    }

    public void setPrev(DoublyLinkedNode<T> prev)
    {
        this.prev = prev;
    }

    public void setNext(DoublyLinkedNode<T> next)
    {
        this.next = next;
    }
}