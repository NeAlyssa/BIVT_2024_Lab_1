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
            answer += i;
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double d = 1; d <= 10; d++)
        {
            answer += 1 / d;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2; i < 113; i = i + 2)
        {
            answer = answer + i / (i + 1);
        }
        answer = Math.Round(answer, 0);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double a = 1;
        for (int i = 1; i < 10; i++)
        {
            if (x != 0)
            {
                answer = answer + Math.Cos(i * x) / a;
                a *= x;
            }
            else
            {
                answer = 0;
            }
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (double i = 0; i < 10; i = i + 1)
        {
            answer = answer + ((p + i * h) * (p + i * h));
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        for (double i = -4; i < 5; i = i + 0.5)
        {
            answer = 0.5 * x * x - (7 * x);
            answer = Math.Round(answer, 2);
            Console.WriteLine("x = {0:f2}\tanswer = {1:f2}", x, answer);
        }
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;
        // code here
        long fac = 1;
        for (int i = 1; i <= 6; i++)
        {
            fac *= i;

        }
        answer = (int)fac;
       
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;
        long sum = 0;
        // code here;
        for (int i = 1; i <= 6; i++)
        {
            long fac = 1;
            for (int k = 1; k <= i; k++)
            {
                fac *= k;
            }
            sum += fac;
        }
        answer = (int)sum;
        
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double a = 1, b = 1, c = 1;
        for (int i = 1; i < 7; i = i + 1)
        {
            b *= -1;
            c *= 5;
            a *= i;
            answer = answer + b * (c / a);
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_10()
    {

        int answer = 1;
        int n = 3;
        // code here
        for (int i = 0; i < 7; i++)
        {
            answer *= n;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // code here
        for (int i = 1; i < 7; i = i + 1)
        {
            Console.WriteLine(i);
        }
        for (int i = 1; i < 7; i = i + 1)
        {
            Console.WriteLine(5);
        }
        // end

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double a = 1;
        for (int i = 0; i < 11; i = i + 1)
        {
            if (x != 0)
            {
                answer += 1 / a;
                a *= x;
            }
            else
            {
                answer = 0;
            }
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
        if (x <= -1)
        {
            answer = 1;
        }
        else if (x > 1)
        {
            answer = -1;
        }
        else
        {
            answer = -x;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int vtoroe = 0;
        int pervoe = 1;
        int a = 0;
        for (int i = 1; i < 8; i = i + 1)
        {
            Console.WriteLine(vtoroe);
            a = vtoroe;
            vtoroe = pervoe + vtoroe;
            pervoe = a;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double a = 1;
        double b = 1;
        double c = 1;
        double d = 1;
        double e = 0;
        double f = 0;
        for (int i = 1; i < 5; i++)
        {
            d = a;
            a = a + c;
            c = d;
            e = b;
            b = b + f;
            f = e;
        }
        answer = a / b;
        answer = Math.Round(answer, 1);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double a = 0;
        double b = 1;
        for (int i = 0; i < 64; i++)
        {
            b *= 2;

        }
        a = b / 15;
        power = (int)Math.Log10(a);
        answer = Math.Round(a / Math.Pow(10, power), 2);
        
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double R = 6350;
        answer = (R + x) * (R + x) - (R * R);
        answer = Math.Sqrt(answer);
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int a = 10;
        for (double i = 1; i < x; i += 3)
        {
            answer = a * 2;
            a = answer;
            Console.WriteLine(answer);
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
        int answer = 1;

        // code here

        int p = 1, l = 30000, n = 1;

        while (p * (n + 3) <= l)
        {
            n += 3;
            p *= n;
        }
        
        answer = n;
        //end

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
        const double e = 0.0001;
        double s = 0;
        int i = 0;
        if (Math.Abs(x) >= 1)
        {
            s = 0;
        }
        else
        {
            while (Math.Pow(x, i) >= e)
            {
                s = s + Math.Pow(x, i);
                i += 2;
            }
        }
        answer = Math.Round(s, 2);
        Console.WriteLine(answer);
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
        
        int amount = 10;
        const int target = 100000;
        // code here
        while (amount < target)
        {
            amount *= 2;
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
        
        const double k = 1.08;
        double currentAmount = 10000;
        double targetAmount = currentAmount * 2;
       
        while (currentAmount < targetAmount)
        {
            answer += 1;
            currentAmount *= k;
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
        double znam = 1, chisl = 1, bottle;
        double first_member = 1, second_member = 2;
        int number = 0;

        while (Math.Abs(second_member - first_member) > 0.001)
        {
            number += 1;
            
            first_member = second_member;
            second_member = znam / chisl;
            bottle = znam;
            znam += chisl;
            chisl = bottle;
        }
        answer = number;
        
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

        double i = 0;
        double n1 = 1;
        double n2 = 1;
        double d = 1;
        double p = n1 * n2 / d;
        while (Math.Abs(p) >= 0.0001)
        {
            S += p;
            i++;
            n1 = 2 * i + 1;
            n2 *= x * x;
            d *= i;
            p = n1 * n2 / d;
        }
        y = (1 + 2 * x * x) * Math.Pow(Math.E, Math.Pow(x, 2));
        Console.WriteLine(S);
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