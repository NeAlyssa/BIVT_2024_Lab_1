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
        int s = 0;
        for (int i = 2; i <= 35; i += 3)
            s += i;
        answer = s;
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double i = 1; i <= 10; i ++)
        {
            answer += 1/i;
        }
        // end
        answer = Math.Round(answer, 2);
        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for(double i = 2; i <= 112; i+=2)
            answer += i / (i + 1);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        double p = 1;
        // code here
        for (double i = 1; i <= 9; i++)
        {
            answer += Math.Cos(i * x) /p;
            p *= x;
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
            answer += (p + i * h) * (p + i * h);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = Math.Round(x*x/2-7*x, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for (int i = 1; i <= 6; i++)
            answer *= i;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;
        int s = 1;
        // code here;
        for (int i = 1; i <= 6; i++)
        {
            s *= i;
            answer += s;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        double s = 1; 
        double p = 1;
        // code here;
        for (int i = 1; i <= 6; i++)
        {
            s *= i;
            p *= 5;
            answer += (-1)*((i%2)*2-1)*p/s;
            //Console.WriteLine(answer);
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        for (int i = 1; i <= 7; i++)
            answer *= 3;
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        Console.WriteLine("1 2 3 4 5 6");
        Console.WriteLine("5 5 5 5 5 5");
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;
        // code here
        if (x == 0)
                return 0;
        double p = 1;
        for (double i = 0; i <= 10; i++)
        {
            answer += 1 / p;
            p *= x;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) return 1;
        if (x > 1) return -1;
        return -x;
        // end

        //return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a = 1, b = 1, c = 0;
        Console.WriteLine(1);
        Console.WriteLine(1);
        for (int i = 3; i <= 8; i++)
        {
            c = a + b;
            Console.WriteLine(c);
            a = b;
            b = c;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double a1 = 1, a2 = 1;
        double b1 = 2, b2 = 1;
        double c1 = 0, c2 = 0;
        for (int i = 3; i <= 5; i++)
        {
            c1 = a1 + b1;
            c2 = a2 + b2;
            a1 = b1;
            a2 = b2;
            b1 = c1;
            b2 = c2;
        }
        answer = Math.Round(b1 / b2,2);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double n = 1;
        for (int i = 1; i <= 64; i++)
        {
            answer += n;
            n *= 2;
        }
        answer /= 15;
        while (answer >= 10)
        {
            answer /= 10;
            power++;
        }
        answer = Math.Round(answer,2);
        // end
        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double r = 6350, h = r + x;
        answer = Math.Round(Math.Sqrt(h*h-r*r),2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here
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
        int n = 1, p = 1;
        while (p <= 30000)
        {
            n+=3;
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
        double answer = 1;

        // code here
        if ((x <= -1) || (x >=1))
            return 0;
        double p = 1;
        while (p >= 0.0001)
        {
            p *= x*x;
            answer += p;
        }
        answer = Math.Round(answer,2);
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
        for (int i = 10; i <= 100000; i *= 2)
            answer += 3;
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
        for (double i = 10; i <= 20; i *= 1.08)
            answer ++;
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
        int answer = 2;

        // code here;
        double a1 = 1, a2 = 1;
        double b1 = 2, b2 = 1;
        double c1 = 0, c2 = 0;
        while (Math.Abs(a1/a2 - b1/b2) > 0.001)
        {
            answer ++;
            c1 = a1 + b1;
            c2 = a2 + b2;
            a1 = b1;
            a2 = b2;
            b1 = c1;
            b2 = c2;
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
        double f = 1, i = 0, a = 1, p = 1;
        while (a >= 0.0001)
        {
            S += a;
            i++;
            p *= x * x;
            f *= i;
            a = (2 * i + 1) * p / f;
        }
        double x2 = x * x;
        /*
        y = f = i = 1;
        a = x2;
        while (a >= 0.0001)
        {
            y += a;
            x2 *= x2;
            i++;
            f *= i;
            a = x2 / f;
        }
        y *= 1 + 2 * x * x;
        */
        y = (1 + 2*x2) * Math.Pow(Math.E, x2);
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