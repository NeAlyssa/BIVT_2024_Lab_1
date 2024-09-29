using System.Collections.Generic;
using System.Collections.Specialized;
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
        //program.Task_1_4(0.5);
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
        program.Task_3_8(0.1);
        //program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;

        // code here
        for (int i = 2; i <= 35; i += 3)
            answer += i;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        double ans = 0;
        for (double i = 1; i <= 10; i++)
            ans += (1 / i);
        answer = Math.Round(ans, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double ans = 0;
        for (double i = 2; i <= 112; i += 2)
            ans += (i / (i + 1));
        answer = Math.Round(ans);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if (x != 0)
        {
            double x1 = 1.0;
            for (int i = 1; i < 10; i++)
            {
                answer += Math.Cos(i * x) / x1;
                x1 *= x;
            }
            answer = Math.Round(answer, 2);
        }
        else
            answer = 0;
        // end
        Console.WriteLine(answer);

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        double ans = 0;
        for (int i = 0; i <= 9; i++)
            ans += (p + i * h) * (p + i * h);
        // end
        answer = ans;
        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = x * (0.5 * x - 7);
        // end
        answer = Math.Round(answer, 2);

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        answer = 1;
        for (int i = 1; i <= 6; i++)
            answer *= i;
        // end
        Console.WriteLine(answer);

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int faq = 1;
        for (int i = 1; i <= 6; i++)
        {
            faq *= i;
            answer += faq;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double faq = 1;
        double pt = 5;
        for (int i = 1; i <= 6; i++)
        {
            faq *= i;
            if (i % 2 == 0)
                answer += 1 * pt / faq;
            if (i % 2 == 1)
                answer += (-1) * pt / faq;
            pt *= 5;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        answer = 3;
        for (int i = 2; i <= 7; i++)
            answer *= 3;
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i <= 6; i++)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
        for (int i = 1; i <= 6; i++)
        {
            Console.Write("5 ");
        }

        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        answer = 1.0;
        double x1 = 1;
        if (x == 0) { 
            answer = 0;
        } 
        else {

            for (int i = 1; i <= 10; i++)
            {
                x1 *= x;
                answer += (1 / x1);
            }
        }
        // end
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= (-1))
            answer = 1;
        if (x <= 1 && x > (-1))
            answer = (-x);
        if (x > 1)
            answer = (-1);
        // end
        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        Console.Write("1 ");
        Console.Write("1 ");
        int j = 1;
        int k = 1;
        int ans;
        for (int i = 0; i < 6; i++)
        {
            ans = k + j;
            Console.Write("{0} ",ans);
            j = k;
            k = ans;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double ch0 = 1;
        double zn0 = 1;
        double ch1 = 2;
        double zn1 = 1;
        double ch;
        double zn;
        for (int i = 3; i <= 5; i++)
        {
            ch = ch0 + ch1;
            ch0 = ch1;
            ch1 = ch;
            zn = zn0 + zn1;
            zn0 = zn1;
            zn1 = zn;
            answer = ch1 / zn1;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 1;
        int power = 0;


        // code here
        double ans = 1;
        for (int i = 0; i < 63; i++)
        {
            ans *= 2;
            answer += ans;
        }
        answer /= 15;
        while (answer > 10)
        {
            answer /= 10;
            power++;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        Console.WriteLine(power);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double R = 6350;
        answer = Math.Sqrt(x * (2 * R + x));
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
            answer *= 2;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 1;
        int ans = 1;
        // code here
        while (ans <= 30000)
        {
            answer += 3;
            ans *= answer;
        }
        answer -= 3;
        Console.WriteLine(answer);
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
        double p = x * x;
        double answer = 1;

        // code here
        if (Math.Abs(x) < 1)
        {
            while (p >= 0.0001)
            {
                answer += p;
                p *= x * x;
            }
            answer += p;
            answer = Math.Round(answer, 2);
        }
        else
            answer = 0;
        // end

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
        int ans = 10;
        while (ans <= 100000)
        {
            ans *= 2;
            answer += 3;
        }
        Console.WriteLine(answer);
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
        double sum = 10000;
        while (sum < 20000)
        {
            answer++;
            sum *= 1.08;
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
        int answer = 0;

        // code here;
        double ans;
        double ch0 = 1;
        double zn0 = 1;
        double ch1 = 2;
        double zn1 = 1;
        double ch;
        double zn;
        answer = 2;
        while (Math.Abs((ch1 / zn1) - (ch0 / zn0)) > 0.001)
        {
            ch = ch0 + ch1;
            ch0 = ch1;
            ch1 = ch;
            zn = zn0 + zn1;
            zn0 = zn1;
            zn1 = zn;
            ans = ch1/zn1;
            answer++;
        }
        Console.WriteLine(answer);
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
        double ans = 1;
        int faq = 1;
        int cnt = 1;
        double p = 1;
        S += ans;

        // code here
        while (1 == 1)
        {
            faq *= cnt;
            p *= (2 * x);
            ans = p / faq;
            if (Math.Abs(ans) < 0.0001)
                break;
            S += ans;
            cnt++;
        }
        y = Math.Exp(2 * x);

        Console.WriteLine(S);
        Console.WriteLine(y);
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