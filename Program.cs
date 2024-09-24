using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Formats.Asn1;
using System.Numerics;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

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
        for (int i = 2; i <= 35; i += 3)
        {
            answer += i;
        }

        // code here

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
        for (double i = 3; i <= 113; i += 2)
        {
            answer += (i - 1) / i;
        
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        double p = x;
        // code here
        if (x == 0)
        {
            answer = 0;  
        } else {
            answer += Math.Cos(x);
            for (double i = 1; i <= 8; i++)
            {
                
                answer += (Math.Cos((i + 1) * x)) / p;
                p *= x;
            }
            answer = Math.Round(answer, 2);

        }
        // end
        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        answer += p * p;
        for (double i = 1; i <= 9; i++)
        {
            answer += (p + (i * h)) * (p + (i * h));
            
        }
        // end
        answer = Math.Round(answer, 2);
        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = ((0.5 * x) * x) - (7 * x);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for (int i = 2; i <= 6; i++)
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
        for (int i = 1; i <= 6; i++)
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
        double fac = 1;
        double tmp = 1;
        // code here;
        for (int i = 1; i <= 6; i++)
        {
            fac *= i;
            tmp *= -1;
            tmp *= 5;
            answer += tmp / fac;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 3;

        // code here
        for (int i = 1; i < 7; i++)
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
        double answer = 1;
        double p = x;
        // code here
        if (x == 0)
        {
            answer = 0;
        }
        else
        {
            for (int i = 0; i < 10; i++)
            {
                answer += 1 / p;
                p *= x;
            }
            answer = Math.Round(answer, 2);
        }
        // end
        Console.WriteLine(answer);
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
        else if (-1 < x && x <= 1)
        {
            answer = -1 * x;
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

        // code here
        int fib1 = 1;
        int fib2 = 1;
        int tmp = 0;
        for (int i = 0; i < 4; i++)
        {
            Console.Write(fib1);
            Console.Write(' ');
            Console.Write(fib2);
            Console.Write(' ');
            tmp = fib1 + fib2;
            fib1 = tmp;
            fib2 = fib1 + fib2;
        }
    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double chfib1 = 1;
        double chfib2 = 2;
        double znfib1 = 1;
        double znfib2 = 1;
        double chtmp = 0;
        double zntmp = 0;
        for (int i = 0; i < 3; i++)
        {
            chtmp = chfib2;
            chfib2 = chfib1 + chfib2;
            chfib1 = chtmp;
            zntmp = znfib2;
            znfib2 = znfib1 + znfib2;
            znfib1 = zntmp;
            
        }
        answer = chfib2 / znfib2;
        Console.WriteLine($"{ chfib2}, { znfib2}");
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 1;
        int power = 1;
        double p = 1;

        // code here
        for (int i = 0; i < 63; i++)
        {
            p *= 2;
            answer += p;
        }
        answer /= 15;
        while (answer > 10)
        {
            answer /= 10;
            power++;
        }
        answer = Math.Round(answer, 2);
        power -= 1;
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        double R = 6350;
        // code here
        answer = Math.Sqrt((R + x) * (R + x) - R * R);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int k = x / 3;
        answer = 10;
        for (int i = 0; i < k; i++)
        {
            answer *= 2;
        }
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;
        double cnt = 1;
        // code here
        while (1 == 1) {
            double s = Math.Cos(cnt * x) / (cnt * cnt);
            if (Math.Abs(s) < 0.0001)
            {
                break;
            }
            else
            {
                answer += s;
            }
            cnt++;

        }
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
        double cnt = 0;
        double s = 0;
        // code here
        if (h < 0)
        {
            answer = 0;
        }
        else
        {
            while (s < p)
            {
                answer++;
                s += a + (answer * h);
                
                
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
        int quotient = 0, remainder = Math.Abs(N);

        // code here
        M = Math.Abs(M);
        if (M == 0)
        {
            quotient = 0;
            remainder = 0;
        }
        else
        {
            while (remainder >= M)
            {
                remainder -= M;
                quotient++;
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
        double fst = 10;
        // code here
        answer += fst;
        for (int i = 1; i <= 6; i++)
        {
            fst = fst + (fst * 0.1);
            Console.WriteLine(fst);
            answer += fst;
            Console.WriteLine(answer);
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 1;
        double s = 10;
        double fst = 10;
        // code here
        while (s < 100)
        {
            fst = fst + (fst * 0.1);
            s += fst;
            answer += 1;
        }
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;
        double s = 10;
        double fst = 10;
        // code here
        while (fst <= 20)
        {
            fst = fst + (fst * 0.1);
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
        double L = 0.1;
        double atom = 0.0000000001;
        // code here;
        while (L > atom)
        {
            L /= 2;
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
        double st = 1, it = 0;
        double chl;
        int fl = 1;
        // code here
        while (1 == 1)
        {
            it += 1;
            st *= -1;
            
            
            chl = st * (Math.Cos(it * x) / (it * it));
            if (Math.Abs(chl) < 0.0001)
            {        
                break;
            }
            S += chl;
            y = ((x * x) - (Math.PI * Math.PI) / 3) / 4;

            
        }
        // end
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
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