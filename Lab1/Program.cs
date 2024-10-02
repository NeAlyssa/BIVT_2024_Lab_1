using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;

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
        double answer = 0;

        for (double i = 1; i <= 10; i++)
        {
            answer = answer + (1 / i);
        }
        answer = Math.Round(answer, 2);

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        for (double i = 2; i <= 112; i += 2)
        {
            answer += i / (i + 1);
        }
        answer = Math.Round(answer, 2);

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        double c = 1;

        if (x > 0)
        {
            for (double i = 0; i <= 8; i++)
            {
                answer += (Math.Cos((i + 1) * x)) / (c);
                c *= x;
            }
            answer = Math.Round(answer, 2);
        }
        
        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // s = p2 + (p + h)2 + ... +(p + 9h)2
        for (double i = 0; i <= 9; i++)
        {
            answer += ((p + (h * i)) * (p + (h * i)));
        }
        Console.WriteLine(answer);

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0.5 * x * x - 7 * x;

        answer = Math.Round(answer, 2);

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        for (int i = 2; i <= 6; i++)
        {
            answer *= i;
        }

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 1;
        int c = 1;

        for (int i = 2; i <= 6; i++)
        {
            c = c * i;
            answer += c;
        }

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        double f = 1;
        double v = 1; 
        double c = 1;
        for (int i = 1; i <= 6; i++)
        {
            c *= -1;
            v *= 5;
            f *= i;
            answer += c * v / f;
        }
        answer = Math.Round(answer, 2);

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 3;
        int c = 1;

        while (c <= 6)
        {
            answer = answer * 3;
            c += 1;
        }

        return answer;
    }
    public void Task_1_11()
    {
        int c = 5;
        int r = 1;
        for (int i = 1; i <= 6; i++)
        {
            Console.Write($" {i}");
        }
        Console.WriteLine(" ");
        while (r <= 6)
        {
            Console.Write($" {c}");
            r++;
        }
    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // s = 1 + 1 / x + 1 / x 2 + ... +1 / x 10.
        double c = 1;
        if (x == 0)
            return answer;
        else
        {
            for (double i = 0; i <= 10; i++)
            {
                answer += (1 / c);
                c *= x;
            }
        }
        answer = Math.Round(answer, 2);
        
        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        if (x <= -1)
            answer = 1;
        if (-1 < x && x <= 1)
            answer = -x;
        if (x > 1)
            answer = -1;

        return answer;
    }
    public void Task_1_14()
    {
        int c = 1;
        int b = 1;
        int r = 1;
        //Console.Write($"{c} {b}");
        while (r <= 6)
        {
            if (b >= c)
            {
                c += b;
                //Console.Write($" {c}");
                r++;
            }
            else
            {
                b += c;
                //Console.Write($" {b}");
                r++;
            }
        }

    }
    public double Task_1_15()
    {
        double answer = 0;
        // 1) a/b=1/1 2) c/d=2/1
        double a = 1, c = 2;
        answer = (2 * a + 3 * c) / (2 * c + a);

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 1;
        int power = 0;
        double g = 1;
        double i = 1;

        while (i < 64)
        {
            answer *= 2;
            g += answer;
            i++;
        }
        g /= 15; // g
        power = (int)Math.Log10(g);
        answer = Math.Round(g / Math.Pow(10, power), 2);
        //Console.WriteLine($"{answer}, {power}");

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = (6350 + x) * (6350 + x);
        answer -= (6350 * 6350);
        answer = Math.Round(Math.Sqrt(answer), 2);

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;
        int c = (x / 3);
        for (int i = 0; i < c; i++)
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
        int ans = 1;
        const int l = 30000;
        for (int i = 1; i <= 100; i += 3)
        {
            ans *= i;
            if (l / ans <= 0)
            {
                answer = i - 3;
                break;
            }
            else
                continue;
        }
        Console.WriteLine(answer);
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
        double c = 1;
        const double epsilon = 0.0001;
        if (Math.Abs(x) >= 1)
            answer = 0;
        else
        {
            for (int i = 0; Math.Abs(c) >= epsilon; i++)
            {
                answer += c; 
                c *= x * x;
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
        int s = 10;
        int i = 0;
        int shag = 1; 
        int kolichestvo = 10;
        for ( ; kolichestvo < 100000; i++)
        {
            kolichestvo = s * shag; 
            shag *= 2;
        }
        answer = (i - 1) * 3;

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
        const double s2 = 20000;
        while (s <= s2)
        {
            s *= 1.08;
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
        // (a/b = 1/1; c/d = 2/1)
        double vel;
        const double raznica = 0.001;
        double a = 1;
        double b = 1;
        double c = 2;
        double d = 1;
        while (Math.Abs((c / d) - (a / b)) > raznica)
        {
            answer++;
            // Console.WriteLine($"{a / b} {c / d}");
            a += c;
            b += d;
            vel = a;
            a = c;
            c = vel;
            vel = b;
            b = d;
            d = vel;
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
        double S = 0, y = 0, c = 1, b = x;
        const double epsilon = 0.0001;
        double l = b * Math.Sin((c * Math.PI) / 4);
        while (Math.Abs(b) >= epsilon)
        {
            S += l;
            b *= x;
            c += 1;
            l = b * Math.Sin((c * Math.PI) / 4);
        }
        y = (x * Math.Sin(Math.PI / 4)) / (1 - 2 * x * Math.Cos(Math.PI / 4) + x * x);

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