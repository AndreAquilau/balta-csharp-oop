using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Generic;

public class Program
{
    public static void Main(string[] args)
    {
        var test = new Test<IList<int>, int, string>();

        test.Matriz = new List<int>() { 1, 2, 3, 4, 5 };

        foreach (var row in test.Matriz)
        {
            Console.WriteLine(row);
        }
    }

}

public class Test<T, B, Y>
    where T : IList<B>
{
    public Test()
    {

    }

    public T? Matriz { get; set; }
    public Y? TestProp { get; set; }

    public D TestMethod<D>(D list)
        where D : IList<int>
    {
        return list;
    }
}