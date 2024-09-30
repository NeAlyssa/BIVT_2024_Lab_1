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
        //program.Task_2_3(1, 1, 10);
        //program.Task_2_4(0.8);
        //program.Task_2_5(1, 0);
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
        program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;
        // code here
        for (int i = 2; i <= 35; i+=3)
        {
            answer = answer + i;
        }
        // end
        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (int i = 1; i <= 10; i++)
        {
            answer += 1.0 / i;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2; i <= 112; i+=2)
        {
            answer += i / (i + 1);

        }
        answer = Math.Round(answer, 0);
        // end
        
        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double x1 = 1;
        if (x == 0)
        {
            return 0;
        }
        else
        {
            for (double i = 0; i <= 8; i++)
            {
                answer += Math.Cos((i + 1) * x) / x1;
                x1 = x1 * x;
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
            answer += (p + i * h) * (p + i * h);
        }
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
        int part_ansver = 1;
        for (int j = 1; j <= 6; j++)
        {
            part_ansver *= j; 
            answer += part_ansver;   
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        
        double part_ansver = 1, five = 1, minus = 1;
        for (int j = 1; j <= 6; j++)
        {
            minus *= -1;
            five *= 5;
            part_ansver *= j;
            answer += minus * five / part_ansver;
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
        for (int i = 0; i < 7; i++)
        {
            answer *= 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        Console.WriteLine("1 2 3 4 5 6");
        Console.WriteLine("5 5 5 5 5 5");
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x == 0)
        {
            return 0;
        }
        else
        {
            double new_x = 1;
            for (int i = 1; i <= 11; i++)
            {
                answer += 1 / new_x;
                new_x *= x;
            }
            answer = Math.Round(answer, 2);


            // end

            return answer;
        }
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x >= -1.5 && x <= 1.5)
        {
            if (x <= -1)
            {
                return 1;
            }
            else if ( x > -1 && x <= 1)
            {
                return -x;
            }
            else if (x > 1)
            {
                return -1;
            }
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int one = 0, two = 1;
        Console.WriteLine(one + "\t");
        Console.WriteLine($"{two}\t", two);
        for (int i = 0; i < 6; i++)
        {   
            if (i % 2 == 0)
            {
                one = one + two;
                Console.WriteLine(one + "\t");
            }
            if (i % 2 == 1)
            {
                two = one + two;
                Console.WriteLine(two + "\t");
            }
            
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double one = 1, two = 2, one_2 = 1, two_2 = 1;
        
        for (int i = 0; i < 5; i++)
        {
            if (i % 2 == 0)
            {
                one = one + two;
                one_2 = one_2 + two_2;
            }
            if (i % 2 == 1)
            {
                two = one + two;
                two_2 = one_2 + two_2;
            }
        }
        answer = Math.Round(one_2 / two_2, 1);
        
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double dobavit = 1;
        double gramm = 1;
        for (int i = 1; i < 64; i++)
        {
            dobavit *= 2;
            gramm += dobavit;
        }
        power = (int)Math.Log10(gramm / 15);
        answer = Math.Round(gramm / 15 / Math.Pow(10, power), 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double r = 6350;
        answer = Math.Sqrt((r + x) * (r + x) - (r * r));
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        answer = 10;
        for (int i = 0; i < x /3; i++)
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
        double i = 1;
        while (Math.Abs(Math.Cos(i * x) / (i * i)) >= 0.0001)
        {
            answer += Math.Cos(i * x) / (i * i);
            i++;
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
        double summ = 0;
        // code here
        if (h < 0)
        {
            return answer;
        }
        else
        {
            while ((summ + a + (h * answer)) <= p)
            {
                summ += a + (h * answer);
                answer += 1;
            }
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
        if (M == 0)
        {
            return (quotient, remainder);
        }
        else
        {
            while (N >= M)
            {
                quotient += 1;
                N -= M;
            }
            remainder = N;
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
        answer = 10;
        double norm = 10;
        for (int i = 1; i < 7; i++)
        {
            norm = norm + norm / 100 * 10;
            answer += norm;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double norm = 10;
        double day = 10;
        answer = 1;
        while (day < 100)
        {
            norm = norm + norm / 100 * 10;
            day += norm;
            answer++;
        }
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double one_day = 10;
        answer = 1;
        while (one_day <= 20)
        {
            answer++;
            one_day = one_day + one_day / 100 * 10;
        }
        // end

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

        // code here;
        double nit = 0.1;
        double atom = Math.Pow(10, -10);
        while (nit > atom)
        {
            nit /= 2;
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
        int minus = 1;
        double one = x, two = 1;
        while (Math.Abs((minus * one) / two) >= 0.0001)
        { 
            S += minus * one / two; 
            minus *= -1;
            one = one * x * x;
            two += 2;
             
        }
        y = Math.Atan(x);
        // end

        return (S, y);
    }
    #endregion
}
