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
        {
            s += i;
        }
        answer = s;
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        double s = 0;
        for (double i = 1; i <= 10; i++)
        {
            s += 1 / i;
        }
        answer = s;
        answer = Math.Round(answer * 100) / 100;
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double s = 0;
        for (int i = 2; i <= 112; i += 2)
        {
            s += (double)i / (i + 1);
        }

        answer = Math.Round(s);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double s = 0;
        double a = 1;
        if (x != 0)
        {
            for (double i = 1; i <= 9; i++)
            {
                if (i > 1)
                {
                    a *= x;
                }
                s += Math.Cos(i * x) / a;
            }
        }
        else
        {
            s = 0;
        }
        answer = Math.Round(s, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        double s = 0;
        for (double i = 0; i <= 9; i++)
        {
            s += Math.Pow((p + i * h), 2);
        }
        answer = s;
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        double y = 0;
        y = Math.Round(0.5 * Math.Pow(x, 2) - 7 * x, 2);
        answer = y;
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int a = 1;
        for (int i = 1; i <= 6; i++)
        {
            a *= i;
        }
        answer = a;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int s = 0;
        int f = 1;

        for (int i = 1; i <= 6; i++)
        {
            f *= i; 
            s += f; 
        }
        answer = s;
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double s = 0;
        double f = 1;
        double a = 1;
        for (int i = 1; i <= 6; i++)
        {
            f *= i;
            a *= 5;
            s += (i % 2 == 0 ? 1 : -1) * (a / f);
        }
        answer = Math.Round(s, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int s = 3;
        for (int i = 1; i < 7; i++)
        {
            s *= 3;
        }
        answer = s;
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(i + " ");
        }
        for (int i = 0; i < 6; i++)
        {
            Console.Write(5 + " ");
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double s = 1;
        double a = 1;
        for (int i = 1; i <= 10; i++)
        {
            a /= (x != 0 ? x : 1);
            s += a;
        }
        s *= (x != 0 ? 1 : 0);
        answer = Math.Round(s, 2);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        double y = 0;
        if (x <= -1)
        {
            y = 1;
        }
        else if ((-1 < x) & (x <= 1))
        {
            y = -x;
        }
        else
        { y = -1; }
        answer = y;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a = 1;
        int b = 1;
        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine(a);
            int s = a + b;
            a = b;
            b = s;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        int a = 1, a1 = 1;
        int b = 2, b1 = 1;
        int c = 3, c1 = 2;
        for (int i = 4; i <= 5; i++)
        {
            int d = b + c;
            int d1 = b1 + c1;
            b = c;
            b1 = c1;
            c = d;
            c1 = d1;
        }
        answer = (double)c / c1;
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double s = 0;
        double a = 1;
        for (int i = 0; i <= 63; i++)
        {
            s += a;
            a *= 2;
        }
        s = s / 15;
        power = (int)Math.Floor(Math.Log10(s));
        double b = 1;
        for (int i = 0; i < power; i++)
        {
            b *= 10;
        }
        answer = Math.Round((s / b), 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here

        int R = 6350;
        answer = Math.Round(Math.Sqrt(Math.Pow(R + x, 2) - Math.Pow(R, 2)), 2);

        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int a = 10;
        int b = 1;
        int c = (int)(x / 3);
        for (int i = 1; i <= c; i++)
        {
            b = a * 2;
            a *= 2;
        }
        answer = b;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here
        double s = 0;
        double e = 0.0001;
        for (int i = 1; Math.Abs(Math.Cos(i * x) / (Math.Pow(i, 2))) >= e; i++)
        {
            s += Math.Cos(i * x) / (Math.Pow(i, 2));
        }
        answer = s;
        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 0;

        // Числители и знаменатели двух предыдущих членов последовательности
        int num1 = 1, num2 = 2; // числители
        int denom1 = 1, denom2 = 1; // знаменатели

        // Временные переменные для хранения текущего числителя и знаменателя
        int currentNum = 0;
        int currentDenom = 0;

        // Вычисляем 3-й, 4-й и 5-й члены последовательности
        for (int i = 3; i <= 5; i++)
        {
            currentNum = num1 + num2;
            currentDenom = denom1 + denom2;

            // Сдвигаем предыдущие значения для следующей итерации
            num1 = num2;
            denom1 = denom2;
            num2 = currentNum;
            denom2 = currentDenom;
        }

        // Ответ — это результат деления числителя на знаменатель 5-го члена
        answer = currentNum / currentDenom;

        // Возвращаем ответ
        return answer;

    }
    public int Task_2_3(double a, double h, double p)
    {
        int answer = 0;

        // code here
        double s = 0;
        int c = 0;
        while (true)
        {
            if (a < p)
            {
                if (h > 0)
                {
                    s += a + c * h;
                    c++;
                    if (s > p)
                    {
                        c--;
                        break;
                    }
                }
                else
                {
                    c = 0;
                    break;
                }
            }
            else if (a == p)
            {
                c = 1;
                break;
            }
            else if (a > p)
            {
                c = 0;
                break;
            }
        }

        answer = c;
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
        int n = N;
        int m = M;
        int chisl = Math.Abs(N);
        N = Math.Abs(N);
        M = Math.Abs(M);
        if (M == 0)
        {
            quotient = 0;
            remainder = 0;
        }
        else
        {
            if (N < M)
            {
                quotient = 0;
                remainder = M;
            }
            else
            {
                while (N - M >= 0)
                {
                    N -= M;
                    quotient++;
                }
                remainder = chisl - M * quotient;
            }
        }
        if (n * m < 0)
        {
            quotient = -quotient;
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
        double b = a;
        double s = a;
        for (int i = 1; i <= 6; i++)
        {
            b += b * 0.1;
            s += b;
        }
        answer = Math.Round(s, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double a = 10;
        double b = a;
        double s = a;
        int c = 0;
        for (int i = 1; s < 100; i++)
        {
            b += b * 0.1;
            s += b;
            c = i;
        }
        answer = c + 1;
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double a = 10;
        double b = a;
        double s = a;
        int c = 0;
        for (int i = 1; b <= 20; i++)
        {
            b += b * 0.1;
            s += b;
            c = i;
        }
        answer = c;
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
        double L = 0.1;
        double D = Math.Pow(10, -10);
        int a = 0;
        for (int i = 1; L > D; i++)
        {
            L = L * 0.5;
            a = i;
        }
        answer = a;
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
        S = 1;
        double a = -1;
        double f = 1;
        double g = 1;

        for (int n = 1; Math.Abs(a) >= 0.0001; n++)
        {
            g *= x * x;
            if (n > 0)
            {
                f *= (2 * n - 1) * (2 * n);
            }
            a = g / f;
            S += a;
        }
        S = Math.Round(S, 4);
        y = Math.Round(Math.Cosh(x), 4);
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