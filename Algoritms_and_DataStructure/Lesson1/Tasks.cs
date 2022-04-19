namespace Algoritms_and_DataStructure.Lesson1;

public class Tasks
{
    //Task1
    public void Function()
    {
        int.TryParse(Console.ReadLine(), out int number);
        int d = 0;
        int i = 2;
        if (i < number)
        {
            if (number % i == 0)
            {
                d++;
            }
            else
            {
                i++;
            }
        }
        else
        {
            if (d == 0)
            {
                Console.WriteLine("Простое");
            }
            else
            {
                Console.WriteLine("Не простое");
            }
        }
    }
        
    //Task2 - O(N3)

    //Task3
    public int Fibonacci(int n)
    {
        if (n == 0 || n == 1) return n;

        return Fibonacci(n - 2) + Fibonacci(n - 1);
    }

    public int Fibonacci2(int n)
    {
        int result = 0;
        int b = 1;
        int tmp;
 
        for (int i = 0; i < n; i++)
        {
            tmp = result;
            result = b;
            b += tmp;
        }
 
        return result;

    }
    }
    