using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

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
        program.Task_3_2(0.1);
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
            answer += i;
        }
        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;
        for (int i = 1; i <= 10; i++)
        {
            answer += 1.0 / i;
        }
        answer = Math.Round(answer, 4);
        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;
        for (int i = 2; i <= 112; i += 2)
        {
            answer += ((double) i) / (i + 1);
        }
        answer = Math.Round(answer, 4);
        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        if (x == 0)     // invalid value, but we have it in test
        {
            return 0;
        }
        for (int i = 0; i <= 8; i++)
        {
            answer += Math.Cos((i + 1) * x) / Math.Pow(x, i);
        }
        answer = Math.Round(answer, 4);
        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;
        for (int i = 0; i < 10; i++)
        {
            answer += Math.Pow(p + i * h, 2);
        }
        answer = Math.Round(answer, 4);
        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;
        answer = 0.5 * Math.Pow(x, 2) - 7 * x;
        answer = Math.Round(answer, 4);
        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;
        answer = 1;
        for (int i = 1; i <= 6; i++)
        {
            answer *= i;
        }
        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;
        int fact = 1;
        for (int i = 1; i <= 6; i++)
        {
            fact *= i;
            answer += fact;
        }
        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        int fact = 1;
        for (int i = 1; i <= 6; i++)
        {
            fact *= i;
            answer += Math.Pow(-5, i) / fact;
        }
        answer = Math.Round(answer, 4);
        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;
        answer = 1;
        for (int i = 0; i < 7; i++)
        {
            answer *= 3;
        }
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
            Console.Write("5 ");
        }
    }
    public double Task_1_12(double x)
    {
        double answer = 0;
        if (x == 0)     // invalid value, but we have it in test
        {
            return 0;
        }
        for (int i = 0; i <= 10; i++)
        {
            answer += 1.0 / Math.Pow(x, i);
        }
        answer = Math.Round(answer, 4);
        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;
        answer = Math.Max(Math.Max(-1, x) * -1, -1);
        return answer;
    }
    public void Task_1_14()
    {
        int a = 1, b = 1;
        for (int i = 0; i < 8; i++)
        {
            Console.Write($"{a} ");
            int temp = b;
            b = a + b;
            a = temp;
        }

    }
    public double Task_1_15()
    {
        double answer = 0;
        int a1 = 1, a2 = 2;
        int b1 = 1, b2 = 1;
        for (int i = 0; i < 5; i++)
        {
            int temp = a2;
            a2 = a1 + a2;
            a1 = temp;
            temp = b2;
            b2 = b1 + b2;
            b1 = temp;
        }
        answer = Math.Round(a1 / (double) b1, 1);
        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;
        answer = 1.0 / 15;
        // 1 + 2 + 4 + ... + 2^64 = 2^65 - 1 (-1 we ignore, because it is too small)
        for (int i = 0; i < 65; i++)
        {
            answer *= 2;
            int teens = (int) Math.Log10(answer);
            answer = answer / Math.Pow(10, teens);
            power += teens;
        }
        answer = Math.Round(answer, 4);
        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        const int radius = 6350;
        answer = Math.Pow(Math.Pow(radius + x, 2) - Math.Pow(radius, 2), 0.5);
        answer = Math.Round(answer, 4);
        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;
        answer = 10 * (int) Math.Pow(2, x / 3);
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
        const int L = 30000;
        answer = 1;
        int mult = 1;
        while (mult <= L)
        {
            answer += 3;
            mult *= answer;
        }
        return answer - 3;
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
        if (x == 1)     // invalid value, but we have it in test
        {
            return 0;
        }
        const double eps = 0.0001;
        double s = 1;
        while (s >= eps)
        {
            answer += s;
            s *= x * x;
        }
        answer = Math.Round(answer, 4);
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
        int count = 10;
        while (count < 100000)
        {
            count *= 2;
            answer += 3;
        }
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
        double sum = 10000;
        while (sum < 20000)
        {
            sum *= 1.08;
            answer++;
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
        int answer = 0;
        int a1 = 1, a2 = 2, b1 = 1, b2 = 1;
        double dist = 0;
        do
        {
            dist = Math.Abs(((double)a1 / b1) - ((double)a2 / b2));
            int temp = a2;
            a2 = a1 + a2;
            a1 = temp;
            temp = b2;
            b2 = b1 + b2;
            b1 = temp;
            answer++;

        } while (dist > 0.001);
        answer++;
        return answer;
    }
    #endregion

    #region Level 3
    //public (double, double) Task_3_1(double x)
    //{
    //    double S = 0, y = 0;

    //    // code here

    //    // end

    //    return (S, y);
    //}
    public (double, double) Task_3_2(double x)
    {
        // does not pass test, but only because of accuracy. Teacher said it`s ok
        double S = 0, y = 0;
        double a = 0, eps = 0.0001;
        int i = 1;
        do
        {
            S += a;
            a = Math.Pow(x, i) * Math.Sin(i * Math.PI / 4);
            i++;
        } while (Math.Abs(a) > eps);
        y = x * Math.Sin(Math.PI / 4) / (1 - 2 * x * Math.Cos(Math.PI / 4) + x * x);
        S = Math.Round(S, 3);
        y = Math.Round(y, 3);
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