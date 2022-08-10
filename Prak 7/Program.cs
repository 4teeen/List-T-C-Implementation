using Prak_7;

Listik<int> list1 = new Listik<int>();
int[] arr2 = new int[] { 1, 2, 3, 4 };
Listik<int> list2 = new Listik<int>(arr2);

Console.Write("Before Add: ");
foreach (var item in list1)
{
    Console.Write(item + " ");
}
Console.WriteLine(Environment.NewLine + $"Capacity = {list1.Capacity}");

//ADD
list1.Add(3);
list1.Add(9);
Console.Write(Environment.NewLine + "After Add: ");
foreach (var item in list1)
{
    Console.Write(item + " ");
}
Console.WriteLine(Environment.NewLine + $"Capacity = {list1.Capacity}");

//ADDRANGE
int[] arr1 = new int[] { 7, 7, 4, 2, 8 };
list1.AddRange(arr1);
Console.Write(Environment.NewLine + "After AddRange(array): ");
foreach (var item in list1)
{
    Console.Write(item + " ");
}
Console.WriteLine(Environment.NewLine + $"Capacity = {list1.Capacity}");



list1.AddRange(list2);
Console.Write(Environment.NewLine + "After AddRange(list2): ");
foreach (var item in list1)
{
    Console.Write(item + " ");
}
Console.WriteLine(Environment.NewLine + $"Capacity = {list1.Capacity}");

Console.WriteLine(Environment.NewLine + $"Capacity = {list1.Capacity}");
//INDEXOF
Console.WriteLine(Environment.NewLine + $"Index of 8 is {list1.IndexOf(8)}");
Console.WriteLine($"Index of 79 is {list1.IndexOf(0)}");
Console.WriteLine();

//INDEX
Console.WriteLine($"Second element is {list1[2]}");
Console.WriteLine();

//REMOVE
list1.Remove(10);
Console.Write("After Remove first element: ");
foreach (var item in list1)
{
    Console.Write(item + " ");
}
Console.WriteLine(Environment.NewLine + $"Capacity = {list1.Capacity}");

//REMOVEALL
list1.RemoveAll(7);
Console.Write(Environment.NewLine + "After RemoveAll(7): ");
foreach (var item in list1)
{
    Console.Write(item + " ");
}
Console.WriteLine(Environment.NewLine + $"Capacity = {list1.Capacity}");

//REVERSE>
list1.Reverse();
Console.Write(Environment.NewLine + "After Reverse: ");
foreach (var item in list1)
{
    Console.Write(item + " ");
}
Console.WriteLine(Environment.NewLine + $"Capacity = {list1.Capacity}");

//CLEAR
list1.Clear();
Console.Write(Environment.NewLine + "After Clear: ");
foreach (var item in list1)
{
    Console.Write(item + " ");
}
Console.WriteLine(Environment.NewLine + $"Capacity = {list1.Capacity}");

