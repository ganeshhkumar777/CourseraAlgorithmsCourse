using System;
using CourseEraDSA.Algorithms;
namespace CourseEraDSA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            // var obj = new QuickUnion(5);
            // obj.Union(0,1);
            // obj.Union(2,3);
            // obj.Union(3,4);
            // obj.Union(0,2);
            // obj.IsConnected(0,2);
            // obj.IsConnected(2,4);
            // obj.Print();
           // obj.PrintDepth();

            //  var obj1 = new WeighedQuickUnionFind(10);
            // obj1.Union(3,4);
            // obj1.PrintMaxArray();
            // Console.WriteLine(obj1.find(3));
            // obj1.Union(3,8);
            // obj1.PrintMaxArray();
            // Console.WriteLine(obj1.find(3));
            // obj1.Union(6,5);
            // Console.WriteLine(obj1.find(5));
            // obj1.Union(9,4);
            // Console.WriteLine(obj1.find(3));
            // obj1.Union(2,1);
            // obj1.Union(5,0);
            // obj1.Union(7,2);
            // obj1.Union(6,1);
            // obj1.Union(7,3);
            // Console.WriteLine(obj1.find(3));
            // // obj1.PrintInput();
            // // obj1.PrintDepth();

        // var obj2=new BinarySearch(4);
        //     obj2.AddItem(1);
        //     obj2.AddItem(3);
        //     obj2.AddItem(5);
        //     obj2.AddItem(6);
        //     Console.WriteLine(obj2.Find(7));

        var obj3=new Percolation(3);
        obj3.open(1,1);
        obj3.open(0,0);
        obj3.open(2,2);
        }
    }
  
}
