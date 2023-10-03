using ConsoleApp1;

Tree<int> tree = new(5);

tree.Add(3);
tree.Add(7);
tree.Add(9);
tree.Add(2);
tree.Add(1);
tree.Add(2);

foreach (var item in tree)
{
    Console.WriteLine(item);
}

Console.ReadKey();
