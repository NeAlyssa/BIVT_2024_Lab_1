using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.IO.Pipes;
using System.Net.Http.Json;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Transactions;

public class Program
{
 
    public static void Main()
    {
        Program program = new Program();
        Console.WriteLine(program.Task_3_2(0.2));
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;
        for (int i = 2; i <= 35; i += 3) answer += i;
        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        for (double i = 1.0; i <= 10.0; i = i + 1.0) answer = answer + (1.0 / i);

        return Math.Round(answer, 2);
    }
    public double Task_1_3()
    {
        double answer = 0;

        for (double i = 2.0; i <= 112.0; i += 2.0) answer = answer + (i / (i + 1.0));

        return Math.Round(answer, 2);
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        if (x == 0) return 0;
        double xy = 1;
        for (int i = 1; i <= 9; i++)
        {
            answer += Math.Cos(x * i) / xy;
            xy *= x;
        }
        return Math.Round(answer, 2);
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
        for (int i = 1; i <= 6; i++) answer *= i;
        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;
        int d = 1;
        for (int i = 1; i <= 6; i++)
        {
            d *= i;
            answer += d;
        }
        return answer;
    }
    
    public double Task_1_9()
    {
        double answer = 0;
        int perm1 = -1;
        int perm2 = 5;
        double s = 1;
        for (int i = 1; i <= 6; i++)
        {
            s *= i;
            answer += perm1 * perm2 / s;
            perm1 = -perm1;
            perm2 *= 5;
        }
        return Math.Round(answer, 2);
    }
    public int Task_1_10()
    {
        int x = 3;
        for (int i = 1; i < 7; i++) x *= 3;

        return x;
    }
    public void Task_1_11()
    {
        for (int i = 1; i <= 6; i++) Console.Write(i + " ");
        Console.WriteLine();
        for (int i = 1; i <= 6; i++) Console.Write(5 + " ");

    }
    public double Task_1_12(double x)
    {
        double answer = 0;
        if (x == 0) return 0;
        double prim = 1;
        for (int i = 0; i <= 10; i++)
        {
            answer += 1 / prim;
            prim *= x;
        }


        return Math.Round(answer, 2);
    }
    public double Task_1_13(double x)
    {
        if (x <= -1) return 1;
        else if (x > -1 && x <= 1) return -x;
        else return -1;
    }
    public void Task_1_14()
    {
        int one = 1; int two = 1;
        Console.WriteLine(one + "\n" + two);
        int predlast = 1; int last = 1;
        for (int i = 1; i <= 6; i++)
        {
            int s = last;
            last = predlast + last;
            predlast = s;
            Console.WriteLine(last);
        }


    }
    public double Task_1_15()
    {
        double lasch = 2; double lastzn = 1; double predlastch = 1; double predlastzn = 1;
        for (int i = 2; i <= 4; i++)
        {
            double promch = lasch; double promzn = lastzn;
            lasch = predlastch + lasch;
            lastzn = predlastzn + lastzn;
            predlastch = promch; predlastzn = promzn;
        }
        return lasch / lastzn;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        double power = 1;
        answer += power;
        for (int i = 2; i <= 64; i++)
        {
            power *= 2;
            answer += power;
        }
        answer /= 15;
        int k = (int)Math.Log10(answer);
        double zn = 1;
        for (int i = 1; i <= k; i++) zn *= 10;
        answer = answer / zn;
        return (Math.Round(answer, 2), k);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        answer = Math.Sqrt((6350 - x) * (6350 - x) - (6350 * 6350));

        return Math.Round(answer, 2);
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        for (int i = 1; i <= x/3; i++) answer *= 2;

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;
        return answer;
    }
    public int Task_2_2()
    {
        int answer = 1;
        int i = 1;
        while (answer <= 30000)
        {
            answer *= i;
            i += 3;
        }

        return i - 6;
    }
    public int Task_2_3(double a, double h, double p)
    {
        return 0;
    }
    public double Task_2_4(double x)
    {
        double answer = 0;
        double prom = 1;
        if (Math.Abs(x) >= 1) return 0;
        while (prom >= 0.0001)
        {
            answer += prom;
            prom = prom * x * x;
        }

        return Math.Round(answer, 2);
    }
    public (int, int) Task_2_5(int N, int M)
    {

        return (0, 0);
    }
    public int Task_2_6()
    {
        int i = 10;
        int count = 0;
        while (i < 100000)
        {
            i *= 2;
            count++;
        }
        return count * 3;
    }
    public double Task_2_7a()
    {
        double answer = 0;

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;
        

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;
        

        return answer;
    }
    public int Task_2_8()
    {
        double answer = 10000;
        int count = 0;

        double k = 1.08;
        while (answer < 20000)
        {
            answer *= k;
            count += 1;

        }

        return count;
    }
    public int Task_2_9()
    {
        int answer = 0;
        return answer;
    }
    public int Task_2_10()
    {
        double prlastch = 1; double prlastzn = 1;
        double lastch = 2; double lastzn = 1;
        int count = 2;

        while (Math.Abs((lastch / lastzn) - (prlastch / prlastzn)) > 0.001)
        {
            double prom1 = lastch; double prom2 = lastzn;

            lastch = lastch + prlastch;
            lastzn = lastzn + prlastzn;

            prlastch = prom1; prlastzn = prom2;
            count += 1;


        }
        return count;

        
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
        double S = 0;
        double i = 1;
        double mn1 = x;
        double mn2 = Math.Sin(i * Math.PI / 4);
        while (mn1 >= 0.0001)
        {
            S += (mn1 * mn2);
            i += 1;
            mn1 = mn1 * x;
            mn2 = Math.Sin((i * Math.PI) / 4);
        }
        double y = (x * Math.Sin(Math.PI / 4)) / (1 - (2 * x * Math.Cos(Math.PI / 4)) + (x * x));
        return (Math.Round(S, 2), Math.Round(y, 2));
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
        
        return (0,0);

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