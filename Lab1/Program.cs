using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
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
        program.Task_1_17(10);
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
        for (int i = 2; i < 36; i += 3)
        {
            answer += i;
        }

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        for (double i = 1.0; i < 11.0; i ++)
        {
            answer += (1.0 / i);
        }

        return Math.Round(answer, 2);
    }
    public double Task_1_3()
    {
        double answer = 0;
        double b = 3;
        for (double a = 2; a < 113; a+= 2)
        {
            answer += (a / b);
            b+= 2;
        }
        Console.WriteLine(Math.Round(answer, 2));
        return Math.Round(answer, 2);
    }
    public double Task_1_4(double x)
    {
        double answer = Math.Cos(x);
        double a = x;
        for (int i = 2; i < 10; i++)
        {
            
            answer += ((double)(Math.Cos(x * i)) / (double)(a));
            a *= x;
        }

        Console.WriteLine(Math.Round(answer, 5));
        return Math.Round(answer, 2);
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        for (int i = 0; i < 10; i++)
        {
            answer += (p + i * h) * (p + i * h);
        }

        return answer;
    }
    public double Task_1_6(double x)
    {

        return Math.Round(0.5 * x * x - 7 * x, 2);
    }
    public int Task_1_7()
    {
        int answer = 1;

        for (int i = 1; i < 7; i++)
        {
            answer *= i;
        }

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 1;
        int answer2 = 0;

        for (int i = 1; i < 7; i++)
        {
            answer *= i;
            answer2 += answer;
        }

        return answer2;
    }
    public double Task_1_9()
    {
        double answer = 0;
        double answer2 = 0;
        double a = 5;
        double a1 = -1;
        double a2 = 1;
        for (int i = 2; i < 8; i++)
        {
            answer += ((a1 * a) / a2);
            a *= 5;
            a1 *= -1;
            a2 *= i;
        }

        return Math.Round(answer, 2);
    }
    public int Task_1_10()
    {
        int answer = 1;

        for (int i = 1; i < 8; i++)
        {
            answer *= 3;
        }

        return answer;
    }
    public void Task_1_11()
    {
        for (int i = 1; i < 7; i++)
        {
            Console.Write(i);
            Console.Write(' ');
        }
    }
    public double Task_1_12(double x)
    {
        double answer = 0;
        double quest = x;
        for (int i = 1; i < 11; i++)
        {
            answer += (1 / quest);
            quest *= x;
        }
        return Math.Round(answer + 1,2);
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        if (x <= -1)
        {
            return 1;
        }
        if (x <= 1 & x > -1)
        {
            return -x;
        }
        else
        {
            return -1;
        }

    }
    public void Task_1_14()
    {
        int[] arr = new int[8];
        arr[0] = arr[1] = 0;
        for (int i = 2; i < 9; i++)
        {
            arr[i] = arr[i - 1] + arr[i - 2];
        }
        for (int j = 0; j < arr.Length; j++)
        {
            Console.Write(arr[j]);
            Console.Write(' ');
        }
    }
    public double Task_1_15()
    {
        double answer = 0;

        int[] arr = new int[6];
        int[] arr1 = new int[6];
        arr[0] = arr1[0] = 1;
        arr[1] = 2;
        arr1[1] = 1;
        for (int i = 2; i < 6; i++)
        {
            arr[i] = arr[i - 1] + arr[i - 2];
            arr1[i] = arr1[i - 1] + arr1[i - 2];
        }

        return Math.Round((double)((double)arr[4] / arr1[4]),2); 
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;
        double zer = 2;
        double pow = 2;
        for (int i = 2; i < 64; i++)
        {
            pow *= 2;
            zer += pow;
        }
        zer /= 15;
        while (zer >= 10)
        {
            power++;
            zer /= 10;
        }
        answer = Math.Round(zer, 2);

        return (answer, power);

    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        answer = Math.Sqrt(((6350 + x) * (6350 + x)) - (6350 * 6350));
        Console.WriteLine(answer);
        return Math.Round(answer, 2);
    }
    public int Task_1_18(int x)
    {
        int answer = 0;
        int constt = 10;
        for (int i = 1; i < (x / 3) + 1; i++)
        {
            constt *= 2;
        }

        return constt;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        return x;
    }
    public int Task_2_2()
    {
        double answer = 0;
        int summ = 1;
        for (int i = 1; i < 100; i += 3)
        {
            summ *= i;
            if (summ > 30000)
            {
                return i - 3;
            }
        }
        return 0;
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
        double summ = 1;
        double maxx = 1; 
        for (int i = 0; i < 100; i+= 2)
        {
            maxx *= x * x;
            if (maxx >= 0.0001)
            {
                summ += maxx;
            }
            else
            {
                return Math.Round(summ, 2);
            }
        }

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
        int countt = 10;
        int summ = 0; 
        for (int i = 3; i < 10000; i += 3)
        {
            countt *= 2;
            if (countt >= 100000)
            {
                return i;
            }
            else
            {
                continue;
            }
        }

        return 0;
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

        double constt = 10000;
        for (int i = 1; i < 50; i++)
        {
            constt *= 1.08;
            if (constt >= 20000){
                return i;
            }
            else
            {
                continue;
            }
        }

        return 0;
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
        double answer = 0;

        double[] arr = new double[100];
        double[] arr1 = new double[100];
        arr[0] = arr1[0] = 1;
        arr[1] = 2;
        arr1[1] = 1;
        for (int i = 2; i < arr.Length; i++)
        {
            arr[i] = arr[i - 1] + arr[i - 2];
            arr1[i] = arr1[i - 1] + arr1[i - 2];
            if (Math.Abs((double)(arr[i] / arr1[i]) - (double)(arr[i - 1] / arr1[i - 1])) <= 0.0001)
            {
                return i - 1;
            }
        }
        
        return 0;
    }
    #endregion

    #region Level 3
    public (double, double) Task_3_1(double x)
    {
        double s = 0.0;
        double term;
        int i = 0;
        double epsilon = 0.0001;  
        do
        {
            term = Math.Pow(-1, i) * Math.Pow(x, 2 * i) / Factorial(2 * i);
            s += term;
            i++;
        } while (Math.Abs(term) >= epsilon);

        double y = Math.Cos(x); 
        return (s, y);
    }
    static double Factorial(int n)
    {
        double result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
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
