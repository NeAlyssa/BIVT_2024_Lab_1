using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
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
        program.Task_1_16();
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

        // code here
        for (int i = 2; i <= 35; i += 3)
                answer += i;
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double i = 1; i <= 10; i++)
            answer += 1 / i;
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2; i <= 112; i += 2)
            answer += i / (i + 1);
        answer = Math.Round(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if (x == 0)
            answer = 0;
        else
        {
            double p = 1;
            for (int i = 1; i <= 9; i++)
            {
                answer += Math.Cos(x * i) / p;
                p *= x;
            }
            answer = Math.Round(answer, 2);
        }
        
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i = 0; i <= 9; i++)
            answer += (p + h * i) * (p + h * i);
        answer = Math.Round(answer,2);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = Math.Round(0.5 * x * x - 7 * x, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        answer = 1;
        for (int i = 1; i <= 6; i++)
            answer *= i;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int p = 1;
        for (int i = 1; i <= 6; i++)
        {
            p *= i;
            answer += p;
        }    
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        int p = 1, c = 1;
        double m = 1;
        for (int i = 1; i <= 6; i++)
        {
            p = -p;
            m = m * i;
            c *= 5;
            answer += p * c / m;
        }
        answer = Math.Round(answer, 2);
        // end
        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        answer = 1;
        for (int i = 1; i <= 7; i++)
            answer *= 3;
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i <= 6; i++)
            Console.Write(i + " ");
        Console.WriteLine();
        for (int i = 1; i <= 6; i++)
            Console.Write(5 + " ");
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x == 0)
            answer = 0;
        else
        {
            double p = 1;
            for (int i = 1; i <= 11; i++)
            {
                answer += p;
                p /= x;
            }
            answer = Math.Round(answer, 2);
            Console.WriteLine(answer);
        }
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 1;
        if (-1 < x && x <= 1)
            answer = -x;
        if (x > 1)
            answer = -1;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a = 1, b = 1, c;
        Console.Write("{0} {1} ", a, b);
        for (int i = 1; i <= 6; i++)
        {
            c = b;
            b = a + b;
            a = c;
            Console.Write("{0} ", b);
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double a1 = 1, a2 = 2, a3;
        int b1 = 1, b2 = 1, b3;
        for (int i = 1; i <= 3; i++)
        {
            a3 = a2;
            a2 += a1;
            a1 = a3;

            b3 = b2;
            b2 += b1;
            b1 = b3;
        }
        answer = Math.Round(a2 / b2, 2);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        for (int i = 9; i <= 63; i++)
        {
            answer += Math.Pow(2, i);
        }
        answer /= 15;
        double ans = answer;
        while (ans > 10)
        {
            ans /= 10;
            power += 1;
        }
        answer = Math.Round(ans, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        int R = 6350;
        answer = Math.Sqrt(x * (x + 2 * R));
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        answer = 10;
        for (int i = 3; i <= x; i += 3)
            answer *= 2;
        // end

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

        // code here
        int p = 1;
        int n = 1;
        while (p <= 30000)
        {
            n += 3;
            p *= n;
        }
        answer = n - 3;
        // end

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

        // code here
        answer = 1;
        int i = 2;
        if (x >= 1)
            answer = 0;
        else
        {
            do
            {
                answer += Math.Pow(x, i);
                i += 2;
            } while (Math.Pow(x, i) >= 0.0001);
            answer = Math.Round(answer, 2);
        }
        // end

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

        // code here
        answer = 0;
        int sum = 10;
        while (sum <= 100000)
        {
            answer += 3;
            sum *= 2;
        }
        // end

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

        // code here;
        double sum = 10000;
        while (sum <= 20000)
        {
            answer += 1;
            sum *= 1.08;
        }
        // end

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
        int answer = 0;

        // code here;
        answer = 2;
        double a1 = 1, a2 = 2, a3;
        double b1 = 1, b2 = 1, b3;
        do
        {
            answer += 1;

            a3 = a2;
            a2 += a1;
            a1 = a3;

            b3 = b2;
            b2 += b1;
            b1 = b3;
        } while (Math.Abs(a2 / b2 - a1 / b1) >= 0.001);
        // end

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
        int i = 0;
        double c;
        c = x;
        do
        {
            i += 1;
            c = -c * x * x;
            c = c / (4 * i * i - 1);
            y = 
        }
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