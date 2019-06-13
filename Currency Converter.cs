using System;

namespace Currency_converter
{
    public class Class1

//Build Specifications:
//1. Take in 3 numbers using console.readline()
//2. Convert those inputs into the double or float data type
//3. Calculate the total, average, and the lowest/highest numbers
//4. Properly display the total in the following currency formats: US, Swedish,
//Japanese, and Thai
//5. Only two decimal place should be allowed(or none for Japanese currency).
//● US: $1,923.53
//● Swedish: 1 923,53 kr
//● Japanese: ￥1,924
//● Thai: ฿1,923.53

    static void Main(string[] args)
    {

        for (int i = 0; i < int.length; i++)

            Console.ReadLine();
        {
            Console.WriteLine(
                " number(0) " + "number(1)" + "number(3)" = );
            double number1, number2, number3, number4;

            int total;
            total = number1 + number2 + number3 + number4;
            return total;
        }
        {
            Console.Write("\n\nFunction to calculate the sum of four numbers :\n");
            Console.Write("--------------------------------------------------\n");
            Console.Write("Enter a number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nThe sum of four numbers is : {0} \n", Sum(n1, n2));
        }

        { 
        Console.WriteLine("Enter the first number ");
        a = Console.ReadLine($1923.53);
        Console.WriteLine("Enter in second number: ");
        b = Console.ReadLine(1923, 53 kr);
        Console.WriteLine("Enter in third number: ");
        c = Console.ReadLine(￥1, 924);
        Console.WriteLine("Enter in fourth number: ");
        d = Console.ReadLine(฿1, 923.53);

        Console.WriteLine("The Average Number is: {0}",
                           Convert.ToInt32(a + b + c + d) / 4);
        }   
        Console.ReadKey(); 
    }
}
