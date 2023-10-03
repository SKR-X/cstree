using ConsoleApp1;
using System.Collections;

internal class Tree<T>: IEnumerable where T:IComparable<T>
{
    Node<T> root;

    public Tree(T v)
    {
        root = new(v);
    }

    public void Add(T v)
    {
        root.Add(v);
    }

    public IEnumerator GetEnumerator()
    {
        for (int i = 0; i < 10; i+=2)
        {
            yield return i;
        }
    }

    public void Print()
    {
        root.Print();
    }
}
