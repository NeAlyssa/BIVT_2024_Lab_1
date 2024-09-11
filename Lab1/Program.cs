using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        program.Task_1_11();
        program.Task_1_14();
        /*program.Task_1_1();
        program.Task_1_2();
        program.Task_1_3();
        program.Task_1_4(0.9);
        program.Task_1_5(0, 2);
        program.Task_1_6(4);
        program.Task_1_7();
        program.Task_1_8();
        program.Task_1_9();
        program.Task_1_10();
        program.Task_1_11();
        program.Task_1_12(0.9);
        program.Task_1_13(-1.5);
        program.Task_1_14();
        program.Task_1_15();
        program.Task_1_16();
        program.Task_1_17(10);
        program.Task_1_18(6);
        program.Task_2_1(0);
        program.Task_2_2();
        program.Task_2_3(8, 2, 0);
        program.Task_2_4(0.8);
        program.Task_2_5(11, 5);
        program.Task_2_6();
        program.Task_2_7a();
        program.Task_2_7b();
        program.Task_2_7c();
        program.Task_2_8();
        program.Task_2_9();
        program.Task_2_10();
        program.Task_3_1(0.1);
        program.Task_3_2(0.1);
        program.Task_3_3(0.1);
        program.Task_3_4(0.1);
        program.Task_3_5(double.Pi/5);
        program.Task_3_6(0.1);
        program.Task_3_7(0.1);
        program.Task_3_8(0.1);
        program.Task_3_9(0.1);*/
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;

        // code here
        for(int i = 2; i <= 35; i += 3) answer += i;
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double i = 1; i <= 10; i++) answer += 1.0/i;
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2; i <= 112; i += 2) answer += i / (i + 1);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if (x != 0)
        {
            for (int i = 0; i <= 8; i++)
            {
                answer += Math.Cos((i + 1) * x) / Math.Pow(x, i);
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
        for (int i = 0; i <= 9; i++) answer += Math.Pow(p + i * h, 2);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = Math.Round(0.5 * Math.Pow(x, 2) - 7 * x, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int fact = 1;
        for (int i = 2; i <= 6; i++) fact *= i;
        answer = fact;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int fact;

        for(int i = 1; i <= 6; i++)
        {
            fact = 1;
            for(int j = 2; j <= i; j++) fact *= j;
            answer += fact;
        }

        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double fact;
        for (double i = 1; i <= 6; i++)
        {
            fact = 1;
            for (double j = 2; j <= i; j++) fact *= j;
            answer += Math.Pow(-1, i)*Math.Pow(5, i)/fact;
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
        for(int i = 2; i <= 7; i++) answer *= 3;
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task

        // code here
        for (int i = 1; i <= 6; i++) Console.Write($"{i} ");
        Console.Write('\n');
        for (int i = 1; i <= 6; i++) Console.Write("5 ");
        Console.Write('\n');
    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if(x != 0)
        {
            for (int i = 0; i <= 10; i++) answer += 1 / Math.Pow(x, i);
            answer = Math.Round(answer, 2);
        }
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 1.0;
        else if (-1 < x && x <= 1) answer = -x;
        else answer = -1.0;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a1 = 1, a2 = 1;
        int a3 = a1 + a2;   
        Console.Write($"{a1} {a2} {a3} ");
        for(int i = 4; i <= 8; i++)
        {
            a1 = a2;
            a2 = a3;
            a3 = a1 + a2;
            Console.Write($"{a3} ");
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double numerator1 = 1, denominator1 = 1;
        double numerator2 = 2, denominator2 = 1;
        double numerator3 = 3, denominator3 = 2;
        
        for (int i = 4; i <= 5; ++i)
        {
            numerator1 = numerator2; denominator1 = denominator2;
            numerator2 = numerator3; denominator2 = denominator3;
            numerator3 = numerator1 + numerator2; denominator3 = denominator1 + denominator2;
        }
        answer = Math.Round(numerator3 / denominator3, 2); 
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        for(int i = 0; i < 64; i++) answer += Math.Pow(2, i);
        answer /= 15;
        power = (int)Math.Log10(answer);
        answer = Math.Round(answer / Math.Pow(10, power), 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        // d = sqrt(h(2R+x))
        double R = 6350.0;
        answer = Math.Round(Math.Sqrt(x*(2*R+x)), 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        answer = 10;
        for (int i = 3; i <= x; i += 3) answer *= 2; 
        // end
        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here
        double eps = 0.0001, i = 0, nextSum = eps;
        while (Math.Abs(nextSum) >= eps) {
            i += 1;
            nextSum = Math.Cos(i * x) / Math.Pow(i, 2);
            answer += nextSum;
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
        double s = 0, currSum;
        int n = 0;
        // s = a + (a + h) + ... + (a + nh) = (n + 1)*a + (1 + 2 + ... + n)h = (n + 1)*a + n*(n+1)/2 * h
        do
        {
            currSum = a + n * h;
            if (currSum <= 0 && h <= 0) return 0;
            s += currSum;
            n++;
        } while (s <= p);

        answer = n - 1;
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
            N = Math.Abs(N);
            M = Math.Abs(M);
            while ((N - M) >= 0) {
                N -= M;
                quotient++;
            }
            remainder = N;            
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
        double step = 10.0;
        for(int i = 1; i <= 7; i++)
        {
            answer += step;
            step *= 1.1;
        }

        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double s = 0, step = 10.0;
        while (s < 100.0)
        {
            s += step;
            step *= 1.1;
            answer += 1;
        }
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double step = 10.0;
        while (step <= 20.0)
        {
            step *= 1.1;
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

        // code here;
        double L = 0.1, D = Math.Pow(10, -10);
        while(L > D)
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
        double eps = 0.0001, i = 0.0, fact, currSum = Math.Pow(-1, i) * Math.Pow(x, 2 * i);
        while (Math.Abs(currSum) >= eps)
        {
            S += currSum;
            i++;
            fact = 1.0;
            for (double j = 2; j <= 2*i; j++) fact *= j;
            currSum = Math.Pow(-1, i) * Math.Pow(x, 2 * i) / fact;
        }
        y = Math.Round(Math.Cos(x), 2);
        S = Math.Round(S, 2);
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