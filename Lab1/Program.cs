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
        for (double i = 1; i <= 10; i++)
        {
            answer += (1.0 / i);
        }

        answer = Math.Round(answer, 2);

        Console.WriteLine(answer);
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
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double neww = 1;
        if (x == 0)
        {
            return 0;
        }
        for (int i = 1; i <= 9; i++)
        {
            answer += Math.Cos(x * i) / neww;
            neww *= x;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (double i = 0; i <= 9; i++)
        {
            answer += (p + h * i) * (p + h * i);
        }

        answer = Math.Round(answer, 2);

        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;
        double y = 0;
        // code here
        y = 0.5 * x * x - 7 * x;
        answer = Math.Round(y, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for (int i = 1; i <= 6; i++)
        {
            answer *= i;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        for (int i = 1; i <= 6; i++)
        {
            int dopoln = 1;
            for (int j = 1; j <= i; j++)
            {
                dopoln *= j;
            }
            answer += dopoln;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double minus_one = 1;
        double five = 1;
        for (double i = 1; i <= 6; i++)
        {
            minus_one *= -1;
            five *= 5;
            double factorial = 1;
            for (double j = 1; j <= i; j++)
            {
                factorial *= j;
            }
            answer += minus_one * five / factorial;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        for (int i = 0; i <= 6; i++)
        {
            answer *= 3;
        }

        Console.WriteLine(answer);
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
        double new_x = 1;
        if (x == 0)
        {
            return answer;
        }
        else
        {
            for (double i = 0; i <= 10; i++)
            {
                answer += 1 / new_x;

                new_x *= x;
            }
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
        {
            answer = 1;
        }
        else if (x > 1)
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
        double dop = 0;
        double first = 1;
        double second = 1;

        Console.WriteLine(first);
        Console.WriteLine(second);

        for (int i = 0; i <= 5; i++)
        {
            dop = first;
            first = second;
            second = second + dop;
            Console.WriteLine(second);
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double ch1 = 1;
        double zn1 = 1;
        double ch2 = 2;
        double zn2 = 1;
        double dop_ch = 0;
        double dop_zn = 0;

        for (int i = 0; i <= 2; i++)
        {
            answer = (ch1 + ch2) / (zn1 + zn2);

            dop_ch = ch1 + ch2;
            ch1 = ch2;
            ch2 = dop_ch;

            dop_zn = zn1 + zn2;
            zn1 = zn2;
            zn2 = dop_zn;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        double last = 2;
        int power = 0;
        for (int i = 1; i < 64; i++)
        {
            answer += last;
            Console.WriteLine(answer);
            last = 2 * last;
        }
        answer = answer / 15;
        while (answer > 10)
        {
            power += 1;
            answer = answer / 10;
        }
        answer = Math.Round(answer, 2);

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double radius = 6350;
        answer = Math.Sqrt(((radius + x) * (radius + x)) - (radius * radius));
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here
        int y = x / 3;
        for (int i = 0; i < y; i++)
        {
            answer = answer * 2;
        }
        Console.WriteLine(answer);
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
        int answer = 1;

        // code here
        int p = 1;

        while (p <= 30000)
        {
            answer += 3;
            p *= answer;
        }
        answer -= 3;
        Console.WriteLine(answer);
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
        double answer = 1;

        // code here
        double ch = 1;
        if (x == 1)
        {
            answer = 0;
        }
        else
        {
            while (ch >= 0.0001)
            {
                ch *= x;
                ch *= x;
                answer += ch;
            }
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
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
        double cell_one = 10;
        double cell_two = 100000;
        int hours = 0;

        while (cell_two > cell_one)
        {
            cell_two /= 2;
            hours += 3;
        }
        answer = hours;
        Console.WriteLine(answer);
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
        double start = 10000;
        double finish = 20000;

        while (start <= finish)
        {
            start *= 1.08;
            answer += 1;
        }

        Console.WriteLine(answer);
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
        int answer = 2;

        // code here;
        double ch1 = 1;
        double zn1 = 1;
        double ch2 = 2;
        double zn2 = 1;
        double dop_for_ch2 = 0;
        double dop_for_zn2 = 0;
        

        do
        {
            dop_for_ch2 = ch2;
            dop_for_zn2 = zn2;

            ch2 = ch1 + dop_for_ch2;
            ch1 = dop_for_ch2;

            zn2 = zn1 + dop_for_zn2;
            zn1 = dop_for_zn2;
            answer += 1;
        } while (Math.Abs((ch2 / zn2) - (ch1 / zn1)) > 0.001);
        
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
        double zn = 1;
        double ch = 1;
        double a = 0;
        
        for(int i = 0; ;i ++)
        {
            a = ch / zn;
            if(Math.Abs(a) < 0.0001)
            {
                break;
            }
            S += a;
            zn *= (2 * i + 1);
            zn *= (2 * i + 2);
            ch *= x;
            ch *= x;
        }

        y = (Math.Exp(x) + Math.Exp(-x)) / 2;
      

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


