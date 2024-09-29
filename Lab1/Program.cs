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
        for (double i = 1; i <= 10; ++i)
        {
            answer += (1 / i);
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
            answer += (i / (i + 1));
        }
        answer = Math.Round(answer);
        // end
        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        // code here
        double znam = 1;

        if (x > 0)
        {
            for (double i = 0; i <= 8; ++i)
            {
                answer += (Math.Cos((i + 1) * x)) / (znam);
                znam *= x;
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
        for (double i = 0; i < 10; ++i)
        {
            answer += (p + i * h) * (p + i * h);
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
        answer += 1;
        for (int i = 1; i <= 6; ++i)
        {
            answer *= i;
        }
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int interm_sum = 1;
        for (int i = 1; i <= 6; ++i)
        {
            for (int j = 1; j <= i; ++j)
            {
                interm_sum *= j;
            }
            answer += interm_sum;
            interm_sum = 1;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;


        // code here;
        double coef = -1;
        double fivv = 5;
        double fact = 1;
        for (double i = 1; i <= 6; ++i)
        {
            for (double j = 1; j <= i; ++j)
            {
                fact *= j;
            }
            answer += (coef * fivv) / fact;
            coef *= -1;
            fivv *= 5;
            fact = 1;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        answer = 3;
        for (int i = 2; i <= 7; ++i)
        {
            answer *= 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        Console.WriteLine("1 2 3 4 5 6");
        Console.WriteLine("5 5 5 5 5 5");
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;
        // code here
        double znam = 1;
        for (double i = 0; i <= 10; i++)
        {
            if (x != 0)
            {
                answer += 1 / znam;
                znam *= x;
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
        else if (x > -1 && x <= 1)
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
        int frst = 1, scd = 1, inter = scd;
        Console.Write($"{frst} {scd} ");
        for (int i = 2; i < 8; ++i)
        {
            inter = scd;
            scd += frst;
            frst = inter;
            Console.Write($"{scd} ");
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double chisl = 1, znam = 1, t = 0;
        for (int i = 0; i < 5; ++i)
        {
            answer = chisl / znam;
            t = chisl;
            chisl += znam;
            znam = t;
        }
        answer = Math.Round(answer, 1);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;
        double csm = 1;
        double tchn = 1;
        // code here
        for (int i = 0; i < 64; ++i)
        {
            if (answer > tchn * 10)
            {
                tchn *= 10;
                power += 1;
            }
            answer += csm;
            csm *= 2;
        }
        answer /= tchn * 15;
        answer = Math.Round(answer, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double R = 6350;
        answer = (R + x) * (R + x) - R * R;
        answer = Math.Sqrt(answer);
        answer = Math.Round(answer, 2);
        // end
        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        answer = 10;
        for (int i = 3; i <= x; i += 3)
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
        double s = 0;
        double epsillon = 0.0001;
        for (int i = 1; Math.Abs(Math.Cos(i * x) / (Math.Pow(i, 2))) >= epsillon; i++)
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

        // code here
        int p = 1;
        int L = 30_000;
        int count = 0;
        for (int i = 0; p <= L; i++)
        {
            count = 3 * i - 2;
            p *= (3 * (i + 1) - 2);
        }
        answer = count;
        // end

        return answer;
    }
    public int Task_2_3(double a, double h, double p)
    {
        int answer = 0;

        // code here
        double s = 0;
        int count = 0;
        while (true)
        {
            if (a < p)
            {
                if (h > 0)
                {
                    s += a + count * h;
                    count++;
                    if (s > p)
                    {
                        count--;
                        break;
                    }
                }
                else
                {
                    count = 0;
                    break;
                }
            }
            else if (a == p)
            {
                count = 1;
                break;
            }
            else if (a > p)
            {
                count = 0;
                break;
            }
        }

        answer = count;
        // end

        return answer;
    }
    public double Task_2_4(double x)
    {
        double answer = 0;

        // code here
        double s = 0;
        double term = 1;
        const double eps = 0.0001;
        if (Math.Abs(x) >= 1)
        {
            s = 0;
        }
        else
        {
            for (int n = 0; Math.Abs(term) >= eps; n++)
            {
                s += term;
                term *= x * x;
            }
        }
        answer = Math.Round(s, 2);

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
        int nachalo = 10;
        int kolvo = 10;
        int i;
        int step = 1;
        for (i = 0; kolvo < 100_000; i++)
        {
            kolvo = nachalo * step;
            step *= 2;
        }
        answer = (i - 1) * 3;
        // end

        return answer;
    }
    public double Task_2_7a()
    {
        double answer = 0;

        // code here
        double nachalo = 10;
        double den = nachalo;
        double summ = nachalo;
        for (int i = 1; i <= 6; i++)
        {
            den += den * 0.1;
            summ += den;
        }
        answer = Math.Round(summ, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double nachalo = 10;
        double den = nachalo;
        double summ = nachalo;
        int otvet = 0;
        for (int i = 1; summ < 100; i++)
        {
            den += den * 0.1;
            summ += den;
            otvet = i;
        }
        answer = otvet + 1;
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double nachalo = 10;
        double den = nachalo;
        double summ = nachalo;
        int otvet = 0;
        for (int i = 1; den <= 20; i++)
        {
            den += den * 0.1;
            summ += den;
            otvet = i;
        }
        answer = otvet;
        // end

        return answer;
    }
    public int Task_2_8()
    {
        int answer = 0;

        // code here;
        double nachalo = 10_000;
        double uvel = 0.08;
        double mesyac = nachalo;
        double summ = nachalo;
        int otvet = 0;
        for (int i = 1; summ < 20_000; i++)
        {
            mesyac = summ * uvel;
            summ += mesyac;
            otvet = i;
        }
        answer = otvet;
        // end

        return answer;
    }
    public int Task_2_9()
    {
        int answer = 0;

        // code here;
        double L = 0.1;
        double D_A = Math.Pow(10, -10);
        int otvet = 0;
        for (int i = 1; L > D_A; i++)
        {
            L = L * 0.5;
            otvet = i;
        }
        answer = otvet;
        // end

        return answer;
    }
    public int Task_2_10()
    {
        int answer = 0;

        // code here;
        double a_1 = 1.0, b_1 = 1.0;
        double a_2 = 2.0, b_2 = 1.0;
        int otvet = 2;
        while (true)
        {
            otvet++;
            double a_n = a_1 + a_2;
            double b_n = b_1 + b_2;
            double currValue = a_n / b_n;
            if (Math.Abs(currValue - (a_2 / b_2)) <= 0.001)
            {
                break;
            }
            a_1 = a_2;
            b_1 = b_2;
            a_2 = a_n;
            b_2 = b_n;
        }
        answer = otvet;
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
        const double e = 0.0001;

        //lastelement and chetchik
        double ch = 1;
        double b = x;
        double q = b * Math.Sin((ch * Math.PI) / 4);
        //process
        while (Math.Abs(b) >= e)
        {


            S += q;
            b *= x;
            ch += 1;
            q = b * Math.Sin((ch * Math.PI) / 4);

        }
        y = (x * Math.Sin(Math.PI / 4)) / (1 - 2 * x * Math.Cos(Math.PI / 4) + x * x);
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
