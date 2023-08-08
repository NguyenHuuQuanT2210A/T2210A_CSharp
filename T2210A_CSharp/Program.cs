using T2210A_CSharp.Demo2;
using System.Collections.Generic;
public class Program
{
    public static void Main1(string[] args)
    {
        Student s = new Student();
        s.name = "Nguyen Van An";
        s.Eat();
        s.Eat("aaa");

        List<Student> listStudents = new List<Student>();
        listStudents.Add(s);
    }

    public static void Main2(string[] args)
    {
        int x = 10;
        float y = 3.14159f;
        double z = 3.14159;

        Console.WriteLine("Result:" + (x + y + z));

        var k = 19;
        //k = "hello world";
        k = 22;

        //var pi = 3.14159;
        var input = Console.ReadLine();
        int inputInt = Convert.ToInt32(input);
        // if (k > 10) ;
        // {

        // }
        // else
        // {

        //  }

        int[] arr = new int[10];
        for (int i = 0; i < arr.Length; i++)
        {
            // arr[i]
        }
        foreach (int ar in arr)
        {
            // ar <=> arr[i]
        }
    }

}