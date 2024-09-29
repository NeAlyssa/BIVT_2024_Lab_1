using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

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
        //program.Task_1_12(0.9);
        program.Task_1_13(-1.5);
        program.Task_1_14();
        program.Task_1_15();
        program.Task_1_16();
        program.Task_1_17(10);
        program.Task_1_18(24);
        program.Task_2_1(0);
        program.Task_2_2();
        //program.Task_2_3(8, 2, 0);
        program.Task_2_4(0.8);
        //program.Task_2_5(11, 5);
        program.Task_2_6();
        program.Task_2_7a();
        program.Task_2_7b();
        program.Task_2_7c();
        program.Task_2_8();
        //program.Task_2_9();
        program.Task_2_10();
        //program.Task_3_1(0.1);
        program.Task_3_2(0.1);
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
        for (int i = 1; i <= 10; i += 1)
        {
            answer += 1.0 / i; 
        /* я использовал 1.0 / i, чтобы убедиться, что деление выполняется в арифметике с плавающей запятой,
         * что необходимо для получения точного результата. */
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (int i = 2; i <= 112; i+=2)
        {
            answer += ((double)i / (i + 1));
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double xs = 1;
        if (x != 0)
        {
            for (int i = 1; i <= 9; i++)
            {
                answer += Math.Cos(i * x) / xs;
                xs *= x;
            }
        }
        else
        {
            answer = 0;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i = 1; i <= 10; i++)
        {
            answer += (p + (h * (i - 1))) * (p + (h * (i - 1)));
        }
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = Math.Round(x*x * 0.5 - 7 * x, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int factorial = 1;
        for (int i = 1; i <= 6; i++)
        {
            factorial *= i;
        }
        answer = factorial;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int factorial = 1;
        for (int i = 1; i <= 6; i++)
        {
            factorial *= i;
            answer += factorial;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        int factorial = 1;
        int five = 5;
        double minus = -1;
        for (int i = 1; i <= 6; i++)
        {
            factorial *= i;
            answer += minus * five / factorial;
            five *= 5;
            minus *= -1;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int num1 = 3;
        answer = num1;
        for (int i = 1; i < 7; i++)
        {
            answer *= num1;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task

        for (int i = 0; i < 6; i++)
        {
            Console.Write(i + 1 + " ");
        }
        
        Console.WriteLine();

        for (int j = 0; j < 6; j++)
        {
            Console.Write(5 + " ");
        }
        
        Console.WriteLine();
        // code here

    }

    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x != 0)
        {
            answer += 1;
            double xs = x;
            for (int i = 1; i <= 10; i++)
            {
                answer += 1 /xs;
                xs *= x;
            }
        }
        else 
            answer = 0;
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
        if (x > -1 && x <= 1)
            answer = -x;
        if (x > 1)
            answer = -1;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int[] fibonacci = new int[6];
        fibonacci[0] = 1;
        fibonacci[1] = 1;
        for (int i = 2; i < 6; i++)
        {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }
        for (int i = 0; i < 6; i++)
        {
            Console.Write(fibonacci[i] + " ");
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double numerator1 = 1;
        double denominator1 = 1;
        double numerator2 = 2;
        double denominator2 = 1;

        for (int i = 0; i < 3; i++)
        {
            double numeratorNext = numerator1 + numerator2;
            double denominatorNext = denominator1 + denominator2;

            answer = numeratorNext / denominatorNext;

            numerator1 = numerator2;
            denominator1 = denominator2;
            numerator2 = numeratorNext;
            denominator2 = denominatorNext;
        }
        // end

        return answer;
    }
    /// <summary>
    /// Задача про шахматы и рис
    /// </summary>
    /// <returns></returns>
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        //code here
        double multiplier = 1;
        for (int i = 0; i < 64; i++)
        {
            answer += multiplier;
            multiplier *= 2;
        }
        answer /= 15;
        power = (int)Math.Floor(Math.Log10(answer));
        double divisor = 1;
        for (int i = 0; i < power; i++)
        {
            divisor *= 10;
        }
        answer = Math.Round(answer / divisor, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double R = 6350;
        answer = Math.Round(Math.Sqrt(x * x + 2 * R * x), 2); 
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int div = x / 3;
        int multiplier = 1;
        for (int i = 0; i < div; i++)
        {
            multiplier *= 2;
        }
        answer = multiplier * 10;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here
        /*double res = 1;
        for (int i = 1; Math.Abs(res) > 0.0001; i++)
        {  
            res = Math.Cos(x*i)/Math.Pow(i,2);
            answer += res;
        }
        answer = Math.Round(answer, 2);*/
        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 0;
        int res = 1;
        // code here
        for (int i = 1; res <= 30000; i += 3)
        {
            res *= i; 
            answer = i - 3;
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
        if (-1 < x && x < 1)
        {
            double term = 1;
            int i = 0;
            while (term >= 0.0001)
            {
                answer += term;
                term *= x * x; 
                i++;
            }
            answer = Math.Round(answer, 2);
        }
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
        int res = 10;
        int i = 1;
        while (res < 100000)
        {
            res *= 2;
            answer = i*3;
            i++;
            
        }
        // end

        return answer;
    }
    public double Task_2_7a()
    {
        double answer = 0;
        
        // code here
        double daily_way = 10;
        for (int i = 1; i <=7; i++)
        {
            answer += daily_way;
            daily_way *= 1.1;        
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double daily_way = 10;
        double s = 0;
        for (int i = 1;s < 100; i++)
        {
            s += daily_way;
            daily_way *= 1.1;
            answer = i;
        }
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double daily_way = 10;
        int i = 0;
        while (daily_way <= 20)
        {
            daily_way *= 1.1;
            i++;
        }
        answer = i;
        // end

        return answer;
    }
    public int Task_2_8()
    {
        int answer = 0;

        // code here;
        double sum = 10000;

        while (sum <= 20000)
        {
            sum *= 1.08; ++answer;
        }
        // end

        return answer;
    }
    public int Task_2_9()
    {
        int answer = 0;

        // code here;
        double Da = 10E-10;
        double lenght = 1;
        while (lenght >= Da)
        {
            lenght /= 2;
            answer++;
        }
        // end

        return answer;
    }
    public int Task_2_10()
    {
        int answer = 0;

        // code here;
        int numerator1 = 1;
        int denominator1 = 1;
        int numerator2 = 2;
        int denominator2 = 1;

        double previousValue = 1.0;
        int termNumber = 3;

        while (true)
        {
            int numeratorNext = numerator1 + numerator2;
            int denominatorNext = denominator1 + denominator2;

            double currentValue = (double)numeratorNext / denominatorNext;

            if (Math.Abs(currentValue - previousValue) < 0.001)
            {
                answer = termNumber;
                break;
            }

            previousValue = currentValue;
            numerator1 = numerator2;
            denominator1 = denominator2;
            numerator2 = numeratorNext;
            denominator2 = denominatorNext;
            termNumber++;
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
        double num1 = x;
        int i = 1;
        double num2 = Math.Sin(Math.PI * i / 4);
        while (num1 >= 0.0001)
        {
            S += num1 * num2;
            num1 *= x;
            i++;
            num2 = Math.Sin(Math.PI * i / 4);
        }
        y = x * Math.Sin(Math.PI / 4) / (1 - 2 * x * Math.Cos(Math.PI / 4) + x * x);
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
