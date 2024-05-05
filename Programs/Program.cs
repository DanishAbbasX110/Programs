// See https://aka.ms/new-console-template for more information

using Programs;
using Programs.DesignPattern;

Singleton singleton = Singleton.Instance();
singleton.DoSomething();

TestCode obj = new TestCode();
A a = new A();
A b = a;
b.y = 6000;

Console.WriteLine(obj.x);
Console.WriteLine(a.y);

Console.ReadLine();
