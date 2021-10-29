using System;

namespace Day10Assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Finding Maximum and Minimum String or 2 for Collinear Program");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the number of names you want to enter");
                    int size = Convert.ToInt32(Console.ReadLine());
                    string[] names = new string[size];
                    Console.WriteLine("Enter the names");
                    Console.WriteLine("Names you entered are :");
                    for (int i = 0; i < size; i++)
                    {
                        names[i] = Convert.ToString(Console.ReadLine());
                    }
                    Console.WriteLine("Names you entered are :");
                    foreach (var name in names)
                    {
                        Console.WriteLine(name);
                    }
                    MinimumMaximum obj = new MinimumMaximum(names, size);
                    obj.MinimumMaximumNames();
                    break;
                case 2:
                    Collinear obj1 = new Collinear();
                    Console.WriteLine("Enter the co-ordinates of points A,B,C");
                    int x1 = Convert.ToInt32(Console.ReadLine());
                    int x2 = Convert.ToInt32(Console.ReadLine());
                    int x3 = Convert.ToInt32(Console.ReadLine());
                    int y1 = Convert.ToInt32(Console.ReadLine());
                    int y2 = Convert.ToInt32(Console.ReadLine());
                    int y3 = Convert.ToInt32(Console.ReadLine());
                    obj1.CollinearABC(x1, x2, x3, y1, y2, y3);
                    break;
                default:
                    Console.WriteLine("Wrong choice");
                    break;
            }

        }
    }
    class MinimumMaximum
    {
        string[] names;
        int size;
        public MinimumMaximum(string[] names, int size)
        {
            this.names = names;
            this.size = size;
        }
        public void MinimumMaximumNames()
        {
            string minimum = names[0];
            string maximum = names[0];

            for (int i = 1; i < size; i++)
            {
                if (names[i].Length > maximum.Length)
                {
                    maximum = names[i];
                }
                if (names[i].Length < maximum.Length)
                {
                    minimum = names[i];
                }

            }
            Console.WriteLine("Name of maximum length is : " + maximum);
            Console.WriteLine("Name of minimum length is : " + minimum);

        }
    }
    class Collinear
    {
        public void CollinearABC(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            int slope1, slope2;

            slope1 = (y2 - y1) / (x2 - x1);
            slope2 = (y3 - y2) / (x3 - x2);
            if (slope1 == slope2)
                Console.WriteLine("A,B,C are Colliner");
            else
                Console.WriteLine("Not Collinear");
        }
    }

}
