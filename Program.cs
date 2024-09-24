using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Net;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

        program.Task_1_1();
        program.Task_1_2();
        program.Task_1_3();
        program.Task_1_4(0.9);
        program.Task_1_5(0, 2);
        program.Task_1_6(4);
        program.Task_1_7();
        program.Task_1_8();
        program.Task_1_9();
        program.Task_1_10();
        program.Task_1_11();
        program.Task_1_12(0.9);
        program.Task_1_13(-1.5);
        program.Task_1_14();
        program.Task_1_15();
        program.Task_1_16();
        program.Task_1_17(10);
        program.Task_1_18(24);
        //program.Task_2_1(0);
        //program.Task_2_2();
        //program.Task_2_3(8, 2, 0);
        //program.Task_2_4(0.8);
        //program.Task_2_5(11, 5);
        //program.Task_2_6();
        //program.Task_2_7a();
        //program.Task_2_7b();
        //program.Task_2_7c();
        //program.Task_2_8();
        //program.Task_2_9();
        //program.Task_2_10();
        //program.Task_3_1(0.1);
        //program.Task_3_2(0.1);
        //program.Task_3_3(0.1);
        //program.Task_3_4(0.1);
        //program.Task_3_5(double.Pi/5);
        //program.Task_3_6(0.1);
        //program.Task_3_7(0.1);
        //program.Task_3_8(0.1);
        //program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int sum = 0;

        for (int i = 2; i <= 35; i += 3)
        {
            sum += i;
        }

        return sum;
    }
    public double Task_1_2()
    {
        double sum = 0;

        for (double i = 1; i <= 10; i++)
        {
            sum = sum + 1 / i;
        }

        return Math.Round(sum, 2);
    }
    public double Task_1_3()
    {
        double sum = 0;

        for (double i = 2; i <= 112; i += 2)
        {
            sum += i / (i + 1);
        }


        return Math.Round(sum, 2);


    }
    public double Task_1_4(double x)
    {
        double sum = 0, power_x = 1;

        for (double i = 0; i <= 8; i++)
        {
            if (x == 0)
            {
                continue;
            }

            sum += Math.Cos((i + 1) * x) / power_x;

            power_x *= x;       
        }

        return Math.Round(sum, 2);

    }
    public double Task_1_5(double p, double h)
    {
        double sum = 0;

        for (int i = 0; i <= 9; i++)
        {
            
            sum += (p + i * h) * (p + i * h);
        }

        return Math.Round(sum, 2);
    }
    public double Task_1_6(double x)
    {
        double y = 0;

        y = (0.5 * x * x) - (7 * x);

        return Math.Round(y, 2);
    }
    public int Task_1_7()
    {
        int factorial = 1;

        for (int i = 1; i <= 6; i++)
        {
            factorial *= i;
        }

        return factorial;
    }
    public int Task_1_8()
    {
        int sum1 = 0, factorial = 1;

        for (int i = 1; i <= 6; i++)
        {
            factorial *= i;  // факториал

            sum1 += factorial;  // сумма факториалов
        }

        return sum1;
    }
    public double Task_1_9()
    {
        double sum1 = 0, power1 = 1;

        int p = 1, q = 1;

        for (int i = 1; i <= 6; i++)
        {
            q *= 5;

            power1 *= i;  // факториал

            p = -p;

            sum1 += p * q / power1;
        }

        return Math.Round(sum1, 2);
    }
    public int Task_1_10()
    {
        int num = 1, i = 1;

        while (i < 8)
        {
            num *= 3;

            i += 1;
        }

        return num;
    }
    public void Task_1_11()
    {
        Console.Write("а) ");
        for (int i = 1; i <= 6; i++)
        {

            if (i == 6)
            {
                Console.Write(i + ",");
            }
            else
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();

        Console.Write("б) "); 
        for (int j = 1; j <= 6; j++)
        {
            if (j == 6)
            {
                Console.Write(5 + ".");
            }
            else
            {
                Console.Write(5 + " ");
            }
           
        }
    }
    public double Task_1_12(double x)
    {
        double sum1 = 0, x1 = 1;

        for (int i = 0; i <= 10; i++)
        {
            if (x == 0)
            {
                break;
            }
          
            
                sum1 += 1 / x1;
                x1 *= x;
            
           
        }
        return Math.Round(sum1, 2);
    }
    public double Task_1_13(double x)
    {
        double y;

        if (x <= -1)

            y = 1;

        else if (x > 1)

            y = -1;

        else

            y = -x;

        return y;
    }
    public void Task_1_14()
    {
        int a0 = 0, a1 = 1; // a0, a1 - последующий и предыдущий члены последовательности соответственно

        Console.Write(a1 + " ");

        for (int i = 1; i < 8; i++)
        {
            int a = a0 + a1;

            Console.Write(a + " ");

            a0 = a1;

            a1 = a;
        }
    }
    public double Task_1_15()
    {
        double n5 = 0;

        int a0 = 0, a1 = 1, a = 0;      // члены последовательности, находящиеся в знаменателе

        int b0 = 1, b1 = 1, b = 0;      // члены последовательности, находящиеся в числителе

        for (int i = 1; i < 5; i++)
        {
            // Числитель и знаменатель текущего члена последовательности

            a = a0 + a1;
            b = b0 + b1;

            // Сдвигаем значения для следующей итерации

            a0 = a1;
            a1 = a;
            b0 = b1;
            b1 = b;
            n5 = (double)b / a;
            

        }
        return n5;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;

        double sum1 = 1;

        double x;

        int power = 0;

        double count = 1;

        for (int i = 1; i <= 63; i += 1)
        {
            count *= 2;

            sum1 += count;
        }

        x = (double)sum1 / 15;

        power = (int)Math.Log10(x);

        answer = x / Math.Pow(10, power);

        return (Math.Round(answer, 2), power);
    }
    public double Task_1_17(double x)
    {
        double distance = 0;     // искомое расстояние

        int r = 6350;       // радиус земли

        double d = x * (2 * r + x);

        distance = Math.Sqrt(d);

        return distance = Math.Round(distance, 2);
    }
    public int Task_1_18(int hour)
    {  
       // hour - количество прошедших часов
       int count = 10;      // количество клеток

       while (hour > 0)
        {
            count *= 2;

            hour -= 3;
        }
        

        return count;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double s = 0;

        int n = 1;

        double variable1 = 1;

        while (Math.Abs(variable1) >= 0.0001)
        {
            s += Math.Cos(n * x) / (n * n);

            variable1 = Math.Cos(n * x) / (n * n);

            n += 1;
        }

        return Math.Round(s, 2);
    }
    public int Task_2_2()
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_3(double a, double h, double p)
    {
        double sum = 0;

        int n = 0;

        while (sum < p)
        {
            if (h > 0)
            {
                n++;

                sum += a + n * h;
            }
            else
            {
                break;
            }
        }
        return n;
    }
    public double Task_2_4(double x)
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public (int, int) Task_2_5(int N, int M)
    {
        int quotient = 0;

        int N1 = Math.Abs(N), M2 = Math.Abs(M);

        int remainder = N1;

        while (remainder >= M2)  
        {
            if (M2 == 0)
            {
                quotient = 0;

                remainder = 0;

                break;
            }
            else if (M2 != 0)
            {
                remainder -= M2;

                quotient++;
            }
        }
        return (quotient, remainder);
    }
    public int Task_2_6()
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public double Task_2_7a()
    {
        double l = 10, n = 1, sum1 = 10;    // l-путь, n - количество дней

        while (n < 7)
        {
            l *= 1.1;

            sum1 += l;

            n++;
        }

        return Math.Round(sum1, 2);
    }
    public int Task_2_7b()
    {
        double d = 100, l = 10;

        int n = 1;

        while(d >= 0)
        {
            l *= 1.1;

            d -= l;

            n += 1;
        }

        return n;
    }
    public int Task_2_7c()
    {
        int n = 0;

        double l = 10;

        while (l <= 20)
        {
            l *= 1.1;

            n++;
        }
         

        return n;
    }
    public int Task_2_8()
    {
        int answer = 0;

        // code here;

        // end

        return answer;
    }
    public int Task_2_9()
    {
        int n = 0;

        double l = 0.1, d = 1;

        for (int i = 1; i <= 10; i++)
        {
            d *= 10;
        }

        while (l > 1 / d)
        {
            l = l / 2;

            n++;
        }

        return n;
    }
    public int Task_2_10()
    {
        int answer = 0;

        // code here;

        // end

        return answer;
    }
    #endregion


    #region Level 3
    public (double, double) Task_3_1(double x)
    {
        double S = 0, y = 0;

        S = 0;
        double i = 0;
        double n1 = 1;
        double n2 = 1;
        double factorial = 1;
        double part = n1 * n2 / factorial;
        while (Math.Abs(part) >= 0.0001)
        {
            S += part;
            i++;
            n1 *= -1;
            n2 *= x * x;
            factorial *= (2 * i - 1) * (2 * i);
            part = n1 * n2 / factorial;
        }
        y = Math.Cos(x);
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
        Console.WriteLine("sum = {0}", S);

        Console.WriteLine("y = {0}", y);

        Console.WriteLine();

        return (S, y);
    }


    public (double, double) Task_3_2(double x)

    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_3(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_4(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_5(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_6(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_7(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_8(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_9(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    #endregion
}