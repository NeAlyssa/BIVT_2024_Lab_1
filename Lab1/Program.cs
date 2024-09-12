using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

        program.Task_1_1();
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
        for (int s = 2; s <= 35; s += 3)
        {
            answer += s;
        }
        return answer;
    }
    public double Task_1_2()
    {
        double answer = 1;

        for (double s = 2; s <= 10; s++)
        {
            answer += 1/s;
        }
        answer = Math.Round(answer,2);

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;
        
        for(double ch = 2,zn = 3; ch <= 112;ch += 2,zn += 2)
        {
            answer += ch / zn;
        }
        answer = Math.Round(answer);

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        for(double cnt = 1; cnt <= 9 && x != 0; cnt++)
        {
            answer += Math.Cos(x * cnt) / Math.Pow(x,cnt - 1);
        }
        answer = Math.Round(answer, 2);

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = Math.Pow(p,2);

        for(int cnt = 1;cnt < 10; cnt++)
        {
            answer += Math.Pow(p + h * cnt, 2);
        }     

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        answer += x*(0.5 * x  - 7);
        answer = Math.Round(answer, 2);


        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        for(int fact = 2; fact <= 6; fact++)
        {
            answer *= fact;
        }

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        for(int chislo = 1;chislo <= 6; chislo++)
        {
            int buf = 1;
            for (int fact = 2; fact <= chislo; fact++)
            {
                buf *= fact;
            }
            answer += buf;

        }

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        for (int cnt = 1; cnt <= 6; cnt++)
        {
            int buf = 1;
            for (int fact = 2; fact <= cnt; fact++)
            {
                buf *= fact;
            }
            answer += Math.Pow(-5,cnt)/buf;

        }
        answer = Math.Round(answer, 2);
        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;

        for(int cnt = 0;cnt < 7;cnt++)
        {
            answer *= 3;
        }

        return answer;
    }
    public void Task_1_11()
    {
        for (int chisolo = 1; chisolo <= 6; chisolo++)
        {
            if (chisolo != 6)
            {
                Console.Write("{0:d} ", chisolo);
            }
            else
            {
                Console.Write("{0:d}\n", chisolo);
            }
        }
        for (int cnt = 0; cnt < 6; cnt++)
        {
            if (cnt != 6)
            {
                Console.Write("{0:d} ", 5);
            }
        }

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        for(int cnt = 0;cnt <= 10 && x != 0;cnt++)
        {
            answer += 1 / Math.Pow(x, cnt);
        }
        answer = Math.Round(answer, 2);

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        if (x <= -1)
        {
            answer = 1;
        }
        else if (-1 < x && x <= 1)
        {
            answer = -x;
        }
        else
        {
            answer = -1;
        }

        return answer;
    }
    public void Task_1_14()
    {
        int a1 = 1, a2 = 1, a3 = 1;
        Console.Write("{0:d} {0:d} ", a1, a2);
        for (int cnt = 0; cnt < 6; cnt++)
        {
            a3 = a2;
            a2 = a1 + a2;
            a1 = a3;
            Console.Write("{0:d} ", a2);
        }
    }
    public double Task_1_15()
    {
        double answer = 0;
        int chisl = 1, chisl2 = 2, znam = 1, znam2 = 1, bufch, bufzn;
        for (int cnt = 0;cnt < 3; cnt++)
        {
            bufch = chisl2;
            chisl2 = chisl2 + chisl;
            chisl = bufch;

            bufzn = znam2;
            znam2 = znam2 + znam;
            znam = bufzn;
        }
        answer = Math.Round((double) chisl2 / znam2, 1);

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        for(int cnt = 0;cnt < 64; cnt++)
        {
            answer += Math.Pow(2, cnt);
        }
        answer = answer / 15;
        while (answer / Math.Pow(10,power) >= 1)
        {
            power++;
        }
        power--;
        answer = Math.Round(answer / Math.Pow(10, power), 2);

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        int R = 6350;
        answer = Math.Round(Math.Sqrt(x * (2 * R + x)),2);

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;
        int cnt = x / 3;
        for (int cnt2 = 0;cnt2 < cnt; cnt2++)
        {
            answer *= 2;
        }

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0,buf;
        int cnt = 1;

        do
        {
            buf = Math.Cos(x * cnt) / Math.Pow(cnt, 2);
            answer += buf;
            cnt++;
        }
        while (Math.Abs(buf) >= 0.0001);
        answer = Math.Round(answer, 2);

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
        double s = a, buf;


        while (s <= p)
        {
            answer++;
            buf = a + h * answer;
            if (buf < 0)
            {
                answer = 0;
                break;
            }
            s += buf;
        }

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

        N = Math.Abs(N);
        M = Math.Abs(M);
        while (N >= M && M != 0 && N != 0)
        {
            N -= M;
            quotient++;
        }
       if( M != 0 && N != 0)
        {
            remainder = N;
        }

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
        double answer = 0, V = 10;

        for(int day = 1;day <= 7; day++) {

        answer += V;
        V = V * 1.1;
        }
        answer = Math.Round(answer, 2);

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 1;
        double s = 10, V = 10;

        while (s < 100)
        {
            s += V;
            V = V * 1.1;
            answer++;
        }

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;
        double V = 10;

        while (V < 20)
        {
            V = V * 1.1;
            answer++;
        }

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
        double l = 0.1, Da = Math.Pow(10,-10);

        while (l > Da)
        {
            l /= 2;
            answer++;
        }

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
        double S = 0, y = 0, ai = 0, i =0,fac = 1;

        do
        {
            for (int j = 1; j <= 2 * i; j++)
            {
                fac *= j;
            }
            ai = Math.Pow(x, 2 * i) / fac;
            i++;
            S += ai;
            fac = 1;

        }

        while (ai > 0.0001);
        y = (Math.Exp(x) + Math.Exp(-x)) / 2;
        S = Math.Round(S,2);
        y = Math.Round(y, 2);
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