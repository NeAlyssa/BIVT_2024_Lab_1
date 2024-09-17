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
        program.Task_3_7(0.1);
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

        for (double i = 1; i <= 10; i++)
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
            answer += i / (i + 1);
        }

        return Math.Round(answer);
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        if (x == 0) return 0;

        for (int i = 0; i <= 8; i++)
        {
            answer += Math.Cos((i + 1) * x) / Math.Pow(x, i);
        }

        return Math.Round(answer, 2);
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        for (int i = 0; i <= 9; i++)
        {
            answer += Math.Pow((p + i * h), 2);
        }

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        answer = 0.5 * Math.Pow(x, 2) - 7 * x;

        return Math.Round(answer, 2);
    }
    public int Task_1_7()
    {
        int answer = 1;

        for (int i = 1; i <= 6; i++)
        {
            answer *= i;
        }

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        for (int i = 1; i <= 6; i++)
        {
            int temp = 1;

            for (int j = 1; j <= i; j++)
            {
                temp *= j;
            }

            answer += temp;
        }

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        for (int i = 1; i <= 6; i++)
        {
            int fact = 1;
            for (int j = 1; j <= i; j++)
            {
                fact *= j;
            }
            
            answer += Math.Pow(-1, i) * Math.Pow(5, i) / fact;
        }

        return Math.Round(answer, 2);
    }
    public int Task_1_10()
    {
        int answer = 1;

        for (int i = 0; i < 7; i++)
        {
            answer *= 3;
        }

        return answer;
    }
    public void Task_1_11()
    {
        for (int i = 1; i <= 6; i++)
        {
            Console.Write($"{i} ");
        }
    
        Console.WriteLine();
        
        for (int i = 0; i < 6; i++)
        {
            Console.Write("5 ");
        }
    }
    public double Task_1_12(double x)
    {
        double answer = 0;
        
        if (x == 0) return 0;

        for (int i = 0; i <= 10; i++)
        {
            answer += 1 / Math.Pow(x, i);
        }

        return Math.Round(answer, 2);
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        if (x <= -1) answer = 1;
        else if (-1 <= x && x <= 1) answer = -x;
        if (x > 1) answer = -1;

        return answer;
    }
    public void Task_1_14()
    {
        int i0 = 1, i1 = 1;
        
        Console.WriteLine(i0);
        Console.WriteLine(i1);

        for (int i = 0; i < 6; i++)
        {
            int temp = i0 + i1;

            i0 = i1;
            i1 = temp;
            
            Console.WriteLine(temp);
        }
    }
    public double Task_1_15()
    {
        double answer = 0;

        int first0 = 1, second0 = 1, first1 = 2, second1 = 1;
        for (int i = 0; i < 3; i++)
        {
            int firstTemp = first0 + first1,
                secondTemp = second0 + second1;

            first0 = first1;
            second0 = second1;
            
            first1 = firstTemp;
            second1 = secondTemp;
        }

        answer = (double)first1 / (double)second1;

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        for (int i = 0; i < 64; i++)
        {
            answer += Math.Pow(2, i);
        }
        answer /= 15;

        power = (int)Math.Log10(answer);
        answer = answer / Math.Pow(10, power);
        
        return (Math.Round(answer, 2), power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        int R = 6350;

        answer = Math.Pow((Math.Pow(R + x, 2) - Math.Pow(R, 2)), 0.5);

        return Math.Round(answer, 2);
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        for (int i = 0; i < (int)(x / 3); i++)
        {
            answer *= 2;
        }

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;
        double next = 0;
        double n = 1;

        do
        {
            answer += next;
            next = Math.Cos(n * x) / Math.Pow(n, 2);
            n++;
        } while (Math.Abs(next) >= 1e-4);
        
        return Math.Round(answer, 2);
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
        if ((a + h) * p < 0) return 0;  // if (a + h) and p are not of the same sign
        
        int answer = 0;
        double sum = 0;

        do
        {
            sum += a + answer * h;
            answer++;
        } while (sum <= p);
        
        return answer - 1;
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
        if (M == 0) return (0, 0);

        if (N < 0 && M < 0)
        {
            N = -N;
            M = -M;
        }
        
        int quotient = 0, remainder = 0;

        while (N >= 0)
        {
            quotient++;
            N -= M;
        }
        
        remainder = N + M;

        return (quotient - 1, remainder);
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
        double answer = 10, current = 10;

        for (int i = 0; i < 6; i++)
        {
            current *= 1.1;
            answer += current;
        }

        return Math.Round(answer, 2);
    }
    public int Task_2_7b()
    {
        int answer = 1;
        double current = 10, sum = 10;

        while (sum < 100)
        {
            current *= 1.1;
            sum += current;
            answer++;
        }

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 1;
        double current = 10, sum = 10;

        while (current < 20)
        {
            current *= 1.1;
            sum += current;
            answer++;
        }
        
        return answer - 1;
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

        while (l > 1e-10)
        {
            l /= 2;
            answer++;
        }
        
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
        double S = 0, y = 0, next = 0;
        int i = 0;

        do
        {
            S += next;

            int fact = 1;
            for (int j = 1; j <= 2 * i; j++)
            {
                fact *= j;
            }
            next = Math.Pow(x, 2 * i) / fact;
            
            i++;
        } while (Math.Abs(next) >= 1e-4);

        y = (Math.Pow(Math.E, x) + Math.Pow(Math.E, -x)) / 2;
        
        S = (double)(Math.Round((decimal)S * 100, MidpointRounding.AwayFromZero) / 100);  // for correct rounding (otherwise in the first test 1.005 is rounded to 1.00, not to 1.01)
        
        return (S, Math.Round(y, 2));
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