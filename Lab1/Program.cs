using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

        program.Task_1_1();
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
        program.Task_1_18(24);
        program.Task_2_1(1);
        //program.Task_2_2();
        program.Task_2_3(-0.1, 1.9, 5.85);
        //program.Task_2_4(0.8);
        program.Task_2_5(11, 5);
        //program.Task_2_6();
        program.Task_2_7a();
        program.Task_2_7b();
        program.Task_2_7c();
        //program.Task_2_8();
        program.Task_2_9();
        //program.Task_2_10();
        //program.Task_3_1(0.1);
        //program.Task_3_2(0.1);
        //program.Task_3_3(0.1);
        //program.Task_3_4(0.1);
        program.Task_3_5(double.Pi/5);
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
        for (int k = 2; k <= 35; k += 3)
        {
            answer += k;
        }
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double k = 1; k <= 10; k++)
        {
            answer += 1 / k;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double k = 2; k < 113; k+=2)
        {
            answer += (k / (k + 1));
        }
        answer = Math.Round(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double denom = 1;  //denom = Math.Pow(x, k - 1)
        for (int k = 1; k < 10; k++)
        {
            answer += Math.Cos(k * x) / denom;
            denom *= x;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int k = 0; k < 10; k++)
        {
            double tmp = p + k * h;
            answer += tmp * tmp;
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
        answer = 1;
        int i = 1;
        do
        {
            i++;
            answer *= i;
        } while (i < 6);

        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int fac = 1;
        for (int k = 1; k <= 6; k++)
        {
            fac *= k;
            answer += fac;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double nom = -5;
        double denom = 1;
        for (int k = 1; k <= 6; k++, nom *= -5, denom *= k)
        {
            answer += nom / denom;
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
        for (int k = 1; k <= 7; k++)
        {
            answer *= 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int k = 1; k <= 6; k++)
        {
            Console.Write($"{k} ");
        }
        Console.WriteLine();
        for (int k = 1; k <= 6; k++)
        {
            Console.Write("5 ");
        }
        Console.WriteLine();
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double denom = 1;
        for (int k = 0; k <= 10; k++, denom *= x)
        {
            if (denom == 0)
                return 0;
            answer += 1 / denom;
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
            answer = 1;
        else if (x <= 1)
            answer = -1 * x;
        else
            answer = -1;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a = 1;
        int b = 1;
        int c;
        int count = 1;
        while (count <= 2)
        {
            Console.Write("1 ");
            count++;
        }
        while (count <= 8)
        {
            c = a + b;
            Console.Write($"{c} ");
            a = b;
            b = c;
            count++;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        int nom1 = 1, nom2 = 2, denom1 = 1, denom2 = 1;
        int newnom = 3, newdenom = 2;
        for (int k = 3; k <= 5; k++)
        {
            newnom = nom1 + nom2;
            newdenom = denom1 + denom2;

            nom1 = nom2;
            denom1 = denom2;
            nom2 = newnom;
            denom2 = newdenom;
        }
        answer = (double)newnom / (double)newdenom;
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double num = 1 / (double)15;
        for (int k = 0; k < 64; k++)
        {
            num *= 2;
            double tmp = num;
            while (tmp >= 10)
            {
                tmp /= 10;
                power++;
            }
            num = tmp;
        }
        answer = num;
        answer = Math.Round(answer, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double rad = 6350;
        answer = Math.Sqrt(x * (x + 2 * rad));
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        answer = 10;
        for (int k = 3; k <= x; k += 3) // ???
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
        int n = 1;
        double next = Math.Cos(x);
        while (Math.Abs(next) >= 0.0001)
        {
            answer += next;
            n++;
            next = Math.Cos(n * x) / (n * n);
        }
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
        if (a > p)
            return 0;
        double sum = a;
        int n = 1;
        while (sum <= p)
        {
            if (sum + a + n * h <= sum)
                return 0;

            sum += a + n * h;
            n++;
            answer++;
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
        if (N == 0 || M == 0)
            return (0, 0); 

        remainder = N;
        while (remainder >= M)
        {
            quotient++;
            remainder -= M;
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
        double length = 10;
        for (int k = 1; k <= 7; k++)
        {
            answer += length;
            length *= 1.1;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double length = 10;
        double sumLength = 0;
        while (sumLength < 100)
        {
            sumLength += length;
            length *= 1.1;
            answer++;
        }
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double length = 10;
        while (length <= 20)
        {
            length *= 1.1;
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
        double threadLength = 0.1;
        double atomLength = 0.0000000001; //10e-10?
        while (threadLength >= atomLength)
        {
            threadLength /= 2;
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
        double a = Math.PI / 5;
        double b = Math.PI;
        double h = Math.PI / 25;
        //for(double k = a; k <= b; k +=h)
        //{
        int sign = -1;
        int counter = 1;
        double part = -Math.Cos(x);
        while (Math.Abs(part) >= 0.0001)
        {
            S += part;
            sign *= -1;
            counter++;
            part = sign * Math.Cos(counter * x) / (counter * counter);
        }
        y = (x * x - Math.PI * Math.PI / 3) / 4;
        //}
        // end
        //Console.WriteLine($"S = {S}, y = {y}");
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