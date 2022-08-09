using Prak_7;


Listik<int> list1 = new Listik<int>();
Listik<int> list2 = new Listik<int>();
int[] arr2 = new int[] { 1, 2, 3, 4 };
list2.AddRange(arr2);


Console.Write("Before Add: ");
foreach (var item in list1)
{
    Console.Write(item + " ");
}
Console.WriteLine(Environment.NewLine + $"Capacity = {list1.Capacity}");


list1.Add(3);
list1.Add(9);
Console.Write(Environment.NewLine + "After Add: ");
foreach (var item in list1)
{
    Console.Write(item + " ");
}
Console.WriteLine(Environment.NewLine + $"Capacity = {list1.Capacity}");


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


Console.WriteLine(Environment.NewLine + $"Index of 8 is {list1.IndexOf(8)}");
Console.WriteLine($"Index of 79 is {list1.IndexOf(0)}");
Console.WriteLine();


list1.Remove(1);
Console.Write("After Remove first element: ");
foreach (var item in list1)
{
    Console.Write(item + " ");
}
Console.WriteLine(Environment.NewLine + $"Capacity = {list1.Capacity}");


list1.RemoveAll(7);
Console.Write(Environment.NewLine + "After RemoveAll(7): ");
foreach (var item in list1)
{
    Console.Write(item + " ");
}
Console.WriteLine(Environment.NewLine + $"Capacity = {list1.Capacity}");


list1.Reverse();
Console.Write(Environment.NewLine + "After Reverse: ");
foreach (var item in list1)
{
    Console.Write(item + " ");
}
Console.WriteLine(Environment.NewLine + $"Capacity = {list1.Capacity}");


list1.Clear();
Console.Write(Environment.NewLine + "After Clear: ");
foreach (var item in list1)
{
    Console.Write(item + " ");
}
Console.WriteLine(Environment.NewLine + $"Capacity = {list1.Capacity}");

//

//var stream = File.OpenRead(@"C:\Users\R3-D3\source\repos\Prak 7\Prak 7\Listik.cs");
//stream.Dispose();
//Console.WriteLine(stream.CanRead);

//Foo();

//void Foo()
//{
//    var test = new Test();
//    test.Foo();
//    Console.WriteLine(test._list.Count);
//}

//class Test
//{
//    public List<int> _list;

//    public void Foo()
//    {
//        _list = new List<int>();
//        var list = _list;
//    }
//}