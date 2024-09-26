using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        Console.WriteLine("Hello World!");
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
        program.Task_2_5(11, 5);
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
        {
            int i, s = 0;
            for (i = 2; i <= 35; i += 3)
                s = s + i;
            answer = s;
        }
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        {
            double s = 0.0;
            int i = 1;
            for (i = 1; i < 11; i++)
                s += (double) 1 / i;
            answer = s;
        }

        // end

        return Math.Round(answer,2);
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        {
            int i = 2;
            double s = 0;
            for (i = 2; i <= 112; i+=2)
                s += (double) i / (i + 1);
            answer = s;
        }
        // end

        return Math.Round(answer, 2);
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        {
            if (x == 0)
            {
                return 0;
            }
            for (int mn = 2; mn < 10; mn++)
            {
                double zn = 1;
                for (int j = 1;j < mn;j++)
                    zn *= x;
                    answer += Math.Cos(mn * x) / zn;
            }
        }   

        // end

        return Math.Round((Math.Cos(x) + answer),2);
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        
        {
            for (int mn = 0; mn < 10; mn++)
                answer += (p + mn * h) * (p + mn * h);
        }
        
        // end

        return Math.Round(answer,2);
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        {
            answer = Math.Round(0.5 * x * x - 7 * x,2);
        }
        // end

        return answer;

    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        {
            answer = 1;
            for (int i = 1; i < 7; i += 1)
                answer *= i;
        }

        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        {
            for (int i = 1, f=1; i < 7; i += 1)
            {
                f *= i;
                answer += f;
            }
        }

        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        {
            double ch1=1, ch2=1;
            double fac = 1;
            for (double i = 1; i < 7; i += 1)
            {
                fac *= i;
                ch1 *= -1;
                ch2 *= 5;
                answer += ch1 * ch2 / fac;
            }
        }

        // end

        return Math.Round(answer,2);
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        {
            answer = 1;
            for (int i = 1; i<8; i++)
                answer *= 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        {
            for (int i = 1; i < 7; i++)
                Console.Write($"{i} ");
        }
        {
            for (int j = 1; j < 7; j++)
                Console.Write($"5 ");
        }

        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        {
            answer = 1;
            if (x==0)
            {
                return 0;
            }
            for (double i = 1, zn = 1; i < 11; i++)
            {
                zn *= x;
                answer += 1 / zn;
            }

        }

        // end

        return Math.Round(answer,2);
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x<=-1)
        {
            answer= 1;
        }
        else if (x<=1)
        {
            answer = -x;
        }
        else if(x>1)
        {
            answer = -1;
        }

        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        {
            int fib1 = 0;
            int fib2 = 1;
            int gl;
            for (int cnt = 1; cnt < 9; cnt++)
            {
                Console.WriteLine("{0}",fib2);
                gl = fib2;
                fib2 += fib1;
                fib1 = gl;
            }
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        {
            int ch1 = 1;
            int zn1 = 1;
            int ch2 = 2;
            int zn2 = 1;
            int ch = 0;
            int zn = 0;
            for (int cnt = 1; cnt < 4; cnt++)
            {
                ch = ch1 + ch2;
                zn = zn1 + zn2;
                ch1 = ch2;
                ch2 = ch;
                zn1 = zn2;
                zn2 = zn;
            }
            answer=(double)ch / zn;

        }

        // end

        return Math.Round(answer,1);
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        {
            double cnt = 1;
            for (int i = 1; i < 65; i++)
            {
                answer += cnt;
                cnt *= 2;
            }
            answer /= 15;
            power = (int)Math.Log10(answer);
            answer = Math.Round(answer / Math.Pow(10,power),2);
        }
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        {
            answer = Math.Sqrt((6350 + x) * (6350 + x) - 6350 * 6350);
        }

        // end

        return Math.Round(answer,2);
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here
        {
            for (int i = 0; i < x; i += 3)
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
        {
            double part;
            int n = 1;
            do
            {
                part = Math.Cos(n * x) / (n * n);
                n++;
                answer += part;
            }
            while (Math.Abs(part) >= 0.0001);
        }

        // end

        return Math.Round(answer,2);
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

        // code here
        {
            double s = 0;
            int n = 0;
            if (p==0 || h<=0)
            {
                return 0;
            }
            while (s <= p)
            {
                s += a + n * h;
                n++;
            }
            answer = n - 1;
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
        {
            if (M==0)
            {
                return (0,0);
            }
            N=Math.Abs(N);
            M=Math.Abs(M);
            remainder = N;
            while (remainder >= M)
            {
                quotient++;
                remainder = remainder - M;
            }
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
        double answer = 10;

        // code here
        {
            double perday = 10;
            for (int i=1; i<7; i++)
            {
                perday *= 1.1;
                answer+= perday;
            }
        }
        // end

        return Math.Round(answer,2);
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        {
            answer = 1;
            double perday = 10;
            double sum = 10;
            while (sum <= 100)
            {
                perday *= 1.1;
                sum += perday;
                answer++;
            }
        }

        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        {
            double perday = 10;
            while (perday<=20)
            {
                perday *= 1.1;
                answer++;
            }
        }

        // end

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

        // code here;
        {
            double L = 0.1;
            double D = Math.Pow(10, -10);
            while (L > D)
            {
                L /= 2;
                answer++;
            }
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
        {
            y = Math.Cos(x);
            double i = 0;
            double ch1 = 1;
            double ch2 = 1;
            double zn = 1;
            double part = ch1 * ch2 / zn;
            while (Math.Abs(part) >= 0.0001)
            {
                S += part;
                i++;
                ch1 *= -1;
                ch2 *= x * x;
                zn *= (2 * i - 1) * (2 * i);
                part= ch1 * ch2 / zn;
            }

        }


        // end

        return (Math.Round(S,2), Math.Round(y,2));
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
