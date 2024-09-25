using Microsoft.Win32.SafeHandles;
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
        // program.Task_3_1(0.1);
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
            answer += i;
        }
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (int i = 1; i <= 10; i += 1)
        {
            answer += 1.0 / i;
            answer = Math.Round(answer, 2);
        }
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (int i = 3; i <= 113; i += 2)
        {
            answer += (i - 1.0) / (i);
            answer = Math.Round(answer, 2);
        }
        // end
        answer = (int)answer;
        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        // code here
        double k = 1;
        if (x != 0)
        {
            for (int i = 1; i <= 9; ++i)
            {
                double a = Math.Cos(x * i) / (k);
                answer += a;
                k *= x;
            }
        }

        // end
        answer = Math.Round(answer, 2);
        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i = 0; i <= 9; ++i) 
        {
            double a = Math.Pow((p + i * h), 2);
            answer += a;
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
        int answer = 1;

        // code here
        for (int i = 1;i <= 6;++i)
        {
            answer *= i;
        }
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;
        int a = 1;

        // code here;
        for(int i = 1;i <= 6; ++i)
        {
            a *= i;
            answer += a;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        int s = 1;
        // code here;
        int z = -1;
        double k = 5.0;
        for(int i = 1;i <= 6; ++i)
        {
            s *= i;
            answer += (double)z*k/s;
            answer = Math.Round(answer, 2);
            z *= (-1);
            k *= 5;
        }
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 3;

        // code here
        for (int i = 1;i <= 6; ++i)
        {
            answer *= 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i <= 6; i++)
        {
            if (i != 6) Console.Write("{0:d} ", i);
            else Console.Write("{0:d},", i);
        }
        Console.WriteLine();
        for (int i = 1; i <= 6; i++)
        {
            if (i != 6) Console.Write("{0:d} ", 5);
            else Console.Write("{0:d}.", 5);
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;
        double s = 1;
        // code here
        if (x != 0)
        {
            for (int i = 0;i <= 10; ++i)
            {
                answer += 1 / s;
                s *= x;
            }
            answer = Math.Round(answer, 2);
        }
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) return 1;
        if (x > -1 && x <= 1) return -x;
        if (x >= 1) return -1;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        int f1 = 1;
        int f2 = 1;
        int t = f1;
        // There is no test for this task
        Console.Write("{0:d} {1:d} ", f1, f2);
        for (int i = 0; i <  6; ++i)
        {
            t = f2;
            f2 = f2 + f1;
            f1 = t;
            Console.Write("{0:d} " , f2);
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        int fir_chisl = 1, sec_chisl = 2, fir_znam = 1, sec_znam = 1;
        for ( int i = 0;i < 3; ++i)
        {
            int t = sec_chisl; sec_chisl += fir_chisl; fir_chisl = t;
            t = sec_znam; sec_znam += fir_znam; fir_znam = t;
            answer = (double)(sec_chisl) / (sec_znam);
        }
        Math.Round(answer,2);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;
        double z = 1;
        double step = 1;

        // code here
        for (int i = 2;i <= 64; ++i)
        {
            step *= 2;
            z += step;
        }
        z /= 15;
        while (z >= 10)
        {
            z /= 10;
            power += 1;
        }
        answer = Math.Round(z, 2);
        // end
        
        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        int r = 6350;
        answer = (r + x) * (r + x) - r * r;
        answer = Math.Sqrt(answer);
        answer = Math.Round(answer,2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int c = x / 3;
        answer = 10*(int)Math.Pow(2, c);
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;
        double e = 0.0001;
        double s = Math.Cos(x);
        // code here
        double i = 2;
        while(Math.Abs(s) >= (double)e)
        {
            answer += s;
            s = (double)Math.Cos(i * x)/((double)i * i);
            i++;
        }
        answer += s;
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
        double summa = a;
        int i = 1;
        // code here
        if (h > 0) 
        {
            while (summa <= p)
            {
                summa += (a + i * h);
                i++;
            }
        }
        answer = i - 1;
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
            if( N > M)
            {
                while( N >= M)
                {
                    N -= M;
                    quotient++;
                }
                remainder = N;
            }
            else
            {
                while (N <= M)
                {
                    N -= M; quotient++;
                }
                remainder = N - M;
            }
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
        double s = 10.0;

        // code here
        for (int i = 0;i < 7; ++i)
        {
            answer += s;
            s *= 1.1;
        }
        answer = Math.Round(answer,2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;
        double s = 10.0;

        // code here
        double summa = 0;
        while(summa < 100)
        {
            answer++;
            summa += s;
            s *= 1.1;
        }
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;
        double s = 10.0;
        // code here
        while(s < 20)
        {
            answer++;
            s *= 1.1;
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
        double L = 0.1;
        // code here;
        while( L > 0.0000000001)
        {
            L /= 2;
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
        double i = 0;
        double eps = 0.0001;
        double z = 1;
        double nyaaa = 1.0 * 1.0 / (double)z;
        int b = -1;
        int j = 1;
        z = 1;
        double k = x * x;
        while(Math.Abs(nyaaa) > eps)
        {
            S += nyaaa;
            i++;
            z *= j*(j+1);
            nyaaa = b * k / (double)z;
            k *= x * x;
            b *= (-1);
            j += 2;
        }
        y = Math.Cos(x);
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);

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
