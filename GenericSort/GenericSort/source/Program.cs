
using static GenericSort.GenericSort;

var rand = new Random();
int[] arr = new int[10];
for (int i = 0; i < 10; i++)
{
    arr[i] = rand.Next(1, 50);
}
PrintIt(arr);
Console.WriteLine();
PrintIt(GenericBubbleSort(arr));