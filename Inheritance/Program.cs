// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata;
using System.Threading.Channels;
using Inheritance;
using Inheritance.PersonInfo;

Person p = new Person("name1", "l1", new DateTime(1992, 5, 12));
//Console.WriteLine(p.ToString());
p.Print();
Console.WriteLine();

Student s = new Student("name2", "l2", DateTime.Now.AddYears(-40), "Uni");
s.Print();

Console.WriteLine();

Person p2 = s;
p2.Print();

//random
Random rnd = new Random();
for (int i = 0; i < 10; i++)
{
    var num = rnd.Next(10, 20);
    Console.WriteLine(num);
}

Console.WriteLine("Rectangle");
Rectangle r = new Rectangle(5,4);

var area = r.GetArea();
r.Print();
Console.WriteLine(area);

Console.WriteLine("Circle");
Circle c = new Circle(10);
c.Print();
Console.WriteLine(c.GetArea());


Shape shape = new Circle(20);

Console.WriteLine(shape.GetArea());

AbstractTest abstractTest = new AbstractTest(new Circle(5));
Console.WriteLine(abstractTest.GetArea);

