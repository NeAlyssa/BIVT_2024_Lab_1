using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

        //program.Task_1_1();
        //program.Task_1_2();
        //program.Task_1_3();
        //program.Task_1_4(0.9);
        //program.Task_1_5(0, 2);
        //program.Task_1_6(4);
        //program.Task_1_7();
        //program.Task_1_8();
        //program.Task_1_9();
        //program.Task_1_10();
        //program.Task_1_11();
        //program.Task_1_12(0.9);
        //program.Task_1_13(-1.5);
        //program.Task_1_14();
        //program.Task_1_15();
        //program.Task_1_16();
        //program.Task_1_17(10);
        //program.Task_1_18(24);
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
        int answer = 0;
        for (int i = 2; i <= 35; i += 3)
        {
            answer = answer + i;
        }
        
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_2()
    {
        double answer = 1;

        for (int i = 2; i <= 10; i ++)
        {
            answer += (double)1 / i;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine("{0:f2}", answer);
        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;
        for (int i = 2; i <= 112; i += 2)
        {
                answer += (double)((double)i/(double)(i+1));
        }
        answer = Math.Round(answer, 2);
        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        double b = 1;
        for (int i = 1; i <= 9; i ++)
        {
            if (x!=0)
            { 
                answer += (double)(Math.Cos(x*i) / b);
                b *= x;
            }
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;
        for (int i = 0; i <= 9; i++)
        {
            answer += (p + h * i) * (p + h * i);
        }
        Console.WriteLine(answer);

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        answer = 0.5 * x * x - 7 * x;
        answer = Math.Round(answer, 2);

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        for (int i = 1; i <= 6; i++)
        {
            answer *= i;
        }

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;
        int b = 1;
        for (int i = 1; i <= 6; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                b *= j;
            }
            answer += b;
            b = 1;
        }

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        double b = 1;
        double c = -1;
        double five = 5;
        for (double i = 1; i <= 6; i++)
        {
            for (double j = 1; j <= i; j++)
            {
                b *= j;
            }
            answer += (c*five)/ b;
            c *= -1;
            five *= 5;
            b = 1;
        }
        answer = Math.Round(answer, 2);
        return answer;
    }
    public int Task_1_10()
    {
        int answer = 3;
        for (int i = 1; i <= 6; i++)
        {
            answer *= 3;
        }
        Console.WriteLine(answer);
        return answer;
    }
    public void Task_1_11()
    {
        for (int i = 1; i <= 6; i++)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
        for (int i = 1; i <= 6; i++)
        {
            Console.Write("5 "); ;
        }

    }
    public double Task_1_12(double x)
    {
        double answer = 0;
        double k = 1;
        if (x != 0)
        {
            for (int i = 1; i <= 11; i++)
            {
                answer += (double)(1 / k);
                k *= x;
            }
        }
        answer = Math.Round(answer, 2);
        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;
        if (x <= -1)
        {
            answer = 1;
        }
        else if (x >= 1)
        {
            answer = -1;
        }
        else
        {
            answer = -x;
        }
        

        return answer;
    }
    public void Task_1_14()
    {
        int a1 = 1;
        int a2 = 1;
        int answer = 0;
        answer = a1;
        int b = 0;
        for (int i = 1; i <= 6; i++)
        {
            b = a1 + a2;
            a1 = a2;
            a2 = b;
            answer += a1;
        }
        answer += a2;
        Console.WriteLine(answer);
        

    }
    public double Task_1_15()
    {
        double answer = 0;

        int a1 = 1;
        int b1 = 1;
        int a2 = 2;
        int b2 = 1;

        int a = 0;
        int b = 0;

        for (int i = 3; i <= 5; i++)
        {
            a = a1 + a2;
            b = b1 + b2;

            a1 = a2;
            a2 = a;
            b1 = b2;
            b2 = b;
        }

        answer = (double)a / b;

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;
        double a = 1;
        for (int i = 0; i < 64; i++)
        {
            answer += a;
            a *= 2;
        }
        answer /= 15;

        while (answer > 10)
        {
            power += 1;
            answer /= 10;
        }
        answer = Math.Round(answer, 2);
        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        double r = 6350;

        answer = Math.Sqrt(x * (2 * r + x));
        answer = Math.Round(answer, 2);
        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;
        int b = x / 3;

        for (int i = 1; i <= b; i++)
        {
            answer *= 2;
        }
        
        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 0;
        int L = 1;

        for (int i = 1; i <= 20; i += 3)
        {
            if (L*i > 30000)
            {
                break;
                answer += 1;
            }
            else
            {
                L *= i;
                answer = i;
                
            }
        }
        return answer;
    }

    
    public int Task_2_3(double a, double h, double p)
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public double Task_2_4(double x)
    {
        double answer = 0;
        double a = 1;
        if (Math.Abs(x) < 1)
        {
            while (a >= 0.0001)
            {
                answer += a;
                a *= x * x;
            }

        }
        answer = Math.Round(answer, 2);
        return answer;
    }
    public (int, int) Task_2_5(int N, int M)
    {
        int quotient = 0, remainder = 0;

        // code here

        // end

        return (quotient, remainder);
    }
    public int Task_2_6()
    {
        int answer = 0;
        int V = 10;
        
        while (V < 100000)
        {
            V *= 2;
            answer += 1;

        }
        answer *= 3;

        return answer;

        return answer;
    }
    public double Task_2_7a()
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_8()
    {
        int answer = 0;
        double s = 10000;
        while (s < 20000)
        {
            s = 1.08*s;
            answer += 1;
        }
        return answer;
    }
    public int Task_2_9()
    {
        int answer = 0;

        // code here;

        // end

        return answer;
    }
    public int Task_2_10()
    {
        
        int answer = 2;

        double a1 = 1;
        double b1 = 1;
        double a2 = 2;
        double b2 = 1;
        
        while (Math.Abs((a2 / b2) - (a1 / b1)) >= 0.001)
        {
            double a = a2;
            a2 = a1 + a2;
            a1 = a;

            double b = b2;
            b2 = b1 + b2;
            b1 = b;

            answer += 1;
        }

        return answer;
    }
    #endregion

    #region Level 3
    public (double, double) Task_3_1(double x)
    {
        double S = 0, y = 0;

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_2(double x)
    {
        double S = 0;
        double y = 0;
        double number = x;
        int i = 1;

        while (number >= 0.0001)
        {
           S += number * Math.Sin(i * Math.PI / 4);
           number *= x;
           i += 1;
        }


        y = (x*Math.Sin(Math.PI/4)) / (1 - 2*x*Math.Cos(Math.PI/4) + x*x);

        //Console.WriteLine(S);
        //Console.WriteLine(y);

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