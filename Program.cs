using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using System.Text;

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
        // program.Task_1_11();
        program.Task_1_12(0.9);
        program.Task_1_13(-1.5);
        // program.Task_1_14();
        program.Task_1_15();
        program.Task_1_16();
        program.Task_1_17(10);
        program.Task_1_18(24);
        //program.Task_2_1(0);
        program.Task_2_2();
        //program.Task_2_3(8, 2, 0);
        program.Task_2_4(0.8);
        //program.Task_2_5(11, 5);
        program.Task_2_6();
        //program.Task_2_7a();
        //program.Task_2_7b();
        //program.Task_2_7c();
        program.Task_2_8();
        //program.Task_2_9();
        program.Task_2_10();
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
        for (double i = 1; i <= 10; i++)
        {
            answer = answer + (1 / i);
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
            answer += (i / (i + 1));
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double my_pow(double x, double y)
        {
            double p = 1;
            for (int i = 0; i < y; i++)
            {
                p *= x;
            }

            return p;
        }

        if (x > 0)
        {
            for (double p = 1; p < 10; p++)
            {
                answer += Math.Cos((x * p)) / (my_pow(x, p - 1));
            }
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i = 0; i <= 9; i++)
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
        double f(double x) {
            double res = 0.5 * x * x - 7 * x;
            return res;
        }
        for (double i = -4; i <= 4; i += 0.5)
        {
            answer = f(i);
        }
        answer = Math.Round(f(x));
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        answer = 1;
        for (int i = 1; i <= 6; i++)
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
            int f = 1;
            for (int j = 1; j <= i; j++)
            {
                f *= j;
            }
            answer += f;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double my_pow(double x, double y)
        {
            double p = 1;
            for (int i = 0; i < y; i++)
            {
                p *= x;
            }

            return p;
        }

        double fact(double x) {
            int f = 1;
            for (int i = 1; i <= x; i++)
            {
                f *= i;
            }
            return f;
        }

        for (double i = 1; i <= 6; i += 1)
        {
            answer += my_pow(-1, i) * my_pow(5, i) / fact(i);
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
        // There is no test for this task
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(i); Console.Write(" ");
        }
        Console.WriteLine();
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(5); Console.Write(" ");
        }
        Console.WriteLine();
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double my_pow(double x, double y)
        {
            double p = 1;
            for (int i = 0; i < y; i++)
            {
                p *= x;
            }

            return p;
        }

        if (x != 0)
        {
            for (double i = 0; i <= 10; i++)
            {
                answer += 1 / (my_pow(x, i));
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
        double f(double x) {
            if (x <= -1)
            {
                return 1;
            }
            else if (x <= 1)
            {
                return (-1) * x;
            }
            else
            {
                return -1;
            }
        }
        for (double i = -1.5; i <= 1.5; i += 0.1)
        {   
            double res = Math.Round(f(i), 1);
        }
        answer = f(x);
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        Console.WriteLine();
        int f1 = 1; int f2 = 1; int f3 = 2;
        int i = 3;
        int[] fib = [1, 1, 2, 0, 0, 0, 0, 0];
        while (i < 8)
        {
            f1 = f2;
            f2 = f3;
            f3 = f2 + f1;
            fib[i] = f3;
            i++;
        }
        for (int j = 0; j < 8; j++)
        {
            Console.WriteLine(fib[j]);
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double c1=1.0, c2=2.0, z1=1.0, z2=1.0, c3, z3;
        for (int i = 0; i < 3; i++)
        {
            c3 = c1 + c2; z3 = z1 + z2;
            answer = c3 / z3;
            c1 = c2; c2 = c3; z1 = z2; z2 = z3;
        }
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 1;
        int power = 0;

        // code here 
        for (int i = 1; i <= 64; i++)
        {
            answer *= 2;
        }
        answer /= 15;
        while (answer >= 10)
        {
            answer /= 10.0;
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
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int loop = x / 3;
        int amebi = 10;
        for (int i = 0; i < loop; i++)
        {
            amebi *= 2;
        }
        answer = amebi;
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
        int L = 30000;
        int pr = 1;
        for (int i = 1; (pr * i) <= L; i += 3)
        {
            pr *= i;
            answer = i;
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
        double my_pow(double x, double y)
        {
            double p = 1;
            for (int i = 0; i < y; i++)
            {
                p *= x;
            }

            return p;
        }

        double power = 2;
        if (x == 1)
        {
            return 0;
        }
        answer += 1.0;
        while (my_pow(x, power) >= 0.0001) {
            answer += my_pow(x, power);
            power += 2;
        }
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
        int cells = 10;
        while (cells < 100000)
        {
            answer += 3;
            cells *= 2;
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
        double vklad = 10000;
        while (vklad < 20000)
        {
            vklad *= 1.08;
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
        double c1 = 1.0, c2 = 2.0, z1 = 1.0, z2 = 1.0, c3, z3;
        answer += 2; // первые два члена последовательности уже известны
        double pred = -2;
        double current = 0;
        while (Math.Abs(current - pred) > 0.001)
        {
            pred = current;
            c3 = c1 + c2; z3 = z1 + z2;
            current = c3 / z3;
            c1 = c2; c2 = c3; z1 = z2; z2 = z3;
            answer++;
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
        double my_pow(double x, double y)
        {
            double p = 1;
            for (int i = 0; i < y; i++)
            {
                p *= x;
            }

            return p;
        }

        double f(double x)
        {
            double p = 1;
            for (int i = 1; i <= x; i++)
            {
                p *= i;
            }
            return p;
        }

        double el = 0;
        double znak = -1, power = 0, fact = 0, e = 0.0001, powered = 1;
        int i = 0;
        do
        {
            znak *= -1;
            power = 2 * i;
            if (fact == 0)
            {
                el = znak * 1 / 1;
                S += el;
            }
            else
            {
                fact = f(2 * i);
                el = znak * my_pow(x, power) / fact;
                S += el;
            }
            i++;
        } while (Math.Abs(el) >= e);
        S = Math.Round(S, 2);
        y = Math.Round(Math.Cos(x), 2);
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