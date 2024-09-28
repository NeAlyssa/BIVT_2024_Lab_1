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
        program.Task_2_3(1, 1, 10);
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

        for(int i = 2;i<=35;i+=3)
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
        for(double i = 1; i <= 10; i+=1)
        {
            answer += 1 / i; 
        }
        // end
        answer = Math.Round(answer, 2);
        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2; i <= 112; i += 2)
        {
            answer += i / (i+1);
        }
        // end
        answer = Math.Round(answer, 2);
        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        if (x == 0)
        {
            return 0;
        }
        // code here
        double t = 1;
        for(double i = 1; i <= 9; i++) {
            answer += Math.Cos(x * i) / t;
            t *= x;
        }
        // end

        answer = Math.Round(answer, 2);
        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for(double i = 0; i <= 9; i++)
        {
            answer += (p + h * i) * (p + h * i);
        }
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here

        answer = 0.5 * x * x - 7 * x;

        // end

        answer = Math.Round(answer, 2);

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for(int i = 1; i <= 6; i++)
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
        int t = 1;
        for (int i = 1; i <= 6; i++)
        {
            t *= i;
            answer += t;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;

        double t1 = 1;
        double t5 = 1;
        double t6 = 1;
        for(double i = 1; i <= 6; i++)
        {
            t6 *= i;
            t1 *= -1;
            t5 *= 5;
            answer += t1 * t5 / t6;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        answer = 1;
        for(int i = 1; i <= 7; i++)
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
            Console.Write(i + " ");
        }

        Console.WriteLine();
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(i + " ");
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        if (x == 0)
        {
            return 0;
        }
        double answer = 0;

        // code here

        double t = 1;

        for(int i = 1; i <= 11; i++)
        {
            answer += 1 / t;
            t *= x;
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
            return 1;
        }
        else if (-1 < x && x <= 1)
        {
            return -x;
        }
        else
        {
            return -1;
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task

        int f1 = 1, f2 = 1;
        Console.Write(f1 + " "); Console.Write(f2 + " ");
        for (int i = 3; i <= 8; i++)
        {
            int t = f2;
            f2 = f1 + f2;
            f1 = t;
            Console.Write(f2 + " ");
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        int f1 = 1, f2 = 2;
        for (int i = 3; i <= 5; i++)
        {
            int t = f2;
            f2 = f1 + f2;
            f1 = t;
        }
        double a = f2;
        f1 = 1; f2 = 1;
        for (int i = 3; i <= 5; i++)
        {
            int t = f2;
            f2 = f1 + f2;
            f1 = t;
        }
        double b = f2;
        answer = a / b;
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        for (int i = 0; i <= 63; i++)
        {
            answer += Math.Pow(2, i) / 15;
        }
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

        answer = Math.Sqrt(x * (2 * 6350 + x));

        // end
        answer = Math.Round(answer, 2);
        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        answer = 10;
        for(int i = 1; i <= x / 3; i++)
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
        double i = 1;
        while (Math.Abs(Math.Cos(i*x)/(i*i))>=0.0001)
        {
            answer += Math.Cos(i * x) / (i * i);
            i++;
        }
        answer = Math.Round((double)answer, 2); 
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
        double n = 0;
        double s = 0;
        if (h < 0)
        {
            return 0;
        }
        while(s + a + n * h <= p)
        {
            s += a + n * h;
            answer++;
            n++;
            if (h < 0)
            {
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
        if (M == 0)
        {
            return (0,0);
        }
        N = Math.Abs(N);
        M = Math.Abs(M);
        while (N >= M)
        {
            N -= M;
            quotient++;
        }
        remainder = N;
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
        double x = 10;
        double s = 10;
        for(int i = 1; i <= 7 - 1; i++)
        {
            x = x * 1.1;
            s += x;
        }
        s = Math.Round(s, 2);
        answer = s;
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double x = 10;
        double s = 10;
        answer = 1;
        while(s<100)
        {
            x = x * 1.1;
            s += x;
            answer++;
        }
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double x = 10;
        double s = 10;
        answer = 0;
        while (x<=20)
        {
            x = x * 1.1;
            s += x;
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
        double t = 1;
        for (int i = 1; i <= 10; i++) t /= 10;
        double l = 0.1;
        int ans = 0;
        while (l > t)
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

        double i = -1;

        while (Math.Abs(i * Math.Cos(i * x) / (i * i)) >= 0.0001)
        {
            S += i * Math.Cos(i * x) / (i * i);
            i *= (-1);
        }
        y = (x * x - Math.PI * Math.PI / 3)/4;
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
