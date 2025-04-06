/*
namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[] {50, 40, 30, 20, 10 };
        Console.Write("Array elements are: ");
        for(int i=0; i<arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.ReadLine();
    }
}


namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[] {30, 10, 5, 2, 15};
        Console.Write("Array elements are: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.ReadLine();
    }
}

//Multi dimentional array:
namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        int[,] arr = new int[3, 4] {{10,20,30,40},
                                    {50, 60,70,80},
                                    {90,95,98,99}};
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}

namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        int[,] arr = new int[3, 4] {{5,1,4,7},
                                    {3, 9,5,9},
                                    {2,4,9,7}};
       
        for (int i = 0; i < arr.Length; i++)

        {
            for (int j = 0; j < arr.Length-1; j++)
            {
                if (arr[j] > arr[j+1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
                Console.Write(arr[i, j] + " ");
                
            }
        
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}


using System;

class Program
{
    static void Main()
    {
        int[,] array = {
            {5, 1, 4, 7},
            {3, 9, 5, 9},
            {2, 4, 9, 7}
        };

        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        int size = rows * cols;
        int[] tempArray = new int[size];

        // Flatten the 2D array into 1D
        int index = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                tempArray[index++] = array[i, j];
            }
        }

        // Sort the 1D array
        Array.Sort(tempArray);

        // Refill the 2D array with sorted values
        index = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = tempArray[index++];
            }
        }

        // Display the sorted 2D array
        Console.WriteLine("Sorted 2D Array:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
            
        }
        Console.ReadLine();
    }
}


//Jagged Array:
//10 20
//30
//40 50 60
namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        int[][] a = new int[3][];
        a[0] = new int[] { 10, 20 };
        a[1] = new int[] { 30 };
        a[2] = new int[] { 40, 50, 60 };
        for(int i=0; i<a.Length;i++)
        {
            for(int j=0; j < a[i].Length;j++)
            {
                Console.Write(a[i][j] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}

// 10   20  30
// 40   50
// 60
namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        int[][] a = new int[3][];
        a[0] = new int[] { 10, 20, 30 };
        a[1] = new int[] { 40, 50 };
        a[2] = new int[] { 60 };
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a[i].Length; j++)
            {
                Console.Write(a[i][j] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}

//String Jagged Array:
namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        string[][] a = new string[3][];
        a[0] = new string[] { "Dotnet", "Java", "php"};
        a[1] = new string[] { "SAP"};
        a[2] = new string[] { "C++", "C" };
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a[i].Length; j++)
            {
                Console.Write(a[i][j] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}


// Double Jagged Array:
class Program
{
    static void Main(string[] args)
    {
        double[][] a = new double[3][];
        a[0] = new double[] { 10.5, 20.5 };
        a[1] = new double[] { 30.5 };
        a[2] = new double[] { 40.5, 50.5, 60.5};
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a[i].Length; j++)
            {
                Console.Write(a[i][j] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}

//Swap without using c elemnt:
namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        int[] a = new int[] { 1, 2, 3, 4 };
        int[] b = new int[] { 5, 6, 7, 8 };
        for(int i=0; i<4; i++)
        {
            Console.Write(a[i] + " ");
        }
        Console.WriteLine();
        for (int i = 0; i < 4; i++)
        {
            Console.Write(b[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("After Swap:");
        for(int i=0; i<a.Length; i++)
        {
            (a[i], b[i]) = (b[i], a[i]);
            Console.Write(a[i] + " ");
            
        }
        Console.WriteLine();
        for(int i=0; i<b.Length; i++)
        {
            Console.Write(b[i] + " ");
        }
        Console.ReadLine();
    }
}


//Swap using c element
namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        int[] a = new int[] { 1, 2, 3, 4 };
        int[] b = new int[] { 5, 6, 7, 8 };
        int[] c = new int[a.Length];
        for (int i = 0; i < 4; i++)
        {
            Console.Write(a[i] + " ");
        }
        Console.WriteLine();
        for (int i = 0; i < 4; i++)
        {
            Console.Write(b[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("After Swap:");
        for (int i = 0; i < a.Length; i++)
        {
            (a[i], b[i]) = (b[i], a[i]);
            Console.Write(a[i] + " ");

        }
        Console.WriteLine();
        for (int i = 0; i < b.Length; i++)
        {
            Console.Write(b[i] + " ");
        }
        Console.ReadLine();
    }
}

//WCP to accept 5 employee numbers and store into an array and search with the employee num to find them.
namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        //creating an array
        ulong[] empnos = new ulong[5];
        //accepting the employee numbers to store into an array
        for(int i=0; i<empnos.Length; i++)
        {
            Console.Write("Employee Number:");
            empnos[i] = ulong.Parse(Console.ReadLine());
        }
        Console.WriteLine("\n\n");
        Console.Write("Enter search employee num:");
        ulong find = ulong.Parse(Console.ReadLine());
        int ctr = 0;
        for(int i =0;i<empnos.Length; i++)
        {
            if (find == empnos[i])
            {
                Console.WriteLine("Searching employee is found");
                ctr++;
                break;
            }
        }
        if (ctr == 0)
        {
            Console.WriteLine("Searching Employee not found");
        }
        Console.ReadLine();
    }
}


//search employee name and number:
namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        ulong[] empnos = new ulong[5];
        string[] empname = new string[5];
        for(int i = 0; i<empnos.Length; i++)
        {
            Console.Write("EmpNos:\t");
            empnos[i] = ulong.Parse(Console.ReadLine());
            Console.Write("EmpName:\t");
            empname[i] = Console.ReadLine();
            Console.WriteLine("\n");
        }
        Console.WriteLine("\n\n");
        Console.WriteLine("Enter searching employee Number:");
        ulong find = ulong.Parse(Console.ReadLine());
        int ctr = 0;
        for(int i=0;i<empnos.Length;i++)
        {
            if (find == empnos[i])
            {
                Console.WriteLine("searching employee name is:" + empname[i]);
                ctr++;
            }
        }
        if(ctr==0)
        {
            Console.WriteLine("Searching Employee not found");
        }
        Console.ReadLine();
        
    }
}
*/

namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        //creating an array
        int[] Num = new int[5];
        //accepting the employee numbers to store into an array
        for(int i=0; i<Num.Length; i++)
        {
            Console.Write("Enter Number:");
            Num[i] = int.Parse(Console.ReadLine());
        }
        int find = int.Parse(Console.ReadLine());
        
        Console.ReadLine();
    }
}