using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;
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
        for (int i=2; i<=35; i+=3)
        { answer += i; }
        Console.WriteLine(answer.ToString());

        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (int i=1; i<=10; i++)
        { answer = answer + 1 / (double) i; }
        answer = Math.Round(answer, 2);
        Console.WriteLine("{0:f2}", answer);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (int i=2, j=3; j<=113; i+=2, j+=2)
        { answer += (double)i / (double)j;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine("{0:f2}", answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        for (double i = 1.0, j = 1.0; i <= 9; i++, j *= x)
        { if (x != 0) {
                answer += Math.Cos(x * i) / j; }
            else { answer = 0; } }
        answer = Math.Round(answer, 2);
        Console.WriteLine("{0:f2}", answer);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i=0; i<=9;i++)
        {
            answer += (p + h * i) * (p + h * i);
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine("{0:f2}", answer);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * x * x - 7 * x;
        answer = Math.Round(answer, 2);
        Console.WriteLine("{0:f2}", answer);

        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for (int i=1; i<=6; i++)
        {
            answer *= i;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        for(int i = 1; i<=6; i++)
        {
            int proizved = 1;
            for(int j = 1; j<=i; j++)
            {
                proizved *= j;
            }
            answer += proizved;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        for (int i = 1; i <= 6; i++)
        {
            int fact = 1;
            for (int j = 1; j <= i; j++)
            {
                fact *= j;
            }
            answer += Math.Pow(-1,i)*Math.Pow(5,i)/ fact;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine("{0:f2}", answer);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        for(int i = 1; i <=7; i++)
        {
            answer *= 3;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        
        for (int i = 1; i<=6; i++)
        {
            Console.Write(i+" ");
        }

        Console.WriteLine();

        for (int i = 1; i <= 6; i++)
        {
            Console.Write(5 + " ");
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;
        // code here
        if (x != 0) { 
        double x_1 = 1;
        for (int i=1; i<=11; i++)
        {
            answer += 1 / x_1;
            x_1 *= x;
        }
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine("{0:f2}", answer);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if ( x <= -1)
        {
            answer = 1;
        }
        else
        {
            if (x>=-1 && x<=1)
            {
                answer = -x;
            }
            else
            {
                answer = -1;
            }
        }
        // end
        Console.WriteLine("{0:f2}", answer);
        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a_1 = 1;
        Console.Write(a_1+" ");
        int a_2 = 1;
        Console.Write(a_2 + " ");
        int summ = 0;
        for (int i =3; i<=8; i++)
        {
            summ = a_1 + a_2;
            Console.Write(summ + " ");
            a_1 = a_2;
            a_2 = summ;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double chisl_1 = 1;
        double chisl_2 = 2;
        double znam_1 = 1;
        double znam_2 = 1;
        double summ_1 = 0;
        double summ_2 = 0;
        for (int i = 3; i <= 5; i++)
        {
            summ_1 = chisl_1 + chisl_2;
            summ_2 = znam_1 + znam_2;
            chisl_1 = chisl_2;
            chisl_2 = summ_1;
            znam_1 = znam_2;
            znam_2 = summ_2;
            answer = chisl_2 / znam_2;
        }
        // end
        answer = Math.Round(answer, 2);
        Console.WriteLine("{0:f2}", answer);
        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;
        double seed = 1;
        double summ = 0;

        // code here
        for (int i = 1; i<=64; i++)
        {
            summ += seed;
            seed = seed * 2;
        }
        Console.WriteLine("{0:f2}", summ);
        answer = summ / 15;
        while (answer > 10)
        {
            answer /= 10;
            power++;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine("{0:f2}, {1:f2}", answer, power);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        int r = 6350;
        // code here
        answer = Math.Sqrt((x + r) * (x + r) - r * r);
        // end
        answer = Math.Round(answer, 2);
        Console.WriteLine("{0:f2}", answer);

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int amebs = 10;
        for (int i = 3; i<=x; i+=3)
        {
            amebs *= 2;
        }
        // end
        answer = amebs;
        Console.WriteLine(answer);
        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here
        double num = Math.Cos(x);
        answer += num;
        double n = 1;
        while (Math.Abs(num)>=0.0001)
        {
            n++;
            num = Math.Cos(x * n) / (n * n);
            answer += num;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine("{0:f2}", answer);
        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 0;
        int L = 1;
        int n = 1;
        // code here
        while (L<=30000)
        {
            n += 3;
            L *= n;

        }
        answer = n - 3;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_3(double a, double h, double p)
    {
        int answer = 0;
        double summ = 0;
        // code here
        if (h < 0 && a < p)
        {
            answer = 0;
        }
        else
        {
            while (summ <= p)
            {
                summ += (a + h * answer);
                answer++;
            }
            answer -= 1;
        }
        Console.WriteLine(answer);
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
        int abs_n = Math.Abs(N);
        int abs_m = Math.Abs(M);
        // code here
        if (M != 0)
        {
            while (abs_n >= abs_m)
            {
                quotient++;
                abs_n -= abs_m;
            }
            remainder = abs_n;
            if ((N < 0 && M > 0) || (N > 0 && M < 0))
            {
                quotient = -quotient;
                remainder = -remainder;
            }
        }
        // end
        Console.WriteLine("{0:f2} {1:f2}",quotient, remainder);
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
        double km = 10;
        for (int i = 1; i<=7; i++)
        {
            answer += km;
            km *= 1.1;

        }
        // end
        answer = Math.Round(answer, 2);
        Console.WriteLine("{0:f2}",answer);
        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;
        double summ = 0;
        double km = 10;
        // code here
        while (summ <= 100)
        {
            summ += km;
            km *= 1.1;
            answer++;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 1;
        double km = 10;
        // code here
        while (km<=20)
        {
            answer++;
            km *= 1.1;
        }
        answer -= 1;
        // end
        Console.WriteLine(answer);
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
        double d_a = Math.Pow(10, -10);
        double L = 0.1;
        while (L > d_a)
        {
            answer++;
            L /= 2;

        }
        Console.WriteLine(answer);
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
        double i = 1;
        double num = 1;
        S += 1;
        while (Math.Abs(num) >= 0.0001)
        {
            double fact = 1;
            for (int j=1; j<=i; j++)
            {
                fact *= j;
            }
            num = Math.Cos(i * x) / fact;
            S += num;
            i++;
        }
        y = Math.Exp(Math.Cos(x))*Math.Cos(Math.Sin(x));
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
        Console.WriteLine("{0:f2} {1:f2}", S, y);
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