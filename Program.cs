using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
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

        // code here
        int i, s = 0;
        for (i = 2; i<=35; i = i + 3)
            s = s + i;
        answer = s;

        
        

        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for ( double i = 1; i <= 10; i++) answer += 1 / i;
        answer = Math.Round(answer, 2);


        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2; i <= 112; i += 2)
        {
            answer += i / (i + 1);
        }
            answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double a = 1.0;
        if (x == 0)
        {
            answer = 0;
        }
        else
        {

            for (int i = 1; i <= 9; i++)
            {
                answer += (Math.Cos(i * x) / a);
                a *= x;
            }
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i = 0; i <= 9; i++)
        {
            answer += (p + h * i) * (p + h * i);
        }
        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * x * x - 7 * x;
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int a = 1;
        for (int i = 1; i <= 6; i++) a *= i;
        answer = a;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int a = 1;
        for (int i = 1; i <= 6; i++)
        {
            a = a * i;
            answer += a;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double f;
        for (double i = 1; i <= 6; i++)
        {
            f = 1;
            for (double a = 2; a <= i; a++) f *= a;
            answer += Math.Pow(-1, i) * Math.Pow(5, i) / f;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        answer += 1;
        for (int i = 1; i <= 7; i++)
        {
            answer *= 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task

        // code here
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(5 + " ");
        }

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double a = 1;
        for (int i = 0; i <= 10; i++)
        {
            answer += a;
            a /= x;
        }
        if (Double.IsInfinity(answer))
        {
            answer = 0;
        }
        else
        {
            answer = Math.Round(answer, 2);
        }
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
        {
            answer = 1;
        }
        else if (x <= 1)
        {
            answer = x * (-1);
        }
        else
        {
            answer = -1;
        }

        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task

        // code here
        int a1 = 1, a2 = 1;
        int a3 = a1 + a2;
        Console.Write($"{a1} {a2} {a3} ");
        for (int i = 4; i <= 8; i++)
        {
            a1 = a2;
            a2 = a3;
            a3 = a1 + a2;
            Console.Write($"{a3} ");
        }

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        int f1 = 1;
        int f2 = 1, ch = 0, zn = 1, f3 = 0, f4 = 1;
        for (int i = 1; i <= 5; i++)
        {
            ch = f1 + f2;
            f1 = f2; f2 = ch;
            zn = f3 + f4;
            f3 = f4; f4 = zn;

        }
        answer = ch * 1.0 / zn;
        answer = Math.Round(answer, 1);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double yach = 1;
        double s = 0;
        for (int i = 1; i <= 64; i++)
        {

            s = s + yach / 15;
            yach = yach * 2;
        }
        while (s > 10)
        {
            power += 1;
            s /= 10;
        }
        answer = Math.Round(s, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        int r = 6350;
        answer = Math.Sqrt((r + x) * (r + x) - r * r);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int nach = 10;
        int times = x / 3;
        for (int i = 1; i <= times; i++)
        {
            nach *= 2;
        }
        answer = nach;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here
        double c = Math.Cos(x);
        const double E = 0.0001;
        for (int i = 2; Math.Abs(c) >= E; i++)
        {
            answer += c;
            c = Math.Cos(i * x) / (i * i);
        }
        // end

        return answer;
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
        int answer = 0;

        // code here
        int i = 0;
        double s = 0;
        if (h < 0)
        {
            return 0;
        }
        while (s <= p)
        {
            s += a + i * h;
            i++;
        }
        answer = i - 1;
        // end

        return answer;
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
        int quotient = 0, remainder = 0;

        // code here
        if (M != 0)
        {
            N = Math.Abs(N);
            M = Math.Abs(M);
            while ((N - M) >= 0)
            {
                N -= M;
                quotient++;
            }
            remainder = N;
        }
            // end

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
        double answer = 0;

        // code here
        double a = 10;
        answer = a;
        for (int i = 2; i <= 7; i++)
        {
            a *= 1.1;
            answer += a;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double s = 0, step = 10.0;
        while (s < 100.0)
        {
            s += step;
            step *= 1.1;
            answer += 1;
        }
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double a = 10;
        while (a <= 20)
        {
            a *= 1.1;
            answer++;
        }
        // end

        return answer;
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
        int answer = 0;

        // code here;
        double l = 0.1;
        double a = 0.1;
        for (int i = 2; i <= 10; i++)
        {
            a *= 0.1;
        }
        while (l > a)
        {
            answer++;
            l /= 2;
        }
        // end

        return answer;
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
        S = x;
        double nume = x;
        double deno = 1;
        for (int i = 1; ; i++)
        {
            int k = 1;
            if (i % 2 == 1) k = -1;
            nume *= x * x;
            deno = 2 * i + 1;
            double res = k * nume / deno;
            if (Math.Abs(res) < 0.0001) break;
            S += res;
        }
        y = Math.Atan(x);
        // end

        return (S, y);
    }
    #endregion
}