using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read the text as a string value and calculate the counts of characters 'a', 'o', 'i', 'e' in this text
            #region
            //Console.Write("Input some text: ");
            //string text = Console.ReadLine();
            //int count = 0;


            //foreach (char ch in text)
            //{
            //    count = 0;
            //    for (int i = 0; i < text.Length; i++)
            //    {
            //        if (ch == text[i])
            //        {
            //            count++;
            //        }
            //    }
            //    Console.WriteLine("{0} = {1}", ch, count);
            //}


            #endregion
            #region
            //Console.Write("Input some text: ");
            //string text = Console.ReadLine();
            //int counta = 0;
            //int counto = 0;
            //int counti = 0;
            //int counte = 0;

            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] == 'a')
            //        counta++;
            //    if (text[i] == 'o')
            //        counto++;
            //    if (text[i] == 'i')
            //        counti++;
            //    if (text[i] == 'e')
            //        counte++;
            //}
            //Console.WriteLine($"\na = {counta}, \no = {counto}, \ni = {counti}, \ne = {counte}");
            #endregion
            //Ask user to enter the number of month. Read the value and write the amount of days in this month
            #region
            //Console.Write("Input the number of month: ");
            //int mount = Convert.ToInt32(Console.ReadLine());

            //switch(mount)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("Month have 31 days.");
            //        break;
            //    case 2:
            //        Console.Write("The 2nd month is a February and have 28 days.");
            //        Console.Write("in leap year The February month  Have 29 days.");
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("Month have 30 days.");
            //        break;
            //    default:
            //        Console.Write("invalid Month number.");
            //        break;
            //}
            #endregion
            #region
            //Console.Write("Input the number of month: ");
            //int month = Convert.ToInt32(Console.ReadLine());

            //if (month >= 1 && month <= 12)
            //{
            //    int daysMonth = System.DateTime.DaysInMonth(2018, month);
            //    Console.WriteLine($"The mount'{month}'have '{daysMonth}'");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong! use number only range 1 to 12 ");
            //}
            #endregion
            ////Enter 10 integer numbers. Calculate the sum of first 5 elements if they are positive or product of last 5 element in  the other case.
            #region
            int[] numbers = new int[10];
            Console.WriteLine("Enter 10 numbers type int :");
            bool isNum;
            int sum = 0;
            
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine($"Enter number {i+1}: ");
                //isNum = Int32.TryParse(Console.ReadLine(), out numbers[i]);
                numbers[i] = Int32.Parse(Console.ReadLine());
            }

            int temp = 0;
            int prod = 1;
            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] > 0)
                {
                    temp++;
                }
                sum += numbers[i];
                
            }
            if (temp == 5)
            {
                Console.WriteLine(sum);
            }
            else
            {
                for (int i = 5; i < numbers.Length; i++)
                {
                    prod *= numbers[i];
                }
            Console.WriteLine(prod);

            }

            //if (numbers[0] > 0 && numbers[1] > 0 && numbers[2] > 0 && numbers[3] > 0 && numbers[4] > 0)
            //{
            //    for (int i = 0; i < 5; i++)
            //    {
            //        sum += numbers[i];
            //    }
            //    Console.WriteLine("The sum of the first five numbers is {0}", sum);
            //}
            //else
            //{
            //    Console.WriteLine("The last 5 element in  the other case");
            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            #endregion

            Console.ReadKey();
        }
    }
}
