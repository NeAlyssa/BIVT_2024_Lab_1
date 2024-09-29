using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
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

        for (int i = 2; i <= 35; i += 3)
        {
            answer += i;
        }

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 1;

        for (double i = 2; i < 11; i++ )
        {
            answer += 1 / i;
        }

        answer = Math.Round(answer, 2);

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        for (double i = 2; i <= 112; i += 2)
        {
            answer += i / (i + 1);
        }

        answer = Math.Round(answer, 2);

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0, n1 = 1;

        if (x != 0)
        //знаменатель != 0
        {
            for (int i = 1; i < 10; i++)
            {
                answer += Math.Cos(i * x) / n1;
                n1 *= x;
            }
        }
        answer = Math.Round(answer, 2);
        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        for(double i = 0; i < 10; i++ )
        {
            answer += (p + i * h) * (p + i * h);
        }

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0.5 * x * x - 7 * x;

        answer = Math.Round(answer, 2);

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        for(int i = 2; i < 7; i++)
        {
            answer *= i;
        }
        return answer;
    }
    public int Task_1_8()
    {
        int answer = 1, part = 1;

        for (int i = 2; i < 7; i++)
        {
            part *= i;
            answer += part;
        }

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0, n3 = 1, part;
        int n1 = 1, n2 = 1;

        for(int i = 1; i < 7; i++)
        {
            n1 *= -1;
            n2 *= 5;
            n3 *= i;
            part = n1 * n2 / n3;
            answer += part;
        }

        answer = Math.Round(answer, 2);

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;

        for(int i = 1; i < 8; i++)
        {
            answer *= 3;
        }

        return answer;
    }
    public void Task_1_11()
    {
        Console.WriteLine("1 2 3 4 5 6");

        Console.WriteLine("5 5 5 5 5 5");
    }
    public double Task_1_12(double x)
    {
        double answer = 0, part = 1;

        if (x != 0) {
        //знаменатель != 0
            answer = 1;
            for (int i = 1; i < 11; i++)
            {
                part *= x;
                answer += 1 / part;
            }

            answer = Math.Round(answer, 2);
        }
        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        if (x <= -1) answer = 1;
        if (x > -1 && x <= 1) answer = -x;
        if (x > 1) answer = -1;

        return answer;
    }
    public void Task_1_14()
    {
        int n1 = 1, n2 = 1, n3 = 1;

        for (int i = 1; i < 9; i++)
        {
            if (i < 3) Console.Write(n1 + " ");
            else
            {
                n1 = n3;
                n3 = n1 + n2;
                n2 = n1;

                Console.Write(n3 + " ");
            }
        }

    }
    public double Task_1_15()
    {
        double answer = 0, n0 = 2, n1 = 1, save;

        for(int i = 3; i < 6; i++)
        {
            save = n0;
            n0 += n1;
            n1 = save;
        }

        answer = n0 / n1;

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0, member = 1, counter = 1;
        int power = 0;

        for (int i = 1; i <= 64; i++)
        {
            if (answer > counter * 10)
            {
                counter *= 10;
                power++;
            }

            if (i != 1) member *= 2;
            answer += member;

        }             
        answer /= counter * 15;

        answer = Math.Round(answer, 2);
        
        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer, r = 6350;

        answer = Math.Sqrt(2 * r * x + x * x);
        
        answer = Math.Round(answer, 2);
   
        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10, hours;

        hours = x / 3;

        for (int i = 1; i <= hours; i++)
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

        // code here

        // end

        return answer;
    }

    public int Task_2_2()
    {
        const int L = 30000;
        int p = 1, answer = 1;

        while(p <= L)
        {
            answer += 3;
            p *= answer;
        }

        answer -= 3;

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
        const double e = 0.0001;
        double answer = 0, part = x * x;

        if(Math.Abs(x) < 1)
        {
            answer = 1;

            while (Math.Abs(part) >= e)
            {
                answer += part;

                part *= x * x;
            }

            answer = Math.Round((double)answer, 2);
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
        int answer = 0, start = 10, end = 100000;

        while (start <= end)
        {
            end /= 2;
            answer += 3;
        }

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
        double S = 10000, r = 1.08, S2 = 2 * S;
 
        do
        {
            S *= r;
            answer++;

        }while(S < S2);

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
        double n0 = 2, n1 = 1, former = 1, save, present = 2;

        do
        {
            former = present;
            save = n0;
            n0 += n1;
            n1 = save;
            present = n0 / n1;
            answer++;

        } while (Math.Abs(former - present) > 0.001);

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
        double S = 0, y = 0, part = 0, n0 = 1, n1;
        int counter = 1;

        do
        {
            n0 *= x;
            n1 = Math.Sin(counter * Math.PI / 4);
            part = n0 * n1;
            if (Math.Abs(n0) >= 0.0001) S += part;
            else break;
            counter++;

        } while(true);

        y = (x * Math.Sin(Math.PI / 4)) / (1 - 2 * x * Math.Cos(Math.PI / 4) + x * x);
        
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
        double S = 0, y = 0, n0, n1 = 1, n2 = 1, part, counter = 0;

        do
        {
            n0 = 2 * counter + 1;
            if (counter != 0)
            {
                n1 *= x * x;
                n2 *= counter;
            }
            part = n0 * n1 / n2;
            if (Math.Abs(part) >= 0.0001) S += part;
            else break;
            counter++;

        } while (true);

        y = (1 + 2 * x * x) * Math.Exp(x * x);

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
    {   double S = 0, y = 0, n0 = 1, n1 = x * x *x, n2, part;
        int counter = 1;

        do
        {
            if (counter != 1)
            {
                n0 *= -1;
                n1 *= x * x;
            }
            n2 = 4 * counter * counter - 1;
            part = n0 * n1 / n2;
            if (Math.Abs(part) >= 0.0001) S += part;
            else break;
            counter++;

        } while (true);

        y = (1 + x * x) * Math.Atan(x) / 2 - x / 2;

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
        double S = 0, y = 0, n0 = 1, n1 = 1, part;
        int counter = 0;

        do
        {
            if(counter != 0)
            {
                n0 *= 2 * x;
                n1 *= counter;
            }
            part = n0 / n1;
            if (Math.Abs(part) >= 0.0001) S += part;
            else break;
            counter++;

        } while (true);

        y = Math.Exp(2 * x);

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