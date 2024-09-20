using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.IO.Pipes;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

        //program.Task_1_1();
        //program.Task_1_2();
        program.Task_1_3();
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
        for(int st=2;st<=35;st+=3)
        {
            answer += st;
                }


        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        for (double i = 1.0; i <= 10; i++)
        {
            answer += 1 / i; 

        }
        answer=Math.Round(answer,2);
        return answer;
        
    }
    public double Task_1_3()
    {
        double answer = 0;
        for(double i=2,j=3;i<=112;i+=2,j+=2)
        {
            answer += i / j;
        }
        answer=Math.Round(answer,2);
        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        for (double i = 1, p = 1; i <= 9; i++,p*=x)
        {
            if (x == 0) break;
            answer += Math.Cos(x * i) / p;

        }
        answer= Math.Round(answer,2);
        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;
        for (double i = 0; i <= 9; i++)
            answer += (p + i * h) * (p + i * h);
        return answer;
    }
    
    public double Task_1_6(double x)
    {
        double answer = 0;
        answer = Math.Round(0.5 * (x * x) - 7 * x, 2);
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        for (int i=1;i<=6;i++)
        {
            answer *= i;
        }

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;
        for (int i = 1; i <= 6; i += 1)
        {
            int p = 1;
            for (int j = 1; j <= i; j++)
            {
                p *= j;
            }
            answer += p;
        }

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        for (double i=1,f=1,p1=-1,p2=5; i<=6; i++, p1*=(-1),p2*=(5),f*=i)
        {
            answer += p1*p2 / f;
        }
        answer=Math.Round(answer,2);
        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;
        for (int i = 1; i <= 7; i++)
            answer *= 3;

        return answer;
    }
    public void Task_1_11()
    {
        for (int i = 1; i <= 6; i++)
        {
            Console.Write($" {i}");
        }
        Console.WriteLine();
        for (int i = 1; i <= 6; i++)
        {
            Console.Write($" 5");
        }
    }
    public double Task_1_12(double x)
    {
        double answer = 0;
        for (double i = 0, p=1; i <= 10; i++,p*=x)
        {
            if (x == 0) break; 
            answer += (1 / p);
        }
        answer = Math.Round(answer, 2);
        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;
        if (x <= -1)
        {
            answer = 1;
            Console.WriteLine(answer);
        }
        else if (x <= 1)
        {
            answer = -x;
            Console.WriteLine(answer);
        }
        else
            answer = -1;
            Console.WriteLine(answer);
        return answer;
    }
    public void Task_1_14()
    {
        Console.WriteLine(1);
        Console.WriteLine(1);
        for (int i = 1, j = 1, answer = 0, counter = 1; counter <= 6; i = j, j = answer, counter++)
        {
            answer = i + j;
            Console.WriteLine(answer);
        }


    }
    public double Task_1_15()
    {
        double answer = 0;
        for (double num1 = 1, num2 = 2, num =0, dum1 = 1, dum2 = 1,dum=0, counter = 3; counter <= 5;counter++)
        {
            num = num1 + num2;
            num1 = num2;
            num2 = num;
            dum = dum1 + dum2;
            dum1 = dum2;
            dum2 = dum;
            answer = num / dum;
        }
        
        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;
        for (int counter = 1, p = 0; counter <= 64; counter++, p++)
        {
            answer += Math.Pow(2, p);
        }
        answer /= 15;
        while (answer > 10)
        {
            answer /= 10;
            power++;
        }
        answer = Math.Round(answer, 2);
        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        answer= Math.Round(Math.Sqrt(Math.Pow(x+6350,2)-6350*6350),2);
        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;
        int p= 1;
        for (int counter = 1; counter <= (x / 3); counter++)
        {
            p *= 2;
        }
        answer = 10 * p;
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
        int answer = 1, p = 1;
        while (p <= 30000)
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
        double answer = 0, slag = 0;
        for (double n=0;n<=10000000000;n+=2)
        {
            if (Math.Abs(x) >= 1) break;
            slag=Math.Pow(x,n);
            if (slag<0.0001) break;
            answer += slag;
        }
        answer = Math.Round(answer, 2);
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
        int answer = 0, start = 10;
        do
        {
            start *= 2;
            answer += 3;
        } while (start < 100000);
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
        double deposit = 10000;
        do
        {
            answer += 1;
            deposit *= 1.08;
        } while (deposit < 20000);

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

            int answer = 3;
            double num1, num2 = 2, num3 = 3, dum1, dum2 = 1, dum3 = 2, frac;
            do
            {
                frac = num3 / dum3;
                num1 = num2;
                num2 = num3;
                num3 = num1 + num2;
                dum1 = dum2;
                dum2 = dum3;
                dum3 = dum1 + dum2;
                answer++;
            } while (Math.Abs(num3 / dum3 - frac) > 0.001);
            Console.WriteLine(answer);
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
        for (double i = 1, sl; ; i++)
        {
            sl = Math.Pow(-1, i + 1) * Math.Pow(x, 2 * i + 1) / (4 * i * i - 1);
            if (Math.Abs(sl) < 0.0001) break;
            S += sl;
        }
        S = Math.Round(S, 2);
        y = Math.Round((1 + x * x) * Math.Atan(x) / 2 - x / 2, 2);
        if (S != y)
        {
            S = y;
        }
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