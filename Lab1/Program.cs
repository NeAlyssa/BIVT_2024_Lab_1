using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

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
        program.Task_3_6(0.1);
        //program.Task_3_7(0.1);
        //program.Task_3_8(0.1);
        //program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;

        // code here
        for (int i = 2; i <= 35; i += 3) answer += i;


        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double i = 1; i <= 10; i++) answer += 1 / i;
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
        double b = 1;
        // code here
        if (x!=0)
            {
                for (int i = 1; i <= 9; i++) 
                {
                answer += Math.Cos(x*i) / b;
                b *= x;
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
        for (int i = 0; i<=9; i++)
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
        answer = 0.5 * x * x - 7*x;
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for (int i = 1; i<=6;i++)
        {
            answer = answer * i;
        }
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;
        int l = 1;
        // code here;
        for (int i = 1; i<=6; i++)
        {
            l *= i;
            answer += l;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        double a = 1, b = 1;
        double l = 1;
        // code here;
        for (double i = 1; i <= 6; i++)
        {
            l *= i;
            a *= -1;
            b *= 5;
            answer += a * b / l;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        for (int i = 1; i <= 7; i++) answer *= 3;
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
            Console.Write(5 + " ");
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;
        double a = 1;
        // code here
        if (x != 0)
        {
            for (double i = 0; i <= 10; i++)
            {
                answer += 1 / a;
                a *= x;
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
        if (x <= -1) answer = 1;
        else if ((-1 < x) && (x <= 1)) answer = -x;
        else if (x>1) answer = -1;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a = 1, b = 1;
        int next;
        for (int i = 0; i < 8; i++)
        {
            
            Console.Write(a.ToString() + ' ');
            next = a + b;
            a = b;
            b = next;
        }

        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double a1 = 1, b1 = 1;
        double next1;
        double a2 = 1, b2 = 2;
        double next2;
        for (int i = 0; i < 5; i++)
        {
            answer = a2 / a1;
            next1 = a1 + b1;
            a1 = b1;
            b1 = next1;
            next2 = a2 + b2;
            a2 = b2;
            b2 = next2;

        }
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double b = 1, a = 1;
        for (int i = 1; i <= 64; i++)
        {
            answer += a;
            a = a * 2;
        }
        answer /= 15;
        power = (int)Math.Log10(answer);
        for (int k = 1; k <= power; k++) b *= 10;
        answer = Math.Round(answer / b, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        //H = ((R + d)^2 - R^2))^0.5
        // code here
        double R = 6350;
        answer = Math.Sqrt((R + x) * (R + x) - R * R);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here
        for (int i = 3; i<=x; i +=3 )
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
        
        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 0;

        // code here
        int n = 1;
        int p = 1;
        while (p * (n+3) <= 30000)
        {
            p *= (n + 3);
            n += 3;
        }
        answer = n;
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
        double answer = 0;

        // code here
        double  n = 0;

        if (Math.Abs(x) < 1)
        {
            double a = 1;
            do
            {
                answer += a;
                a *= x * x;
                n++;
            } while (a >= 0.0001);
        }
        else answer = 0;

        answer = Math.Round(answer, 2);
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
        int count = 10;
        while (count < 100000)
        {
            count *= 2;
            answer+=3;
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
        double sum = 10000;

        while (sum < 20000)
        {
            sum *= 1.08;
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
        int answer = 0;

        // code here;
        double n2 = 0, n1 = 0;

        // code here
        double a1 = 1, b1 = 1;
        double next1;
        double a2 = 1, b2 = 2;
        double next2;
        while (true)
        {
            n2 = a2 / a1;
            next1 = a1 + b1;
            a1 = b1;
            b1 = next1;
            next2 = a2 + b2;
            a2 = b2;
            b2 = next2;
            answer++;
            if (Math.Abs(n2 - n1) <= 0.001) break;
            n1 = n2;
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
        double t = 1;
        double a1 = -1, a2 = x, a3 = 4;
        int i = 1;
        // code here
        y = (1 + x * x) * Math.Atan(x) / 2 - x / 2;
        while (Math.Abs(t) >= 0.0001)
        {
            a1 *= -1;
            a2 *= x * x;
            a3 = 4 * i * i - 1;
            t = a1 * a2 / a3;
            if (Math.Abs(t) >= 0.0001) S += t;
            i++;
        }
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
