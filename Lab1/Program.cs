using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

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
        program.Task_1_11();
        //program.Task_1_12(0.9);
        //program.Task_1_13(-1.5);
        program.Task_1_14();
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

        // code here\
        int s = 0;
        for (int i = 2; i <= 35; i = i + 3)
            s = s + i;
        answer = s;
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        double s = 1;
        for (double i = 2; i <= 10; i++)
            s = s + 1.0 / i;
        answer = (Math.Round(s, 2));
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double s = 0;
        for (double i = 2; i <= 112; i+=2)
            s = s + i / (i + 1);
        answer = (Math.Round(s, 0));
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double s = Math.Cos(x);
        double x1 = 1;
        for (double i = 2; i <= 9; i++)
        {

            x1 = x1 * x;

            s = s + Math.Cos(i * x) / x1;
            if (x1 == 0) s = 0;
        }
        s = (Math.Round(s, 2));
        answer = s;
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        double s = p * p;
        for (double i = 1; i < 10; i++)
        {
            s = s + (p + i * h) * (p + i * h);
        }
        answer = s;
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        double y = (0.5 * x * x - 7 * x);
        answer = Math.Round(y,2);    
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int s = 1;
        int i = 1;
        while (i <= 6)
        {
            s *= i;
            i++;
        }
        answer = s;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int s = 0;
        int i1 = 1;
        int i = 1;
        while (i <= 6)
        {
            i1 *= i;
            s += i1;
            i++;
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
        double x = 1;
        double x5 = 1;
        double f = 1;
        for (double i = 1; i <= 6; i++)
        {
            x = -x;
            x5 *= 5;
            f *= i;
            s += (x * x5 / f);
            answer = Math.Round(s, 2);
        }
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int i = 3;
        int j = 1;
        while (j <= 6)
        {
            i *= 3;
            j++;
        }
        answer =i;
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(i);
        }
        Console.WriteLine();
        int j = 5;
        for (int h = 1; h <= 6; h++)
        {
            Console.Write(j);
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double s = 1;
        double x1 = 1;
        for (double j = 1; j <= 10; j++)
        {
            x1 *= x;
            s += 1 / (x1);
        }
        if (x == 0)
            s = 0;
        answer = Math.Round(s, 2);
        // end
        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;


        {
            if (x <= -1)
            {
                answer = 1;

            }
            if (x > -1 && x <= 1 && x != 0)
            {
                answer = -x;
            }
            if (x > 1)
            {
                answer = -1;
            }
        }

        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int i1 = 1;
        int i2 = 1;
        Console.Write(i1 + " ");
        Console.Write(i2 + " ");
        int j = 2;
        while (j <= 7)
        {
            int i = i1 + i2;
            Console.Write(i + " ");
            i1 = i2;
            i2 = i;
            j++;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double ch1 = 1;
        double ch2 = 2;
        double zn1 = 1;
        double zn2 = 1;
        double j = 3;
        while (j <= 5)
        {
            double ch = ch1 + ch2;
            double zn = zn1 + zn2;
            double chislo = ch / zn;
            ch1 = ch2;
            ch2 = ch;
            zn1 = zn2;
            zn2 = zn;
            j++;
            if (j == 6)
                answer = Math.Round(chislo, 1);
        }
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double i = 1;
        double summ = 1;
        for (int j = 1; j <= 63; j++)
        {
            i = i * 2;
            summ += i;
        }
        double suma = summ / 15;
        int r = (int)Math.Log10(suma);
        power = r;
        for (int g = 1; g <= r; g++)
        {
            suma /= 10;
        }
        answer = Math.Round(suma, 3);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        const double R = 6350;
        answer = Math.Round(Math.Sqrt(((R + x))*(R+x) - Math.Pow(R, 2)),2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int kl =10;
        int k = 1;
        while (k <= (x / 3))
        {
            kl *= 2;
            k ++;
        }
        answer = kl;
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
        int L = 30000;
        int pr = 1;
        int n = 1;
        while (pr <= L)
        {
            n += 3;
            pr *= n;
        }
        answer = n-3;
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
        double s = 1;
        double e = 0.0001;
        if (x == 0)
        {
            answer = 1;
            return answer;
            
        }
        if (x == 1)
        {
            answer = 0;
            return answer;
        }
        for (int i = 2; Math.Pow(x, i) >= e; i+=2)
        {
            s += Math.Pow(x, i);
        }
        answer =Math.Round( s,2);
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
        int kl = 10;
        int i = 3;
        while (kl <=100000)
        {
            kl *= 2;
            i += 3;
        }
        answer = i - 3;
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
        double vklad = 10000;
        int i = 1;
        while (vklad <= 20000)
            {
            vklad *= 1.08;
            i++;
            }
        answer = i-1;
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
        double ch1 = 1;
        double ch2 = 2;
        double zn1 = 1;
        double zn2 = 1;
        int j = 3;
        double chislo1 = 0;
        double chislo2 = 110000;
        while (Math.Abs(chislo1-chislo2)>=0.001)
        {
            double ch = ch1 + ch2;
            double zn = zn1 + zn2;
            chislo1 = ch / zn;
            ch1 = ch2;
            ch2 = ch;
            zn1 = zn2;
            zn2 = zn;
            chislo2 = ch1 / zn1;
            j++;
        }
        answer = j - 1;
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
        S = 0;
        int i = 1;
        double v1 = 0;
        double y2 = 0;
        while (Math.Abs((Math.Pow(x, i) * Math.Sin((i * Math.PI) / 4))) >= 0.0001)
        {
            y2 = y;
            S += (Math.Pow(x, i) * Math.Sin((i * Math.PI) / 4));
            y = ((x * Math.Sin(Math.PI / 4)) / (1 - 2 * x * Math.Cos(Math.PI / 4) + x * x));
            i++;
        }

        y = Math.Round(y2, 2);
        S = Math.Round(((x * Math.Sin(Math.PI / 4)) / (1 - 2 * x * Math.Cos(Math.PI / 4) + x * x)), 2);
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