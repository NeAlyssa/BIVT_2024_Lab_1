using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics.Metrics;
using System.Net;
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
        for(int i = 2; i <= 35; i += 3)
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
        for(double i = 1; i <= 10; i += 1)
        {
            answer += 1/i;
        }
        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for(double i = 2; i <= 112; i += 2)
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

        // code here
        double den = 1;
        if (x == 0) return answer;
        else for (int i = 1; i <= 9; i ++)
            {
                answer += Math.Cos(x * i) / den;
                den *= x;
            }
  
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i = 0; i <= 9; i+=1)
        {
            double n = 1;
            for (int k = 1; k <= 2; k++)
            {
                n *= p + i * h;
            }
            answer += n;
        }
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * x*x - (7 * x);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        answer = 1;
        for (int i = 1; i <=6; i++)
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
        int f = 1;
        for (int i = 1; i <= 6; i++)
        {
            f *= i;
            answer += f;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        int f = 1;
        for (int i = 1; i <= 6; i++)
        {
            f *= i;

            double n_1 = 1;
            double n_5 = 1;
            for (int k = 1; k <= i; k++)
            {
                n_1 *= (-1);
                n_5 *= 5;
            }
            answer += n_1*n_5/f;
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
        for (int i = 1; i <= 7; i++)
        {
            answer *= 3; 
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task;
        Console.Write("a)");
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(" " + i);

        }
        Console.WriteLine();
        Console.Write("б)");
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(" " + "5");

        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double den = 1;
        if (x == 0) return answer;
        else for (double i = 0; i <= 10; i += 1)
        {
            answer += 1 / den;
            den *= x;
            }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 1;
        else if (-1 < x && x <= 1) answer = -x;
        else if (x > 1) answer = -1;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int n1 = 1;
        int n2 = 1;
        Console.Write(n1 + " " + n2);
        for (int i = 1; i <= 6; i++)
        {
            int sum_n = n1 + n2;
            Console.Write(" " + sum_n);
            n1 = n2;
            n2 = sum_n;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double num1 = 1;
        double dem1 = 1;
        double num2 = 2;
        double dem2 = 1;
        for (int i = 1; i <= 3; i++)
        {
            double sum_num = num1 + num2;
            double sum_dem = dem1 + dem2;
            num1 = num2;
            dem1 = dem2;
            num2 = sum_num;
            dem2 = sum_dem;
            answer = num2 / dem2;
        }

        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double n = 1;
        for (int i = 1; i <= 64; i++)
        {
            n *= 2;
        }
        n = n - 1; //по г.п. сумма зерен 2**64-1
        n /= 15;
        power = (int) Math.Log10(n);
        double den = 1;
        for (int i = 1; i <= power; i++)
        {
            den *= 10;
        }
        answer = n / den;
        answer = Math.Round(answer, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double r = 6350;
        answer = (r + x)*(r + x) - r*r;
        answer = Math.Sqrt(answer);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int power = 2;
        for (int i = 1; i < x/3; i++)
        {
            power *= 2;
        }
        answer = 10 * power;
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
        int p = 1;
        for (int n = 1; p * n < 30000; n += 3)
        {
            p *= n;
            answer = n;
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
        double answer = 0;

        // code here
        if (x == 1) return 0;
        double m = x*x;
        double s = 1;
        while (m >= 0.0001)
        {
            s += m;
            m *= x * x;
            
        }
        answer = Math.Round(s,2);
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
       for (int i = 10; i <= 100000; i *= 2)
        {
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
        for (double i = 10000; i < 20000; i *= 1.08)
        {
            answer += 1;
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
        double ans = 0;
        double num1 = 1;
        double den1 = 1;
        double num2 = 2;
        double den2 = 1;
        answer = 2; 
        double previous = num1 / den1;
        double current = num2 / den2;
        while (Math.Abs(previous - current) >= 0.001)
        {
            previous = current;
            double sum_num = num1 + num2;
            double sum_den = den1 + den2;
            num1 = num2;
            den1 = den2;
            num2 = sum_num;
            den2 = sum_den;
            ans = num2 / den2;
            current = num2 / den2;
            answer += 1;
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
        double n = 1, i = 1, k = -1, power_x = 1, factorial = 2;
        S = 1;
        while (Math.Abs(n) >= 0.0001)
        {
            power_x *= x * x;
            n = k * power_x / factorial;
            if (Math.Abs(n) >= 0.0001)
            {
                S += n;
            }
            i++;
            factorial *= (2 * i) * (2 * i - 1);
            k = -k;
        }
        y = Math.Cos(x);
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