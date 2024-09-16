using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.IO.Pipes;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

        // program.Task_1_1();
        // program.Task_1_2();
        // program.Task_1_3();
        // program.Task_1_4(0.9);
        // program.Task_1_5(0, 2);
        // program.Task_1_6(4);
        // program.Task_1_7();
        // program.Task_1_8();
        // program.Task_1_9();
        // program.Task_1_10();
        // program.Task_1_11();
        // program.Task_1_12(0.9);
        // program.Task_1_13(-1.5);
        // program.Task_1_14();
        // program.Task_1_15();
        // program.Task_1_16();
        // program.Task_1_17(10);
        // program.Task_1_18(24);
        //program.Task_2_1(0);
        // program.Task_2_2();
        //program.Task_2_3(8, 2, 0);
        // program.Task_2_4(0.8);
        //program.Task_2_5(11, 5);
        // program.Task_2_6();
        //program.Task_2_7a();
        //program.Task_2_7b();
        //program.Task_2_7c();
        // program.Task_2_8();
        //program.Task_2_9();
        program.Task_2_10();
        //program.Task_3_1(0.1);
        //program.Task_3_2(0.1);
        //program.Task_3_3(0.1);
        //program.Task_3_4(0.1);
        //program.Task_3_5(double.Pi/5);
        // program.Task_3_6(0.1);
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
        for(double n = 2; n <= 112; n += 2)
        {
            answer += n / (n + 1);
        }
        // end
        answer = Math.Round(answer, 2);
        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        if (x == 0)
        {
            return 0;
        }
        // code here
        for(int p = 0; p <= 8; p++)
        {
            answer += Math.Cos((p + 1) * x) / Math.Pow(x, p);
        }
        // end
        answer = Math.Round(answer, 2);
        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for(int n = 0; n < 10; n++)
        {
            answer += Math.Pow(p + n * h, 2);
        }
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * x * x - 7 * x;
        // end
        answer = Math.Round(answer, 2);
        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        answer = 1;
        for(int i = 1; i <= 6; i++)
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
        for(int a = 1; a <= 6; a++)
        {
            int f = 1;
            for(int b = 1; b <= a; b++)
            {
                f *= b;
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
        for(int i = 1; i <= 6; i++)
        {
            int f = 1;
            for(int b = 1; b <= i; b++)
            {
                f *= b;
            }
            answer += Math.Pow(-1, i) * Math.Pow(5, i) / f;
        }
        // end
        answer = Math.Round(answer, 2);
        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        answer = 1;
        for(int i = 0; i < 7; i++)
        {
            answer *= 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        Console.Write("а)");
        for(int i = 1; i <= 6; i++)
        {
            Console.Write($" {i}");
        }
        Console.WriteLine(".");
        Console.Write("б)");
        for(int i = 0; i < 6; i++)
        {
            Console.Write($" 5");
        }
        Console.WriteLine(".");
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if(x == 0)
        {
            return 0;
        }
        for(int p = 0; p <= 10; p++)
        {
            answer += 1 / Math.Pow(x, p);
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if(x <= -1)
        {
            answer = 1;
        } 
        else if(x > 1)
        {
            answer = -1;
        } 
        else
        {
            answer = -x;
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int n1 = 0;
        int n2 = 1;
        int temp;
        for(int i = 0; i < 8; i++)
        {
            Console.WriteLine(n2);
            temp = n2;
            n2 += n1;
            n1 = temp;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double n1 = 1;
        double d1 = 1;
        double n2 = 2;
        double d2 = 1;
        double temp;
        for(int i = 0; i < 5; i++)
        {
            temp = n2;
            n2 += n1;
            n1 = temp;

            temp = d2;
            d2 += d1;
            d1 = temp;
        }
        answer = n1 / d1;
        answer = Math.Round(answer, 1);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;
        double amount = 0;
        double mass;
        // code here
        for(int i = 0; i < 64; i++)
        {
            amount += Math.Pow(2, i);
        }
        mass = amount / 15;
        power = (int)Math.Log10(mass);
        answer = Math.Round(mass / Math.Pow(10, power), 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        const double r = 6350.0;
        // code here
        answer = Math.Sqrt(Math.Pow(x + r, 2) - Math.Pow(r, 2));
        // end
        answer = Math.Round(answer, 2);
        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here
        for(int i = 0; i < x; i+=3)
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
        double last;
        const double epsilon = 0.0001;
        int counter = 1;
        // code here
        do
        {
            last = Math.Cos(counter * x) / Math.Pow(counter, 2);
            counter++;
            answer += last;
        }
        while (last >= epsilon);
        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 1;
        const int L = 30000;
        int product = 1;
        for (; product <= L; product *= answer)
        {
            answer += 3;
        }
        // end

        return answer - 3;
    }
    public int Task_2_3(double a, double h, double p)
    {
        int answer = 0;

        // code here

        // end

        return answer-2;
    }
    public double Task_2_4(double x)
    {
        double answer = 1;
        const double epsilon = 0.0001;
        int power = 2;
        double last;
        if (x == 1)
        {
            return 0;
        }
        // code here
        do
        {
            last = Math.Pow(x, power);
            answer += last;
            power += 2;
        }
        while (last >= epsilon);
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
        for(int i = 0; i < 7; i++)
        {
            answer += 10 * Math.Pow(1.1, i);
        }
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;
        double total = 0;
        const double target = 100;
        // code here
        while(total < target)
        {
            total += 10 * Math.Pow(1.1, answer);
            answer += 1;
        }
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;
        double last = 10;
        const double target = 20;
        // code here
        while (last < target)
        {
            last *= 1.1;
            answer += 1;
        }
        // end

        return answer;
    }
    public int Task_2_8()
    {
        int answer = 0;
        const double k = 1.08;
        double currentAmount = 10000;
        double targetAmount = currentAmount * 2;
        // code here;
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
        double l = 0.1;
        double D_A = Math.Pow(10, -10);
        // code here;
        while (l > D_A)
        {
            answer += 1;
            l /= 2;
        }
        // end

        return answer;
    }
    public int Task_2_10()
    {
        int answer = 2;
        // code here;
        double n1 = 1;
        double d1 = 1;
        double n2 = 2;
        double d2 = 1;
        double temp;
        const double diff = 0.001;
        while (Math.Abs(n2/d2 - n1/d1) > diff)
        {
            answer++;
            Console.WriteLine($"{n1/d1} {n2/d2}");
            n1 += n2;
            d1 += d2;

            temp = n1;
            n1 = n2;
            n2 = temp;

            temp = d1;
            d1 = d2;
            d2 = temp;
        }
        // end

        return answer;
    }
    #endregion

    #region Level 3
    public (double, double) Task_3_1(double x)
    {
        double S = 0, y = 0;
        
        // end

        return (S, y);
    }
    public (double, double) Task_3_2(double x)
    {
        double S = 0, y = 0;

        return (S, y);
    }
    public (double, double) Task_3_3(double x)
    {
        double S = 1, y = 0;
        
        // end

        return (S, y);
    }
    public (double, double) Task_3_4(double x)
    {
        double S = 1, y = 0;

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
        const double e = 0.0001;
        double last = 1;
        double i = 1;
        // code here
        while (Math.Abs(last) >= e)
        {

            last = Math.Pow(-1, i + 1) * Math.Pow(x, 2 * i + 1) / ( 4 * Math.Pow(i, 2) - 1);
            S += last;
            i += 1;
        }
        y = ((1 + Math.Pow(x, 2)) * Math.Atan(x)) / 2 - x / 2;
        // end

        return (Math.Round(S, 2), Math.Round(y, 2));
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