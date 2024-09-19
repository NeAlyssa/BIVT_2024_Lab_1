using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        Console.WriteLine("Здравствуйте!");
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

        int a = 0;
        for (a = 2; a <= 35; a += 3)
        {
            answer += a;
        }

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        for (double i = 1; i <= 10; i++)
        {
            answer += 1 / i;
        }

        return Math.Round(answer, 2);
    }
    public double Task_1_3()
    {
        double answer = 0;

        for (double i = 2; i <= 112; i += 2)
        {
            answer += i / (i + 1);
        }

        return Math.Round(answer, 2);
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        if (x == 0)
        {
            return 0;
        }
        else 
        {
            for (int i = 1; i <= 9; i++)
            {
                double power = i - 1;
                double delitel = 1;
                for (int j = 0; j < power; j++)
                {
                    delitel *= x;
                }
                answer += Math.Cos(i * x) / delitel;
            }

            return Math.Round(answer, 2);
        }
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;
        for (int i = 0; i <= 9; i++)
        {
            answer += (p + i * h) * (p + i * h);
        }

        return answer;
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
        int i = 1;
        for (i = 1; i <= 6; i++)
        {
            answer *= i;
        }
        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;
        for (int i = 1; i <= 6; i++)
        {
            int slagaemoe = 1;
            for (int j = 1; j <= i; j++)
            {
                slagaemoe = slagaemoe * j; 
            }
            answer += slagaemoe;
        }

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        double f = 1;
        double p = 1; 
        for (double k = 1; k <= 6; k++)
        {
            f *= k; //f - факториал в знаменателе
            p *= -5; //p - домножение на одно и то же число
            answer += p / f;
        }

        return  Math.Round(answer, 2);
    }
    public int Task_1_10()
    {
        int answer = 1;
        for (int i = 1; i <= 7; i++)
        {
            answer *= 3;
        }

        return answer;
    }
    public void Task_1_11()
    {
        Console.Write("Строка а: ");
        for (int i = 1; i <= 6; i++)
        { 
            Console.Write(i + " ");
        }
        Console.Write("\nСтрока б: ");
        double b = 5;
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(b + " ");
        }

    }
    public double Task_1_12(double x)
    {
        double answer = 0;
        double power = 1;
        if (x == 0)
        {
            return 0;
        }
        else
        {
            for (int i = 0; i <= 10; i++)
            {
                answer += 1 / power;
                power *= x;
            }
        }
        return Math.Round(answer, 2);
    }
    public double Task_1_13(double x)
    {
        if (x <= -1)
        {
            return 1;
        }
        else if (x > -1 && x <= 1)
        {
            return -x;
        }
        else
        {
            return -1;
        }    
    }
    public void Task_1_14()
    {
        int a = 1;
        int b = 1;
        int c = 0;
        for (int i = 1; i <= 8; i++)
        {
            Console.Write(a + " ");
            c = a + b;
            a = b;
            b = c;
        }
    }
    public double Task_1_15()
    {
        double answer = 0;

        double a = 1;
        double b = 2;
        double c = 0;
        double d = 1;
        double f = 1;
        double g = 0;
        for (int i = 1; i <= 5; i++)
        {
            answer = a / d;
            c = a + b;
            a = b;
            b = c;
            g = d + f;
            d = f;
            f = g;
        }

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;
        double zerno = 1;
        for (int i = 1; i <= 64; i++)
        {
            answer += zerno;
            zerno *= 2;
        }
        answer = answer / 15;
        power = (int)Math.Log10(answer);
        answer = Math.Round(answer / Math.Pow(10, power), 2);
        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        const double R = 6350;
        answer = Math.Sqrt(Math.Pow((R + x), 2) - Math.Pow(R, 2));
        return Math.Round(answer, 2);
    }
    public int Task_1_18(int x)
    {
        int answer = 10;
        for (int i = 0; i < x; i += 3) 
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
        const double E = 0.0001;
        for (int i = 1;; i++)
        {
            double slagaemoe = Math.Cos(i * x) / (i * i);
            if (Math.Abs(slagaemoe) < E)
            {
                break;
            }
            answer += slagaemoe;  
        }
        return Math.Round(answer, 2);
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
        double s = 0;
        int answer = 0;
        for (int n = 0; ; n++)
        {
            if (p == 0 || h <= 0)
            {
                break;
            }
            s += (a + n * h);
            if (s > p)
            {
                break;
            }
            answer++;
        }

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
        int remainder = 0, quotient = 0;
        int S = 0;
        M = Math.Abs(M);
        N = Math.Abs(N);
        for (; ;)
        {
            if (M == 0)
            {
                break;
            }
            if (N < M)
            {
                remainder = N;  
                break;
            }
            S = N - M;
            N = S;
            quotient++;
        }

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
        double answer = 10;
        double sum = 0;
        for (int i = 1; i <= 7; i++)
        {
            sum += answer;
            answer += 0.1 * answer;
        }

        return Math.Round(sum, 2);
    }
    public int Task_2_7b()
    {
        double answer = 10;
        int count = 1;
        double sum = 0;
        for (; ;)
        {
            if (sum >= 100)
            {
                break;
            }
            answer += 0.1 * answer;
            sum += answer;
            count++;
        }

        return count;
    }
    public int Task_2_7c()
    {
        double answer = 10;
        int count = 1;
        for (int i = 1; i <= 7; i++)
        {
            if (answer > 20)
            {
                break;
            }
            answer += 0.1 * answer;
            count++;
        }

        return count;
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
        double L = 0.1;
        double D = 1e-10;
        for (; ;)
        {
            if (L <= D)
            {
                break;
            }
            L /= 2;
            answer++;
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

        for (int i = 0;; i++)
        {
            double znamenatel = 2 * i + 1;
            double one = 1;
            for (int j = 0; j < i ; j++)
            {
                one *= -1;
            }
            double chislitel = 1;
            for (int k = 0; k < znamenatel; k++)
            {
                chislitel *= x;
            }
            double slagaemoe = one * chislitel / znamenatel;
            if (Math.Abs(slagaemoe) < 0.0001)
            { 
                break;
            }
            y = Math.Round(Math.Atan(x), 2);
            S += slagaemoe;
        }
        return (Math.Round(S, 2), y);
    }
    #endregion
}