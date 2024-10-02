using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Runtime.CompilerServices;
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

        // code here
        int a1 = 2;
        int an = 35;
        int d = 3;
        int n = ((an - a1) / d) + 1;
        answer = (n * (a1 + an)) / 2;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double a = 1; a <= 10; a += 1)
        {
            answer = answer + 1 / a;
        }
        // end

        return Math.Round(answer, 2);
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double a = 2; a <= 112; a += 2)
        {
            answer += a / (a + 1);
        }
        // end

        return Math.Round(answer, 1);
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double p = 1;
        if (x != 0)
        {
            for (int i = 1; i <= 9; i++)
            {
                answer += Math.Cos(i * x) / p;
                p *= x;
            }
        }
            // end

            return Math.Round(answer, 2);
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i = 0; i < 10; i++)
        {
            double res = p + i * h;
            answer += res * res;
        }
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * x * x - 7 * x;
        // end

         return Math.Round(answer, 2);
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        answer += 1;
        for (int a = 1; a < 7; a++)
        {
            answer = answer * a;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int slay = 1;
        for (int a = 1; a < 7; a++)
        {
            slay *= a;
            answer += slay;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        int pw = 1;
        int fc = 1;
        int os = 5;
        int ch = -1;
        for (int a = 1; a < 7; a++)
        {
            ch *= -1;
            pw *= a;
            fc *= os;
            double g = (double)ch * fc / pw;
            answer += -g;
        }
        Console.WriteLine(answer);
        // end

        return Math.Round(answer, 2);
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int ch = 3;
        int result = 1;
        for (int a = 0; a < 7; a++)
        {
            result *= ch;
        }
        answer = result;
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int a = 1; a < 7; a++)
        {
            Console.WriteLine(a);
        }
        for (int b = 5; b < 7; b++)
        {
            Console.WriteLine(5);
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double d = 1;
        if (x != 0)
        {
            for (int i = 0; i <= 10; i++)
            {
                answer += d;
                d = d / x;
            }
        }
        // end

        return Math.Round(answer, 2);
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 1;
        else if (-1 <= x && x <= 1) answer = -x;
        if (x > 1) answer = -1;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        double ch1= 1;
        double ch2 = 1;
        for (int i = 0; i <= 6; i ++)
        {
            double ch = ch1 + ch2;
            ch1 = ch2;
            ch2 = ch;
            Console.WriteLine(ch2);
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double ch1 = 1, zn1 = 1, ch2 = 2, zn2 = 1;
        for (int i = 1; i <= 3; i ++)
        {
            double ch = ch1 + ch2;
            double zn = zn1 + zn2;
            ch1 = ch2;
            ch2 = ch;
            zn1 = zn2;
            zn2 = zn;
        }
        answer = ch2 / zn2;
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        int a = 0;
        ulong b = 1;
        while (a < 64)
        {
            answer += b;
            b *= 2;
            a++;
        }
        answer /= 15;
        power = 18;
        answer /= Math.Pow(10, power);
        answer = Math.Round(answer, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        const double R = 6350;
        answer = Math.Sqrt(x * (2.0 * R + x));

        return Math.Round(answer, 2);
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int startcells = 10;
        int interval = 3;
        for (int i = 0; i <= x; i += interval)
        {
            int cells = startcells * (int)Math.Pow(2, i / interval);
            answer = cells;
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

        // code here
        int l = 30000;
        int n = 1;
        int step = 3;
        int cur = 1;
        int p = 1;
        while (p * cur <= l)
        {
            p *= cur;
            n += step;
            cur = n;
        }
        n -= step;
        answer = n;
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
        double S = 1.0;
        double a = 1.0;
        int n = 1;
        double pow = x * x;
        if (x != 1)
        {
            while (a > 0.0001)
            {
                a *= pow;
                if (a < 0.0001) break;
                S += a;
                n++;
            }
        }
        else
            S = 0;
        answer = S;
        // end

        return Math.Round(answer, 2);
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
        int startcells = 10;
        int needcells = (int)Math.Pow(10, 5);
        int interval = 3;

        int time = 0;
        int cells = startcells;

       while (cells < needcells)
        {
            cells *= 2;
            time += interval;
        }
        answer = time;
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
        double startsum = 10000;
        double rate = 0.08;
        int time = 0;
        double sum = startsum;
        while (sum < startsum * 2)
        {
            sum *= (1 + rate);
            time++;
        }
        answer = time;
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
        double elip = 0.001;
        int ch1 = 1;
        int zn1 = 1;
        int ch2 = 2;
        int zn2 = 1;
        int count = 2;
        while (true)
        {
            int ch3 = ch1 + ch2;
            int zn3 = zn1 + zn2;
            double raz = Math.Abs((double)ch2 / zn2 - (double)ch1 / zn1);
            if (raz < elip)
            {
                answer = count;
                break;
            }
            ch1 = ch2;
            zn1 = zn2;
            ch2 = ch3;
            zn2 = zn3;
            count++;
        }
        // end

        return answer;
    }
    #endregion

    #region Level 3
    public (double, double) Task_3_1(double x)
    {
        double S = 0, y = 0;

        // code here
        S = 1;
        y = Math.Cos(x);
        double i = 1;
        double n1 = -1, n2 = x * x, d = 2;
        double res = n1 * n2 / d;
        while (Math.Abs(res) >= 0.0001)
        {
            S += res;
            i++;
            n1 *= -1;
            n2 *= x * x;
            d *= (2 * i - 1) * (2 * i);
            res = n1 * n2 / d;
        }
        Console.WriteLine($"x={x:f2} S={S:f5} y={y:f5}");
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
        y = (1 + 2 * x * x) * Math.Exp(x * x);
        for (int i = 0; i <= 1000000; i++)
        {
            double ch1 = 0, ch2 = 1, ch3 = 1, res = 1;
            ch1 = (2 * i + 1);
            ch2 = Math.Pow(x, 2 * i);
            for (int n = 1; n <= i; n++)
                ch3 *= n;
            res = (ch1 * ch2) / ch3;
            if (Math.Abs(res) >= 0.0001)
                S += res;
            else
                break;
        }
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
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
