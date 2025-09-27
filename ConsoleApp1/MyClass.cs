using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MyClass<T>
{
    public T prop { get; private set; }

    public MyClass(T value)
    {
        prop = value;
    }
    public void MyMethod()
    {
        Console.WriteLine("property : " + prop);
    }
}
