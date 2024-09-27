using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
        //program.Task_2_1(1.6);
        //program.Task_2_2();
        program.Task_2_3(0.2, -1.9, 12);
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
        {
            answer = answer + i;
        }
        // end
        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double i = 1; i <= 10; i++)
        {
            answer = answer + (1 / i);
        }
        answer = Math.Round(answer, 2);
        // end
        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2; i <= 112; i += 2)
        {
            answer = answer + i / (i + 1);
        }
        answer = Math.Round(answer, 0);
        // end
        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double a = 1;
        if (x != 0)
        {
            for (int i = 1; i <= 9; i++)
            {
                answer = answer + Math.Cos(i * x) / a;
                a *= x;
            }
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
        {
            answer = answer + Math.Pow(p + i * h, 2);
        }
        answer = Math.Round(answer, 2);
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
        int j = 1;
        for (int i = 1; i <= 6; i++)
        {
            j = j * i;
        }
        answer = j;
        // end
        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;
        int summer = 1;
        // code here;
        for (int i = 1; i <= 6; i++)
        {
            summer *= i;
            answer += summer;
        }
        // end
        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double a = -1;
        double b = 5;
        double c = 1;
        for (int i = 1; i <= 6; i++)
        {
            c *= i;
            answer += a * b / c;
            a *= -1;
            b *= 5;
        }
        answer = Math.Round(answer, 2);
        // end
        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int j = 1;
        for (int i = 1; i <= 7; i++)
        {
            j = j * 3;
        }
        answer = j;
        // end
        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(i);
            if (i != 6)
            {
                Console.Write(' ');
            } else
            {
                Console.WriteLine();
            }
        }
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(5);
            if (i != 6)
            {
                Console.Write(' ');
            }
            else
            {
                Console.WriteLine();
            }
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double a = 1;
        if (x != 0)
        {
            for (int i = 0; i <= 10; i++)
            {
                answer += 1 / a;
                a *= x;
            }
        }
        answer = Math.Round(answer, 2);
        // end
        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
        {
            answer = 1;
        }
        else if (x <= 1)
        {
            answer = -x;
        }
        else
        {
            answer = -1;
        }
        // end
        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a = 1;
        int b = 1;
        int c;
        Console.Write(a);
        Console.Write(' ');
        Console.Write(b);
        Console.Write(' ');
        for(int i = 0; i < 6; i++)
        {
            c = a + b;
            Console.Write(c);
            if (i != 6)
            {
                Console.Write(" ");
            }
            a = b;
            b = c;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double[] a = { 1, 2, 0, 0, 0 };
        double[] b = { 1, 1, 0, 0, 0 };
        for (int i = 2; i <= 4; i++)
        {
            a[i] = a[i - 2] + a[i - 1];
            b[i] = b[i - 2] + b[i - 1];
        }
        answer = a[4] / b[4];
        // end
        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        for (int i = 0; i < 64; i++)
        {
            answer += Math.Pow(2, i);
        }
        answer = answer / 15;
        while (answer > 10)
        {
            answer = answer / 10;
            power++;
        }
        answer = Math.Round(answer, 2);
        // end
        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double R = 6350;
        answer = Math.Sqrt(Math.Pow((R + x), 2) - R * R);
        answer = Math.Round(answer, 2);
        // end
        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int a = 10;
        for (int i = 3; i <= x; i += 3)
        {
            a = a * 2;
        }
        answer = a;
        // end
        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;
        // code here
        double e = 0;
        int i = 1;
        do
        {
            e = Math.Cos(x * i) / Math.Pow(i, 2);
            i++;
            if (Math.Abs(e) >= 0.0001)
            answer += e;
        } while (Math.Abs(e) >= 0.0001);
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
        double s = 0;
        int i = 0;
        while (s <= p)
        {
            s += (a + h * i);
            if (s <= p)
            {
                answer++;
                i++;
            }
            if ((a + h * i) < 0)
            {
                answer = 0;
                break;
            }
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
        if (M != 0)
        {
            while (Math.Abs(N) >= Math.Abs(M))
            {
                N -= M;
                quotient++;
            }
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
        double run = 10;
        for (int i = 0; i < 7; i++)
        {
            answer += run;
            run = run * 1.1;
        }
        answer = Math.Round(answer, 2);
        // end
        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double run = 10;
        double full_run = 0;
        while (full_run < 100)
        {
            full_run += run;
            run = run * 1.1;
            answer++;
        }
        // end
        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double run = 10;
        while (run < 20)
        {
            run = run * 1.1;
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
        while (l > Math.Pow(10, -10))
        {
            l = l / 2;
            answer++;
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
        y = Math.Pow(Math.E, Math.Cos(x)) * Math.Cos(Math.Sin(x));
        int i = 1;
        double summer = 0;
        S++;
        int fact = 1;
        do
        {
            fact *= i;
            summer = Math.Cos(i * x) / fact;
            if (Math.Abs(summer) > 0.0001)
            {
                S += summer;
            }
            i++;
        } while (Math.Abs(summer) > 0.0001);
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
