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
        for (double i = 1.0; i <= 10.0; i++)
        {
            answer += (1 / i);
        }
        answer = Math.Round(answer,2);
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
        double term = 1;
        
        if (x != 0)
        {
            for (int i = 0; i <= 8; i++)
            {
                answer += Math.Cos((i + 1) * x) / term;
                term *= x;
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
        for (int i = 0; i < 10; i++)
        {
            double term = p + i * h;
             answer += term * term;
        }
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = Math.Round(0.5 * x * x - 7 * x, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        answer = 1;
        for(int i = 1; i <= 6; i ++)
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
        for (int i = 1; i <= 6; i++)
        {
            int factorial = 1;
            for (int j = 1; j <= i; j++)
            {
                factorial *= j;
            }
            answer += factorial;
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
            double term = (i % 2 == 0) ? 1 : -1; // (-1)^i
            int fivePower = 1;

            for (int k = 1; k <= i; k++)
            {
                fivePower *= 5;
            }

            int factorial = 1;

            for (int j = 1; j <= i; j++)
            {
                factorial *= j;
            }

            term *= fivePower;
            term /= factorial;
            answer += term;
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
        for (int i = 1; i <= 7; i ++)
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
            Console.Write(i + " ");
        }

        Console.WriteLine();

        for (int i = 1; i <= 6; i++)
        {
            Console.Write("5 ");
        }
    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double term = 1;
        
        for (double i = 0; i < 11; i++)
        {
            if (x != 0)
            {
                answer += 1 / term;
                term *= x;
            }
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        for (double h = -1.5; h <= 1.5; h += 0.1)
        {
            if (x > 1)
            {
                answer = -1;
            }
            else if (x <= -1)
            {
                answer = 1;
            }
            else
            {
                answer = -x;
            }
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a = 1, b = 1;
        Console.Write(a + " " + b + " ");
        for (int i = 2; i < 8; i ++)
        {
            int temp = a + b;
            a = b;
            b = temp;
            Console.Write(temp + " ");
        }
            // code here

        }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double ch = 1, znam = 1;
        for (int i = 1; i < 5; i++)
        {
            answer = ch + znam;
            znam = ch;
            ch = answer;
        }
        answer = ch / znam;
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double sum = 1;
        double step = 1;

        for(int i = 0; i < 64; i ++)
        {
            if (answer > step * 10)
            {
                step *= 10;
                power += 1;
            }
            answer += sum;
            sum *= 2;
        }
        answer /= step * 15;
        answer = Math.Round(answer, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        const double R = 6350;

        answer = Math.Round(Math.Sqrt(2 * R * x + x*x),2);

        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        answer = 10;
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

        // code here

        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 0;

        // code here
        int L = 1;
        int n = 4;
        while(L <= 30000)
        {
            L *= n;
            n += 3;
            if ((L *= (n+3)) >= 30000)
            {
                break;
            }
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
        const double eps = 0.0001;
        double a;
        int term = 0;
        
        if (x == 1)
        {
            return answer = 0;
        }

        do
        {
            a = Math.Pow(x, term);
            answer += a;
            term += 2;
        }
        while (Math.Abs(a) > eps);
        // end

        return Math.Round(answer, 2);
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
        int cells = 10;
        while(cells < 100000)
        {
            cells *= 2;
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
        double dep = 10000, r = 0.08; 
        int month = 0;

        while (dep < 20000)
        {
            dep += dep * r;
            month++;
        }
        answer = month;
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
        int i = 1;
        double ch = 1.0, znam = 1.0, drob = 0, drob1 = 1.0, sum = 0;
        while (Math.Abs(drob1 - drob) >= 0.001)
        {
            drob = ch / znam;
            sum = ch + znam;
            znam = ch;
            ch = sum;
            drob1 = ch / znam;
            i++; 
        }
        answer = i;
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
        int i = 1;
        double term = x;

        while (term >= 0.0001)
        {
            double n_step = term * Math.Sin(i * Math.PI / 4);
            S += n_step;
            term *= x;
            i++;
            
        }
        y = (x * Math.Sin(Math.PI / 4)) / (1 - (2 * x * Math.Cos(Math.PI / 4)) + x * x);

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