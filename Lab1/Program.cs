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
        //program.Task_1_4(0);
        //program.Task_1_5(0, 2);
        //program.Task_1_6(4);
        //program.Task_1_7();
        //program.Task_1_8();
        //program.Task_1_9();
        //program.Task_1_10();
        //program.Task_1_11();
        //program.Task_1_12(0);
        //program.Task_1_13(-1.5);
        //program.Task_1_14();
        //program.Task_1_15();
        //program.Task_1_16();
        //program.Task_1_17(10);
        //program.Task_1_18(24);
        //program.Task_2_1(1);
        //program.Task_2_2();
        //program.Task_2_3(1, 1, 10);
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
        for (int i = 1; i <= 10; i++)
        {
            answer += 1.0 / i;
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
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        double cos = 0, pow = 0;
        // code here
        if (x == 0) return 0;
        for (int i = 1; i <= 9; i++)
        {
            cos = Math.Cos(i * x);
            pow = Math.Pow(x, i - 1);
            answer += cos / pow;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i = 0; i < 10; i++)
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
        for (int i = 0; i < 9; i++)
        {
            answer = 0.5 * x * x - 7 * x;
        }
        // end
        answer = Math.Round(answer, 2);
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
        for (int i = 1; i < 7; i++)
        {
            int x = 1;
            for (int j = 2; j <= i; j++)
            {
                x *= j;
            }
            answer += x;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        for (int i = 1; i <= 6; i++)
        {
            int x = 1;
            for (int j = 2; j <= i; j++)
            {
                x *= j;
            }
            answer += Math.Pow(-1, i) * Math.Pow(5, i) / x;
        }
        answer = Math.Round(answer, 2);
        // end
        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
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
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(i); Console.Write(" ");
        }

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x == 0) return 0;
        for (int i = 0; i <= 10; i++)
        {
            answer += 1.0 / Math.Pow(x, i);
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        for (double i = -1.15; i <= 1.15; i += 0.1)
        {
            if (x <= -1)
            {
                answer = 1;
            }
            else if (x <= 1)
            {
                answer = -1 * x;
            }
            else
            {
                answer = -1;
            }
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a1 = 1, a2 = 1, t;

        for (int i = 1; i <= 8; i++)
        {
            if (i >= 2)
            {
                t = a2;
                a2 = a2 + a1;
                a1 = t;
            }

            Console.WriteLine(a2);
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 1;
        double up1 = 1, up2 = 2;
        double down1 = 1, down2 = 1;
        double t = 0;
        // code here
        for (double i = 3; i <= 5; i++)
        {

            t = up2;
            up2 = up2 + up1;
            up1 = t;
            t = down2;
            down2 = down2 + down1;
            down1 = t;
            answer = up2 / down2;

        }
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 2;
        int power = 0, x;
        string str;
        // code here
        for (int i = 1; i < 8 * 8; i++)
        {
            answer *= 2;
        }
        answer /= 15;
        str = answer.ToString();
        power = int.Parse(str.Substring(str.Length - 3, 3));
        answer = double.Parse(str.Substring(0, 5));
        answer = Math.Round(answer, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0, R = 6350;

        // code here
        for (int i = 1; i <= 10; i++)
        {
            answer = Math.Sqrt((R + x) * (R + x) - R * R);
        }
        // end
        answer = Math.Round(answer, 2);
        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here
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
        int i = 1;
        double ans = 1;
        // code here
        while (true)
        {
            ans = Math.Cos(i * x) / (i * i);
            if (Math.Abs(ans) < 0.0001)
            {
                break;
            }
            answer += ans;
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
        int i = -1;
        double s = 0;
        // code here
        while (s <= p)
        {
            i++;
            s += a + i * h;
            if(s<0 && h <= 0)
            {
                return 0;
            }
        }
        answer = i;
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
        int i = 0, x = 1;
        N = Math.Abs(N);
        M = Math.Abs(M);
        // code here
        if (M == 0)
        {
            return (0, 0);
        }
        x = N;
        while (true)
        {
            x = x - M;
            if (x < 0)
            {
                break;
            }
            i++;
        }

        quotient = i;
        remainder = N - M * i;

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
        double answer = 10;
        double s = 10;
        // code here
        for (int i = 1; i < 7; i++)
        {
            s += 0.1 * s;
            answer += s;
        }
        answer = Math.Round(answer, 2);
        // end
        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 1;
        double s = 10, dist = 10;
        // code here
        while (dist < 100)
        {
            s += 0.1 * s;
            dist += s;
            answer++;
        }

        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;
        double s = 10;
        // code here
        while (s < 20)
        {
            s += 0.1 * s;
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
        double L = 0.1;
        double D = Math.Pow(10, -10);
        int i = 0;
        // code here;
        while (L > D)
        {
            L = L / 2;
            i++;
        }
        answer = i;

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
        double S = 0, y = 0, ans = 0, i = 0, fact = 1;
        // code here
        while (true)
        {
            fact = 1;
            for (int j = 1; j <= 2 * i; j++)
            {
                fact = fact * j;
            }
            ans = Math.Pow(-1, i) * Math.Pow(x, 2 * i) / fact;
            if (Math.Abs(ans) <= 0.0001)
            {
                break;
            }
            S += ans;
            i++;
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