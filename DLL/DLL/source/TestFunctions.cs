using DLL;

string WayToTestData = "/Users/akabynda/RiderProjects/DLL/Tests/test/TestData1.txt";

Char ch = new Char();
DoublyLinkedList<int> list1 = new DoublyLinkedList<int>();
DoublyLinkedList<int> list2 = new DoublyLinkedList<int>();
var rand = new Random();
for (int i = 0; i < 8; i++)
{
    if (rand.Next(0, 4) != 0)
    {
        list1.AddLast(rand.Next(1, 21));
        list2.AddLast(rand.Next(1, 21));
    }
    else
    {
        list1.RemoveNode(rand.Next(1, 21));
        list2.RemoveNode(rand.Next(1, 21));
    }
}

list1.printAll();
Extends<int> list_extend = new Extends<int>(); 
DoublyLinkedList<int> list3 = new DoublyLinkedList<int>();
DoublyLinkedList<int> list4 = new DoublyLinkedList<int>(list_extend.Reverse(list1));
Console.WriteLine();


bool Compare(int a, int b)
{
    return a < b;
}

bool Devider(int a)
{
    return a % 2 == 1;
}