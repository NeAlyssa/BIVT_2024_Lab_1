using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

        //program.Task_1_1();
        //program.Task_1_2();
        //program.Task_1_3();
        //Console.WriteLine(program.Task_1_4(0));
        //Console.WriteLine(program.Task_1_5(0.5, 2));
        //program.Task_1_6(-4);
        //Console.WriteLine(program.Task_1_7());
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
        //Console.WriteLine(program.Task_2_1(0));
        //program.Task_2_2();
        //Console.WriteLine(program.Task_2_3(1, 1, 10));
        //Console.WriteLine(program.Task_2_3(-0.1, 1.9, 5.85));
        //Console.WriteLine(program.Task_2_3(0, 5, 985));
        //Console.WriteLine(program.Task_2_3(8, 2, 0));
        //Console.WriteLine(program.Task_2_3(0.2, -1.9, 12));
        //program.Task_2_4(0.8);
        //Console.WriteLine(program.Task_2_5(1, 0));
        //program.Task_2_6();
        //program.Task_2_7a();
        //program.Task_2_7b();
        //program.Task_2_7c();
        //program.Task_2_8();
        //program.Task_2_9();
        //program.Task_2_10();
        //program.Task_3_1(0.1);
        //program.Task_3_2(0.1);
        for (double i = 0.1; i <= 1; i += 0.1)
        {
            program.Task_3_3(i);
        }
        
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

        for (int i = 2; i <= 35; i += 3)
        {
            answer += i;
        }


        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        for (double i = 1; i <= 10; i += 1)
        {
            answer += 1 / i;
        }

        return Math.Round(answer, 2);
    }
    public double Task_1_3()
    {
        double answer = 0;

        for (double i = 2; i <= 112; i += 2)
        {
            answer += (i) / (i + 1);
        }

        return Math.Round(answer, 2);
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        if (x == 0)
        {
            return 0;
        }

        for (int i = 1; i <= 9; i += 1)
        {
            answer += (Math.Cos(x * i)) / Math.Pow(x, i - 1);
        }

        return Math.Round(answer, 2);
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        for (int i = 1; i <= 10; i += 1)
        {
            answer += Math.Pow((p + (i - 1) * h), 2);
        }

        return Math.Round(answer, 2);
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        for (double k = -4; k <= 4; k += 0.5)
        {
            Console.WriteLine(Math.Round((0.5*k*k - 7*k), 2));
        }

        answer = (0.5 * x*x) - 7 * x;

        return Math.Round(answer, 2);
    }
    public int Task_1_7()
    {
        int answer = 1;

        for (int i = 1; i <= 6; i += 1)
        {
            answer *= i;
        }

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;
        int curr = 1;
        for (int i = 1; i <= 6; i++)
        {
            curr *= i;
            answer += curr;
        }


        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        int factorial(int n)
        {
            int res = 1;
            for (int i = 1; i <= n; i++)
            {
                res *= i;
            }
            return res;
        }

        for (int i = 1; i <= 6; i++)
        {
            answer += Math.Pow(-1, i) * Math.Pow(5, i) / factorial(i);
        }

        return Math.Round(answer, 2);
    }
    public int Task_1_10()
    {
        int answer = 1;

        for (int i = 1; i <= 7; i++)
        {
            answer *= 3;
        }

        return answer;
    }
    public void Task_1_11()
    {

        Console.Out.NewLine = " ";

        for (int i = 1; i <= 6; i++)
        {
            Console.WriteLine(i);
        }
        Console.Out.NewLine = "";
        Console.WriteLine("\r\n");
        Console.Out.NewLine = " ";
        for (int i = 1; i <= 6; i++)
        {
            Console.WriteLine(5);
        }
    }
    public double Task_1_12(double x)
    {
        double answer = 0;
        if (x == 0)
        {
            return 0;
        }
        for (int i = 0; i <= 10; i++)
        {
            answer += 1 / Math.Pow(x, i);
        }

        return Math.Round(answer, 2);
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        for (double k = -1.5; k <= 1.5; k += 0.1)
        {
            if (k <= -1) { Console.WriteLine(1); }
            if (k > 1) { Console.WriteLine(-1); }
            if (k > -1 && k <= 1) { Console.WriteLine(Math.Round((-1 * k), 2)); }
        }

        if (x <= -1)
        {
            answer = 1;
        }
        if (x > 1)
        {
            answer = -1;
        }
        if (x > -1 && x <= 1)
        {
            answer = -1.0 * x;
        }

        return answer;
    }
    public void Task_1_14()
    {
        Console.WriteLine('1');
        int prev = 0;
        int next = 1;
        for (int i = 1; i <= 8; i++)
        {
            int sum = prev + next;
            prev = next;
            next = sum;
            Console.WriteLine(sum);


        }

    }
    public double Task_1_15()
    {
        double answer = 0;

        int prev_up = 1;
        int prev_down = 1;
        int next_up = 2;
        int next_down = 1;

        for (int i = 1; i <= 5; i++)
        {
            int sum_up = prev_up + next_up;
            int sum_down = prev_down + next_down;
            //Console.WriteLine(sum_down);
            //Console.WriteLine(sum_up);
            float res = (float)sum_up / sum_down;
            Console.WriteLine(res);
            prev_up = next_up;
            prev_down = next_down;
            next_up = sum_up;
            next_down = sum_down;
            answer = Math.Round(res, 1);
        }
        Console.WriteLine(answer);
        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        float c = 1;
        float sum = 1;
        for (int i = 1; i <= 63; i++)
        {

            c *= 2;
            sum += c;

        }
        sum /= 15;
        while (sum > 10)
        {
            sum /= 10;
            power++;
        }
        Console.WriteLine(sum);
        Console.WriteLine(power);

        answer = Math.Round(sum, 2);

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        int r = 6350;

        answer = Math.Pow((Math.Pow(r + x, 2) - Math.Pow(r, 2)), 0.5);

        return Math.Round(answer, 2);
    }
    public int Task_1_18(int x)
    {
        int answer = 0;
        int count = 10;
        for (int i = 1; i <= x; i++)
        {
            if (i % 3 == 0)
            {
                count *= 2;
            }
        }
        answer = count;
        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;
        int n = 1;
        while (true) {
            double el = Math.Cos(n * x) / Math.Pow(n, 2);
            
            n++;
            if (Math.Abs(el) < 0.0001)
            {
                break;
            }
            answer += el;
        }
        //Console.WriteLine(Math.Round(answer, 2));
        return (answer);
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
        int n = 0;
        double s = 0;
        bool flag = true;
        while (flag)
        {

            s += (a + n * h);
            n++;
            if ((s + (a + (n+1)*h)) < s) { return 0; }
            if (s <= p) { answer++; }

            if (s > p)
            {
                flag = false;
            }
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
        if (M == 0) { return (0, 0); }
        while (N >= M)
        {
            N -= M;
            quotient++;
            if (N < M)
            {
                remainder = N;
                return (quotient, remainder);
            }
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
        double answer = 0;
        double s = 10;

        for (int i = 1; i <= 7; i++)
        {
            answer += s;
            s *= 1.1;
        }
        Console.WriteLine(answer);
        return Math.Round(answer, 2);
    }
    public int Task_2_7b()
    {
        int answer = 0;
        double today = 10;
        double s = 0;
        int c = 1;

        while (true)
        {
            today *= 1.1;
            s += today;
            c++;
            if (s >= 100)
            {
                answer = c;
                break;
            }
        }

        Console.WriteLine(answer);
        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;
        double today = 10;
        int c = 0;

        while (today <= 20)
        {
            today *= 1.1;
            c++;
        }
        Console.WriteLine(c);
        answer = c;
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

        double l = 0.1;
        int c = 0;
        while (l > Math.Pow(10, -10))
        {
            c++;
            l /= 2;
        }
        answer = c;
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
        double S = 1, y = 0;

        y = Math.Exp(Math.Cos(x)) * Math.Cos(Math.Sin(x));

        double el;
        int fact = 1;

        for (int i = 1; i <= 9999999; i++)
        {
            el = Math.Cos(x * i) / fact;
            fact *= (i+1);
            

            if (Math.Abs(el) < 0.0001)
            {
                Console.WriteLine(S);
                Console.WriteLine(y);
                return (S, y);
            }

            S += el;
        }

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
