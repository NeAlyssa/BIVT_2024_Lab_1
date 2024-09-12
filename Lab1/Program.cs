using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
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
        for (int i = 2; i <= 35; i += 3)
            answer += i;
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double i = 1; i <= 10; i++)
            answer += 1 / i;
        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2; i <= 112; i+=2)
            answer += i / (i + 1);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if (x == 0)
            return answer;
        double denom = 1;
        for (int i = 0; i <= 8; i++)
        {
            answer += Math.Cos(x * (i + 1)) * denom;
            denom /= x;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;
        // code here
        double prev = p;
        for (double i = 0; i <= 9; i++)
        {
            answer += Math.Pow(prev, 2);
            prev += h;
        }
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        for (double i = -4; i <= 4.0005; i += 0.5)
        {
            double y = 0.5 * Math.Pow(i, 2) - 7 * i;
            Console.WriteLine($"y={y:f1}\tx={i:f1}");
        }
        answer = 0.5 * Math.Pow(x, 2) - 7 * x;
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        answer = 1;
        for (int i = 2; i <= 6; i++)
            answer *= i;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int prev = 1;
        for (int i = 1; i <= 6; i++)
        {
            prev *= i;
            answer += prev;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        int sign = -1;
        int num = 5;
        double denom = 1;
        for (int i = 2; i <= 7; i++)
        {
            answer += sign * num / denom;
            sign *= -1;
            num *= 5; denom *= i;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        answer = 1;
        for (int i = 0; i < 7; i++)
            answer *= 3;
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task

        // code here
        for (int i = 1; i <= 6; i ++)
            Console.Write($"{i} ");
        Console.WriteLine();
        for (int i = 1; i <= 6; i++)
            Console.Write("5 ");

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x == 0)
            return answer;
        double prev = 1;
        answer += prev;
        for (int i = 0; i < 10; i++)
        {
            prev /= x;
            answer += prev;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here

        for (double i = -1.5; i <= 1.50005; i+=0.1)
        {
            double y;
            if (i <= -1)
                y = 1;
            else if (i > 1)
                y = -1;
            else
                y = -x;
            Console.WriteLine($"y={y:f1}\tx={i:f1}");
        }

        if (x <= -1)
            answer = 1;
        else if (x > 1)
            answer = -1;
        else
            answer = -x;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task

        // code here
        int first = 0, second = 1;
        for (int i = 0; i < 8; i++)
        {
            Console.Write($"{second} ");
            int temp = second;
            second += first;
            first = temp;
        }

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        int fnum = 1, snum = 2;
        double fden = 1, sden = 1;
        for (int i = 0; i < 3; i++)
        {
            int tempnum = snum;
            snum += fnum;
            fnum = tempnum;

            double tempdenom = sden;
            sden += fden;
            fden = tempdenom;
        }
        answer = snum / sden;
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double start = 1 / 15.0;

        for (int i = 0; i < 64; i++)
        {
            answer += start;
            start *= 2;
        }
        power = (int)Math.Log10(answer);
        answer /= Math.Pow(10, power);
        answer = Math.Round(answer, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        const int Radius = 6350;
        for (int i = 1; i <= 10; i++)
        {
            double distance = Math.Sqrt(i * (2 * Radius + i));
            Console.WriteLine($"distance={distance:f2}");
        }
        answer = Math.Sqrt(x * (2 * Radius + x));
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int amoebas = 10;
        for (int i = 3; i <= x; i += 3)
        {
            amoebas *= 2;
            Console.WriteLine($"amoebas={amoebas}");
        }
        answer = amoebas;
        for (int i = x; i <= 24; i += 3)
        {
            amoebas *= 2;
            Console.WriteLine($"amoebas={amoebas}");
        }

        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here
        double eps = 0.0001;
        double i = 1;
        double add = 1;
        do
        {
            add = Math.Cos(i * x) / Math.Pow(i, 2);
            i += 1;
            answer += add;
        } while (Math.Abs(add) >= eps);
        answer = Math.Round(answer, 2);
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
        double curElem = a;
        double curSum = 0;
        if (h <= 0)
        {
            return 0;
        }
        while (curSum + curElem <= p)
        {
            answer += 1;
            curSum += curElem;
            curElem += h;
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
        if (M == 0)
            return (quotient, remainder);
        
        while (Math.Abs(N) >= Math.Abs(M))
        {
            N -= M;
            quotient++;
        }
        remainder = Math.Abs(N);
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
        double day = 10;

        while (i <= 7)
        {
            answer += day;
            day *= 1.1;
            i += 1;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double distCounter = 0;
        double start = 10;
        while (distCounter < 100)
        {
            distCounter += start;
            start *= 1.1;
            answer += 1;
        }
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double start = 10;
        while (start < 20) 
        {
            start *= 1.1;
            answer += 1;
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
        double dA = Math.Pow(10, -10);
        double start = 0.1;
        while (start > dA)
        {
            start /= 2;
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
        const double eps = 0.0001;
        for (double j = 0.1; j <= 1.0005; j += 0.1)
        {
            double mathcos = Math.Cos(j);
            double res = 0;
            double i = 0, denom = 1, num = 1, add = 1;
            int sign = 1;
            do
            {
                add = sign * num / denom;
                res += add;
                denom *= (2 * i + 1) * (2 * i + 2);
                sign *= -1;
                num *= j * j;
                i += 1;
            } while (Math.Abs(add) >= eps);

            Console.WriteLine($"TaylorCos={res:f2}\ty={mathcos:f2}");
        }

        double it = 0, den = 1, nm = 1, ad = 1;
        int sig = 1;
        do
        {
            ad = sig * nm / den;
            S += ad;
            den *= (2 * it + 1) * (2 * it + 2);
            sig *= -1;
            nm *= x * x;
            it += 1;
        } while (Math.Abs(ad) >= eps);

        S = Math.Round(S, 2);
        y = Math.Round(Math.Cos(x), 2);
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

        // end

        return (S, y);
    }
    #endregion
}