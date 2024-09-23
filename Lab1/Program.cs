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
        program.Task_3_3(0.1);
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
        for (int i = 2;i <= 35;i += 3)
        {
            s = s + i;
        };
        answer = s;
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double i = 1; i <= 10; i++)
        {
            answer += 1 / i;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2, j = 3; i <= 112; i += 2, j += 2)
        {
            answer += i / j;
        }
        answer = Math.Round(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if (x == 0) return 0;
        double d = 1;
        for(int i = 1; i <= 9; i++)
        {
            answer += Math.Cos(x * i) / d;
            d *= x;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for(int i = 0; i <= 9; i++)
        {
            answer += (p + i * h) * (p + i * h);
        }
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
        answer = 1;
        for (int i = 1; i <= 6; i++)
        {
            answer *= i;
        }
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int s = 1;
        for(int i = 1; i <= 6; i++)
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

        // code here;
        double s = 1;
        int p = 1;
        double p5 = 1;
        for (int i = 1; i <= 6; i++)
        {
            s *= i;
            p = -p;
            p5 *= 5;
            answer += p * p5 / s;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int p = 1;
        for(int i = 1; i <= 7; i++)
        {
            p *= 3;
        }
        answer = p;
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(i);
            Console.Write(' ');
        }

        Console.WriteLine();

        for (int i = 1; i <= 6; i++)
        {
            Console.Write(5);
            Console.Write(' ');
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x == 0) return 0;
        answer += 1;
        double p = 1;
        for (int i = 1; i <= 10; i++)
        {
            p = p * x;
            answer += 1 / p;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 1;
        else if (x > 1) answer = -1;
        else answer = -x;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int n1 = 1;
        int n2 = 1;
        int reserve;
        Console.Write(n1);
        Console.Write(' ');
        Console.Write(n2);
        Console.Write(' ');

        for (int j = 0; j < 8; j++)
        {
            Console.Write(n1 + n2);
            Console.Write(' ');
            reserve = n1;
            n1 = n2;
            n2 = reserve + n2;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        int num1 = 1;
        int den1 = 1;
        int num2 = 2;
        int den2 = 1;
        int s1, s2;
        for (int i = 0; i <= 3; i++)
        {
            s1 = num1 + num2;
            s2 = den1 + den2;
            num1 = num2;
            den1 = den2;
            num2 = s1;
            den2 = s2;
        }
        answer = Math.Round((double)num2 / den2, 1);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double n = 1;
        answer += 1 / 15;
        for (int i = 0; i < 63; i++)
        {
            n *= 2;
            answer += n / 15;
            
        }
        while (answer > 10)
        {
            answer /= 10;
            power += 1;
        }
        answer = Math.Round(answer, 2);

        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        int r = 6350;
        double h = r + x;
        for (int i = 0; i < 10; i++)
        {
            answer = Math.Sqrt(h * h - r * r);
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int n = 10;
        for (int i = 0; i < x; i += 3)
        {
            n = n * 2;
        }
        answer = n;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here
        int i = 1;
        double n = Math.Cos(i * x) / (i * i);
        do
        {
            answer += Math.Cos(i * x) / (i * i);
            i++;
            n = Math.Cos(i * x) / (i * i);
        } while (Math.Abs(n) >= 0.0001);
        
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
        if (h < 0) return 0;
        double s = a;
        while (s <= p)
        {
            answer++;
            s += a + answer * h;
        }
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
        if (M == 0) return (0, 0);
        while (Math.Abs(N) >= Math.Abs(M))
        {
            N -= M;
            quotient++;
            remainder = Math.Abs(N);
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
        int i = 1;
        double s = 10;
        double last = s;
        do
        {
            last *= 1.1;
            s += last;
            i++;
        } while (i < 7);
        answer = Math.Round(s, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        answer++;
        double s = 10;
        double last = s;
        while (s < 100)
        {
            last *= 1.1;
            s += last;
            answer++;
        }
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double last = 10;
        while (last <= 20)
        {
            last *= 1.1;
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
        while (l > 0.0000000001)
        {
            l /= 2;
            answer += 1;
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
        int i = 0;
        double f = 1;
        double n = 0;
        S = 1;
        while (true)
        {
            i++;
            f *= i;
            n = Math.Cos(i * x) / f;
            if (Math.Abs(n) < 0.0001) break;
            S += n;
        }
        y = Math.Exp(Math.Cos(x)) * Math.Cos(Math.Sin(x));
        y = Math.Round(y, 2);
        S = Math.Round(S, 2);
        //Console.WriteLine("{0:f} {1:f}", S, y); 


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