using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

public partial class Program
{
    public static void Main()
    {
        Program program = new Program();
        Console.WriteLine(Math.Round(1.123456, 2));
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
        // program.Task_1_16();
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
        for (int i = 2; i < 36; i += 3)
        {
            answer = i + answer;
        }
        return answer;

    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double i = 1; i < 11; i++)
        {
            answer += (1 / i);
        }

        // end
        Console.WriteLine(answer);
        Console.WriteLine(Math.Round(answer, 2));
        return Math.Round(answer, 2);
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2; i < 113; i = i + 2)
        {
            answer = answer + (i / (i + 1));

        }

        // end

        return Math.Round(answer, 2);

    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        for (double i = 1; i <= 9; i++)
        {
            
            answer = answer + Math.Cos(i * x) /x;
            x *= x;
        }

        // end


        return Math.Round(answer, 2);
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (double i = 0; i <= 9; i++)
        {
            answer = answer + (p + i * h) * (p + i * h);
        }

        // end


        return Math.Round(answer, 2);
    }
    public double Task_1_6(double x)
    {
        return Math.Round(0.5 * x * x - 7 * x, 2);
    }
    public int Task_1_7()
    {
        int answer = 1;

        for (int i = 2; i <= 6; i++)
        {
            answer = answer * i;
        }

        // end
        return answer;


    }
    public int Task_1_8()
    {
        int answer = 0;
        int factorial = 1;
        // code here;
        for (int i = 1; i <= 6; i++)
        {
            factorial = factorial * i;
            answer = answer + factorial;
        }
        // end
        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        int factorial = 1;
        int x = 5;
        int n = -1;
        for (int i = 1; i <= 6; i++)
        {
            factorial *= i;
            if (i % 2 == 0)
                n = 1;
            if (i % 2 == 1)
                n = -1;
            answer += n * x / factorial;
            x *= 5;
        }
            // end

            return Math.Round(answer, 2);
    }
    public int Task_1_10()
    {
        int answer = 1;
        // code here
        for (int i = 1; i <= 7; i += 1)
        {
            answer = 3 * answer;
        }
        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i < 7; i++)
        {
            Console.WriteLine(i);
            Console.WriteLine(5);
        }
        // code here
    }
    public double Task_1_12(double x)
    {
        double answer = 1;
        // code here
        double k = x;
        for (double i = 1; i <= 10; i++)
        {
            
            answer += (1 / k);
            k *= x;
        }
        answer = Math.Round(answer, 2);

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            answer = 1;
        else if (x > -1 & x <= 1)
            answer = -x;
        else
            answer = -1;

        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int end = 21;
        int k = 1;
        Console.WriteLine(1);
        for (int i = 1; i <= end; i += k)
        {
            Console.WriteLine(i);
            k = i - k;
        }
    }
    public double Task_1_15()
    {
        double answer = 0;
        double ch1 = 1, zn1 = 1, ch2 = 2, zn2 = 1;
        for (int y = 1; y < 4; y++)
        {
            double ch3 = ch1 + ch2;
            double zn3 = zn1 + zn2;
            ch1 = ch2;
            zn1 = zn2;
            ch2 = ch3;
            zn2 = zn3;
        }
        answer = ch2 / zn2;
        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 1;
        int power = 0;
        double zerno = 1;
        for (int i = 1; i < 64; i++)
        {
            zerno *= 2;
            answer += zerno;
        }
        answer /= 15;
        while (answer >= 10)
        {
            power++;
            answer /= 10;
        }
        return (Math.Round(answer, 2), power);
    }
    public double Task_1_17(double height)
    {
        double answer = 0;
        answer = Math.Round(Math.Sqrt(Math.Pow(6350 + height, 2) - Math.Pow(6350, 2)), 2);
        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;
        for (int o = 3; o <= x; o += 3)
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
        double znach = 1;
        double n = 1;
        while (Math.Abs(znach) >= 0.0001)
        {
            znach = Math.Cos(n * x) / (n * n);
            n += 1;
            answer = answer + znach;
        }
        answer -= znach;
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
        double answer = 0;
        int k = 0;

        // code here
        while (answer < p)
        {
            for (double i = 0; ; i++)
            {
                k += 1;
                answer = answer + a + i * h;
            }
        }
        return k;
    }
    public double Task_2_4(double x)
    {
        double answer = 0;


        return answer;
    }
    public (int, int) Task_2_5(int N, int M)
    {
        int quotient = 0, remainder = N;

        // code here
        while (remainder >= M)
        {
            quotient += 1;
            remainder = remainder - M;
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
        double start = 10;
        // code here
        for (double i = 2; i <= 7; i++)
        {
            start = start + start * 0.1;
        }
        Console.WriteLine(start);
        // end

        return start;
    }
    public int Task_2_7b()
    {
        double answer = 10;

        // code here
        for (double i = 2; i < 200; i++)
        {
            answer = answer + answer * 0.1;
            if (answer == 100)
            {
                answer = i;
                break;
            }
        }
        // end

        return int(answer);
    }
    public int Task_2_7c()
    {
        double answer = 10;

        // code here
        for (double i = 2; i <= 100; i++)
        {
            answer = answer * 0.1;
            if (answer >= 20)
            {
                answer = i;
                break;
            }
        }
        // end

        return int (answer);
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
        double l = 0.1;
        double athom = Math.Pow(10, -10);
        // code here;
        while (l > athom)
        {
            l = l / 2;
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
        double S = 1, y = 0;
        double cosinus = Math.Cos(x);
        double sinus = Math.Sin(x);
        double factorial = 1;
        for (int j = 1; ; j++)
        {
            factorial *= j;

            double sigma = Math.Cos(j * x) / factorial;
            if (Math.Abs(sigma) < 0.0001)
            {
                break;
            }
            else
            {
                S += sigma;
            }
        }
        y = Math.Pow(Math.E, cosinus) * Math.Cos(sinus);
        System.Console.WriteLine(S);
        System.Console.WriteLine(y);
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