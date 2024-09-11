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
        //program.Task_1_4(0.9);  program.Task_1_4(0.5);
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
        //program.Task_2_4(1); program.Task_2_4(0.8);
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
        program.Task_3_8(1);
        //program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;
        // aboba game is gettig boring
        // code here
        for (int i = 2; i <= 35; i += 3) answer += i;
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (int i = 1; i <= 10; i++) answer += 1.0 / (double)i;
        answer = Math.Round(answer, 3);
        // end
        //Console.WriteLine("Test 2 answer:{0:f4}", answer);
        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (int i = 3; i<=113; i++) answer += (double)(i-1) / (double)i;
        answer = Math.Round(answer, 4);

        //Console.WriteLine("Test 2 answer:{0:f}", answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        double x_pow = 1f;
        // code here
        if (x == 0) return answer;
        for (int i =1;i<=9; i++)
        {
            answer += Math.Cos(x * i) / x_pow;
            x_pow *= x;
        }

        answer = Math.Round(answer, 4);
        //Console.WriteLine("Test 4 answer:{0:f5}", answer);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i =0; i<10; i++)
        {
            answer += (p + i * h) * (p + i * h);
        }
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer =  0.5 * x * x - 7 * x;
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for (int i = 2; i <= 6; i++) answer *= i;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int i_factorial = 1;
        answer = 1;
        for (int i = 2; i<=6; i++)
        {
            i_factorial*= i;
            answer += i_factorial;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        int even = -1, now_fact = 1, pow5 = 5;
        for (int i = 1; i<=6; i++)
        {
            now_fact *= i;
            answer += (even * pow5) / (double)now_fact;
            even *= -1;
            pow5 *= 5;
        }
        answer = Math.Round(answer, 4);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        for (int i = 1; i<=7; i++) answer *= 3;
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i<=6; i++)
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
        if (x==0) return 0;
        // code here
        double x_pow = 1;
        for (int i = 0; i<=10; i++)
        {
            answer += 1.0/x_pow;
            x_pow *= x;
        }
        answer = Math.Round(answer, 4);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) return 1;
        else if (x > 1) return -1;
        else return -x;        
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int f = 1, s = 1;
        Console.Write("{0:d} {1:d} ", f, s);
        for (int i = 3; i<=8; i++)
        {
            int h = f;
            f = f + s;
            s = h;
            Console.Write("{0:d} ", f);
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 3;

        // code here
        int fir_chisl = 1, sec_chisl = 2, fir_znam = 1, sec_znam = 1;
        for (int i = 3; i<=5; i++)
        {
            int h = sec_chisl; sec_chisl += fir_chisl; fir_chisl = h;
            h = sec_znam; sec_znam += fir_znam; fir_znam = h;
            answer = (double)fir_chisl/fir_znam;
        }
        answer = (int)(answer*10)/10.0;
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double zer = 1;
        double pow = 1;
        for (int i = 0; i < 64; ++i)
        {
            pow *= 2;
            zer += pow;
        }
        zer /= 15;
        //Console.WriteLine(zer);
        //Console.WriteLine(power);
        while (zer >= 10)
        {
            power++;
            zer /= 10;
        }
        //Console.WriteLine(zer);
        //Console.WriteLine(power);
        answer = Math.Round(zer, 4);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        int r = 6350;
        answer = (x+r)*(x+r) + r*r;
        answer = Math.Sqrt(answer);
        answer = Math.Round(answer, 4);
        // end
        
        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        answer = 10;
        for (int i =3; i<x; i += 3)
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

        // code here
        double now = Math.Cos(x), eps = 0.0001;
        int i = 2; answer = now;
        while (Math.Abs(now) >= eps)
        { 
            now = (Math.Cos(i * x)) / (i * i);
            Console.WriteLine(now);
            answer += now;
            i++;
        }
        answer = Math.Round(answer, 4);
        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 0;

        // code here
        int L = 30000;
        for (int i = 1; i<=300; i+=3)
        {
            int p = 1;
            for (int j = 1; j<=i; j += 3)
            {
                p *= j;
            }
            if (p > L) break;
            else answer = i;
        }
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
        double answer = 1;

        // code here
        if (Math.Abs(x) >= 1) return 0;
        double now = x*x, eps = 0.0001;
        while (Math.Abs(now) >= eps)
        {
            answer += now;
            now *= x*x;
            //Console.WriteLine(now);
        }
        answer = Math.Round(answer, 4);
        // end
        //Console.WriteLine("Answ: {0;f5}", answer);
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
        int i = 10;
        while (i<1e5)
        {
            i *= 2;
            answer += 3;
        }
        
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
        double now = 10000;
        while (now < 20000)
        {
            now *= 1.08;
            answer++;
        }
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
        int answer = 2;

        // code here;
        double eps = 0.001;
        int fir_chisl = 1, sec_chisl = 2, fir_znam = 1, sec_znam = 1;
        while (Math.Abs(((double)sec_chisl / sec_znam) - ((double)fir_chisl / fir_znam)) > eps)
        {
            int h = sec_chisl; sec_chisl += fir_chisl; fir_chisl = h;
            h = sec_znam; sec_znam += fir_znam; fir_znam = h;
            //Console.WriteLine("an: {0:f5}, chisl: {1:d}, znam: {2:d}", (double)sec_chisl / sec_znam, sec_chisl, sec_znam);
            answer++;
        }
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
        double f(double x)
        {
            return Math.Round(Math.Exp(2 * x), 4);
        }
        double now = 0, eps = 0.000005;
        double power2x = 1; int fact = 1;
        for (int i = 0; ; i++)
        {
            now = power2x / fact;
            power2x *= 2 * x; fact *= (i+1);
            if (Math.Abs(now) < eps) break;
            S += now;
        }
        double CustomRound(double value, int decimals)
        {
            int val = (int)(value*Math.Pow(10, decimals+1));
            if (val % 10 >= 5)
            {
                val += 10;
                //val /= 10;
            }
            val /= 10;
            return (double)val/ Math.Pow(10, decimals);
        }
        S = CustomRound(S, 4);
        y = CustomRound(f(x), 4);
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