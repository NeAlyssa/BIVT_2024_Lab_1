using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

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
        int a = 2;
        while (a <= 35)
        {
            answer = answer + a;
            a = a + 3;
        }

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;
        double a = 1;
        while (a <= 10)
        {
            answer = answer + 1/a;
            a = a + 1;
        }

        return Math.Round(answer, 2);
    }
    public double Task_1_3()
    {
        double answer = 0;
        double a = 2;
        while (a <= 112)
        {
            answer = answer + a/(a+1);
            a = a + 2;
        }

        return Math.Round(answer, 2);
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        double a = 0;
        double b = 1;
        if (x == 0)
            return 0;
        else
        {
            while (a <= 8)
            {
                answer += Math.Cos((a + 1) * x)/b;
                a += 1;
                b = b * x;
            }
            return Math.Round(answer, 2);
        }
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;
        double a = 0;

        while (a <= 9)
        {
            answer += (p + a * h) * (p + a * h);
            a += 1;
        }
        return Math.Round(answer, 2);


    }
    public double Task_1_6(double x)
    {
        double answer = 0;
        answer = 0.5 * x * x - 7 * x;

        return Math.Round(answer, 2);

    }
    public int Task_1_7()
    {
        int answer = 1;
        int a = 2;
        while (a <= 6)
        {
            answer = answer * a;
            a += 1;
        }
        return answer;

    }
    public int Task_1_8()
    {
        int a = 1;
        int answer = 0;
        int f = 1;
        while (a <= 6)
        {
            f = f * a;
            answer = answer + f;
            a += 1;
        }
        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        int a = 1;
        double s = 1;
        double f = 1;
        double e = 1; 
        while (a <= 6)
        {
            e = e * (-1);
            s = s * 5;
            f = f * a;
            answer = answer + e * s/f;
            a += 1;
        }

        return Math.Round(answer, 2); ;
    }
    public int Task_1_10()
    {
        int answer = 1;
        int a = 3;
        int b = 1;
        while (b <= 7)
        {
            answer = answer * a;
            b = b + 1;
        }

        return answer;
    }
    public void Task_1_11()
    {
        int b = 1;
        while (b <= 6)
        {
            Console.Write(b);
            Console.Write(" ");
            b = b + 1;
        }
        b = 1;
        Console.WriteLine();
        while (b <= 6)
        {
            Console.Write(5);
            Console.Write(" ");
            b = b + 1;
        }


    }

    public double Task_1_12(double x)
    {
        double answer = 0;
        double p = 1;
        int a = 0;
        if (x == 0)
        {
            return 0;
        }
        else
        {
            while (a <= 10)
            {
                a += 1;
                answer = answer + 1 / p;
                p *= x;
            }
            return Math.Round(answer, 2);


        }

    }

    public double Task_1_13(double x)
    {
        double answer = 0;
        if (x <= -1)
        {
            answer = 1;
        }
        else if (x > -1 && x <= 1)
        {
            answer = -x;
        }
        else
        {
            answer = -1;
        }
        return answer;
    }
    public void Task_1_14()
    {
        int a = 1;
        int b = 1;
        int c = 1;
        while (c <= 4)
        {
            Console.Write(a);
            Console.Write(" ");
            Console.Write(b);
            Console.Write(" ");
            a = a + b;
            b = a + b;
            c += 1;
        }

    }
    public double Task_1_15()
    {
        double answer = 0;
        double a = 1, b = 1, c = 2, d = 1, e = 1, f = 1;
        int g = 2;
        while (g < 5)
        {
            e = c;
            f = d;
            c = a + c;
            d = b + d;
            a = e;
            b = f;
            g += 1;
        }

        answer = c / d;

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;
        double c = 1;
        double a = 1;
        for (int i = 0; i < 64; ++i)
        {
            if (answer > a * 10)
            {
                a = a * 10;
                power += 1;
            }
            answer += c;
            c = c * 2;
        }
        answer = answer/ (a * 15);
        answer = Math.Round(answer, 2);
        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        double r = 6350;
        answer = Math.Sqrt((x + r) * (x + r) - r * r);
        return Math.Round(answer, 2);
    }
    public int Task_1_18(int x)
    {
        int answer = 10;
        for (int i = 3; i <= x; i = i + 3)
        {
            answer = answer * 2;
        }

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;
        double b = 1;
        double e = 0.0001;
        double a = Math.Cos(x * b)/ (b * b);
        while (Math.Abs(a) >= e)
        {
            b += 1;
            answer = answer + a;
            a = Math.Cos(x * b)/ (b * b);

        }

        return Math.Round(answer, 4);
    }

    public int Task_2_2()
    {
        int answer = 0;
        int a = 1, p = 1;
        while (p * a <= 30000)
        {
            p = p * a;
            a = a + 3;
        }

        answer = a - 3;

        return answer;
    }

    public int Task_2_3(double a, double h, double p)
    {
        int answer = 0;
        double b = 0;
        double s = 0;
        if (h < 0)
        {
            answer = 0;
            return answer;
        }
        else
        {
            while (s + a + b * h <= p)
            {
                s = s + a + b * h;
                answer += 1;
                b = b + 1;
            }

            return answer;
        }
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
        int n = Math.Abs(N);
        int m = Math.Abs(M);
        if (M == 0)
        {
            return (quotient, remainder);

        }
        else
        {
            while (n - m >= 0)
            {
                n = n - m;
                quotient += 1;
            }
            remainder = n;
            if ((N > 0 && M < 0) || (M >0 && N <0))
                remainder = -1 * remainder;
            return (quotient, remainder);
        }
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
        int b = 0;
        double s = 10;
        while (b < 7)
        {
            answer += s;
            s = s * 1.1;
            b = b + 1;
        }
        return Math.Round(answer, 2);
    }
    public int Task_2_7b()
    {
        int answer = 0;
        double s = 0;
        double p = 10;
        while (s < 100)
        {
            answer = answer + 1;
            s = s + p;
            p = p * 1.1;
        }
        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;
        double a = 10;
        do
        {
            answer += 1;
            a = a * 1.1;
        } while (a <= 20);

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
        double h = 1;
        for (int i = 0; i < 10; i++)
        {
            h = h/10;
        }
        double l = 0.1;
        while (l > h)
        {
            answer += 1;
            l = l / 2;
        }

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
        double S = 0; 
        double y = 0;
        int i = 1;
        double a, e = -1;
        a = Math.Cos(x) * e;
        while (Math.Abs(a) >= 0.0001)
        {
            S += a;
            i += 1;
            e = e * (-1);
            a = e * Math.Cos(i * x) / (i * i);
        }
        y = (x * x - (Math.PI * Math.PI) / 3) / 4;
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
