// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 修正: ジェネリック制約を削除し、正しいインスタンス化方法に修正
MyClass<string> test1 = new MyClass<string>("test");
test1.MyMethod();
MyClass<int> test2 = new MyClass<int>(10);
test2.MyMethod();

string str = "aaaa";
// 修正: ジェネリック型引数には型名を直接指定する必要があります
MyClass<string> test3 = new MyClass<string>(str);
Console.WriteLine("type = " + str.GetType());
test3.MyMethod();
