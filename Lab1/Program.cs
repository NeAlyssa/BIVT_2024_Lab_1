using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        for (double i = 0.1; i <= 0.5; i += 0.05)
            Console.WriteLine("{0} {1}", Math.Round(program.Task_3_9(i).Item1, 2), program.Task_3_9(i).Item2);
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;

        for (int i = 2; i <= 35; i += 3)
            answer += i;

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        for (int i = 1; i <= 10; i++)
            answer += 1.0 / i;

        answer = Math.Round(answer, 2);

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        for (double i = 2; i <= 112; i += 2)
            answer += i / (i + 1);

        answer = Math.Round(answer, 2);

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        double lowest = 1;

        for (int i = 1; i <= 9; i++)
        {
            answer += Math.Cos(x * i) / lowest;
            lowest *= x;
        }

        answer = Math.Round(answer, 2);

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        for (int i = 0; i <= 9; i++)
            answer += (p + (i * h)) * (p + (i * h));

        answer = Math.Round(answer, 2);

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        answer = (0.5 * x * x) - (7 * x);

        answer = Math.Round(answer, 2);

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        for (int i = 1; i <= 6; i++)
            answer *= i;

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        int cur = 1;

        for (int i = 1; i <= 6; i++)
        {
            cur *= i;
            answer += cur;
        }

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        double up = -5, low = 1;

        for (int i = 1; i <= 6; i++)
        {
            low *= i;
            answer += up / low;
            up *= -5;
        }

        answer = Math.Round(answer, 2);

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 3;

        for (int i = 1; i != 7; i++)
            answer *= 3;

        return answer;
    }
    public void Task_1_11()
    {
        Console.Write("а) ");
        for (int i = 1; i != 7; i++)
            Console.Write(i.ToString() + " ");
        Console.WriteLine();
        Console.Write("б) ");
        for (int i = 1; i != 7; i++)
            Console.Write("5 ");
    }
    public double Task_1_12(double x)
    {
        if (x != 0)
        {
            double answer = 0;

            double low = 1;

            for (int i = 0; i <= 10; i++)
            {
                answer += 1.0 / low;
                low *= x;
            }

            answer = Math.Round(answer, 2);

            return answer;
        }
        else
        {
            return 0;
        }
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        if (x <= -1)
            answer = 1.0;

        if (x > -1 && x <= 1)
            answer = -x;

        if (x > 1)
            answer = -1.0;

        return answer;
    }
    public void Task_1_14()
    {
        int a = 1, b = 1;
        Console.Write("Числа Фибоначи : 1 1 ");
        for (int i = 3; i <= 8; i++)
        {
            Console.Write((a + b).ToString() + " ");
            int c = a + b;
            a = b; b = c;
        }

    }
    public double Task_1_15()
    {
        double answer = 0;

        double a1 = 1, b1 = 1;
        double a2 = 1, b2 = 2;

        for (int i = 3; i <= 5; i++)
        {
            double a3 = a1 + a2, b3 = b1 + b2;
            a1 = a2; b1 = b2; a2 = a3; b2 = b3;
        }

        answer = Math.Round(b2 / a2, 2);

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        for (int i = 0; i <= 63; i++)
        {
            answer += Math.Pow(2, i);
        }

        answer /= 15;

        while (Math.Pow(10, power) < answer)
        {
            power++;
        }

        power--;

        answer = Math.Round(answer / Math.Pow(10, power), 2);

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        answer = Math.Sqrt(((6350 + x) * (6350 + x)) - 40322500);

        answer = Math.Round(answer, 2);

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        for (int i = 3; i <= x; i += 3)
            answer *= 2;

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        for (int i = 1; !(Math.Abs(Math.Cos(x * i) / (i * i)) < 0.0001); i++)
        {
            answer += Math.Cos(x * i) / (i * i);
        }

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

        double sumi = 0;

        if (a < 0 && h < 0)
            return 0;

        for (; sumi <= p; answer++)
        {
            sumi += a + (h * answer);
            if (a > 0 && (a + (h * answer)) < 0)
                return 0;
        }

        answer--;

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
        int quotient = 0, remainder = N;

        if (M == 0)
        {
            return (0, 0);
        }

        while (remainder >= M)
        {
            quotient++;
            remainder -= M;
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

        double path = 10;

        for (int i = 0; i != 7; i++)
        {
            answer += path;
            path *= 1.1;
        }

        answer = Math.Round(answer, 2);

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        double total_path = 0;

        double path = 10;

        for (; total_path < 100; answer++)
        {
            total_path += path;
            path *= 1.1;
        }

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        double total_path = 0;

        double path = 10;

        for (; path < 20; answer++)
        {
            total_path += path;
            path *= 1.1;
        }

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

        for (; L > Math.Pow(10, -10); answer++)
            L /= 2;

        return answer;
    }
    public int Task_2_10()
    {
        int answer = 0;



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

        // code here

        // end

        return (S, y);
    }
    public (double, double) Task_3_9(double x)
    {
        double S = 0, y = 0;

        double element = 1;

        double top = x;

        y = Math.Atan(x);

        for (int i = 0; Math.Abs(element) >= 0.0001; i++)
        {
            if (i > 0)
                top *= x * x;
            if (i % 2 != 0)
                top = -top;
            element = top / ((2 * i) + 1);
            S += element;
        }

        return (S, y);
    }
    #endregion
}