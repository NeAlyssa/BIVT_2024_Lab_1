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
        //program.Task_2_1(1);
        //program.Task_2_2();
        //program.Task_2_3(0.2, -1.9, 12);
        //program.Task_2_4(0.8);
        //program.Task_2_5(8, 2);
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
        for (double i = 1; i <= 10; i += 1)
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
        for (double i = 2; i <= 112; i += 2)
        {
            answer += i / (i + 1);
        }
        answer = Math.Round(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if (x == 0)
        {
            answer = 0;
        }
        else
        {
            for (int i = 1; i <= 9; i++)
            {
                answer += Math.Cos(i * x) / Math.Pow(x, i - 1);
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
        for (int i = 0; i <= 9; i += 1)
        {
            answer += Math.Pow((p + i * h), 2);
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

        // code here;
        int n = 1;
        for (int i = 1; i <= 6; i++)
        {
            n *= i;
            answer += n;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double temp = 1;
        double fact = 1;
        for (double i = 1; i<=6; i++)
        {
            fact *= i;
            temp *= ((-1) * 5);
            answer += temp / fact;

        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        answer += 1;
        for (int i = 1; i <= 7; i++)
        {
            answer *= 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task

        // code here
        Console.Write("а) ");
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(i);
            Console.Write(' ');
        }
        Console.WriteLine("");
        Console.Write("б) ");
        for (int i = 1; i <= 6; i++)
        {
            Console.Write("5");
            Console.Write(" ");
        }
    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x == 0)
        {
            answer = 0;
        }
        else
        {
            for (int i = 0; i <= 10; i++)
            {
                answer += 1 / Math.Pow(x, i);
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
        if (x <= -1)
        {
            answer = 1;
        }
        if (x<=1 && x>-1) 
        {
            answer = -x;
        }
        if (x>1)
        {
            answer = -1;
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int f1 = 1;
        int f2 = 1;
        Console.WriteLine(f1);
        Console.WriteLine(f2);
        for (int i = 3; i <= 8; i++)
        {
            int temp = f1;
            f1 = f2;
            f2 = temp + f2;
            Console.WriteLine(f2);
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double chis1 = 1;
        double chis2 = 2;
        int zn1 = 1;
        int zn2 = 1;
        for (int i = 3; i <= 5; i++)
        {
            double tempchis = chis1;
            int tempzn = zn1;
            chis1 = chis2;
            chis2 = tempchis + chis2;
            zn1 = zn2;
            zn2 = tempzn + zn2;
        }
        answer = chis2 / zn2;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        int p = 0;
        for (int count = 1; count <= 64; count++)
        {
            answer += Math.Pow(2, p);
            p++;
        }
        answer = answer / 15;
        while (answer > 10)
        {
            answer /= 10;
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
        int R = 6350;
        answer = Math.Sqrt((R + x) * (R + x) - R * R);
        answer = Math.Round(answer,2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int p = 1;
        for (int i = 1; i<=x/3; i++)
        {
            p *= 2;
        }
        answer = 10 * p;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here
        double e = 0.0001;
        double i = 1;
        while (Math.Abs(e) >= 0.0001)
        {
            
            e = Math.Cos(i * x) / (i * i);
            if (Math.Abs(e) <  0.0001) break;
            answer += e;
            i++;
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

        // code here
        double sum = 0;
        double temp = 0;
        if (h < 0 && a < p)
        {
            answer = 0;
        }
        else
        {
            while (sum <= p)
            {
                sum += a + temp;
                temp += h;
                if (sum > p)
                {
                    break;
                }
                answer++;

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
                quotient++;
                N = Math.Abs(N);
                N -= Math.Abs(M);
            }
            remainder = Math.Abs(N);
            
        }
        Console.WriteLine(quotient);
        Console.WriteLine(remainder);
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
        double temp = 10;
        answer += temp;
        for (int i = 2; i <= 7; i++)
        {
            temp *= 1.1;
            answer += temp;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double sum = 0;
        double temp = 10;
        sum += temp;
        answer = 1;
        while (sum < 100)
        {
            temp *= 1.1;
            sum += temp;
            answer++;
        }
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double temp = 10;
        while(temp <= 20)
        {
            temp *= 1.1;
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
            l /= 2;
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
        double i = 0;
        double ch = 1;
        while (Math.Abs(ch) >= 0.0001)
        {
            double fact = 1;
            double k = i * 2;
            for (int j=1; j<=k; j++)
            {
                fact *= j;
            }
            ch = (double)Math.Pow(x, 2 * i) / fact;
            S += ch;
            i++;
        }
        y = (Math.Exp(x) + Math.Exp(-x)) / 2;
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
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