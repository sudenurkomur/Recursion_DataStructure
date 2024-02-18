internal class Program
{




    public static void Main(string[] args)
    {
        //Console.WriteLine(sumOf(5));
        int[] array = { 0, 1, 2, 3, 4 };
        Console.WriteLine();
        //displayArray(array, 0, 3);
        Console.WriteLine();
        //displayArray2(array, 0, 3);
        Console.WriteLine();
        displayArray3(array, 0, 3);
        Console.WriteLine();
        string a = "sudenur";
        //function(a);

        int m = (1 + 2) / 2;
        //Console.Write(m);
    }

    public static void function(string str)
    {
        if (str.Length == 0)
        {
            return;
        }
        function(str.Substring(1));
        Console.Write(str[0]);

    }


    // Recursive Methods That Return A Value
    public static int sumOf(int n)
    {
        int sum;
        if (n == 1)
            sum = 1;
        else
        {
            sum = sumOf(n - 1) + n;   //tersten yığın oluyor tree olarak düşün 1+2 3+3 6+4 10+5 olarak gidiyor
                                      //Console.WriteLine(sum);
        }
        return sum;
    }

    //Recursively Processing an Array 1

    public static void displayArray(int[] array, int first, int last)
    {
        Console.Write(array[first] + " ");
        if (first < last)
        {
            displayArray(array, first + 1, last);
        }
    }

    //Recursively Processing an Array 2
    public static void displayArray2(int[] array, int first, int last)
    {
        if (first <= last)
        {
            //last = last - 1;
            displayArray2(array, first, last - 1);
            Console.Write(array[last] + " ");
        }
    }

    //Recursively Processing an Array 3
    public static void displayArray3(int[] array, int first, int last)
    {
        if (first == last)
        {
            Console.Write(array[first] + " ");
        }
        else
        {
            int mid = (first + last) / 2;
            displayArray3(array, first, mid);
            displayArray3(array, mid + 1, last);
        }
    }

}

