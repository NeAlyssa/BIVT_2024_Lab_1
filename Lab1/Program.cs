using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
        //program.Task_1_17(1);
        //program.Task_1_18(24);
        //program.Task_2_1(0);
        //program.Task_2_2();
        //program.Task_2_3(8, 2, 0);
        //program.Task_2_4(1);
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
        for (double i = 0.1; i<1; i+=0.1){
        program.Task_3_3(i);
        }
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
        int sum = 0;
        for(int s = 2; s<=35;s+=3)
        {
         sum += s;
        }
        answer = sum;
        
        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;
        double s = 0;
        for (double i = 1; i <= 10; i++)
        {
            s = s + 1/i;
        }
        Math.Round(s,2);
        answer = Math.Round(s,2);
        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        double summa = 0;
        double a = 2;
        double b = 3;
        
        while(a<=112)
        {
            summa = summa + a/b;
            a = a + 2;
            b = b + 2;
        }
        answer = Math.Round(summa, 2);

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        double summa = 0;
        if(x == 0)
        {
            answer = 0;
        }
        else
        {
            for(int i = 1; i < 10; i++)
        {
            summa = summa + Math.Cos(i*x)/Math.Pow(x,i-1);
        }
        answer = Math.Round(summa, 2);
        System.Console.WriteLine(answer);
        }
        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;
        double summa = 0;
        for(int i = 0; i<10; i++)
        {
            summa = summa + Math.Pow((p + h * i), 2);
        }
        answer = summa;

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;
        for(double i = -4; i<=4; i+=0.5)
        {
            answer = Math.Round((0.5 * Math.Pow(x,2) - 7 * x),2);
        }
        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;
        int f = 1;
        for(int i = 1; i<7; i++)
        {
            f = f * i;
        }
        answer = f;
        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;
        int summa = 0;
        int f = 1;
        int a = 1;

        for(int i = 1; i<=6; i++)
        {
            for(int j = 1; j<=a; j++)
            {
                f = f * j;
            }
        a +=1;
        summa = summa + f;
        f = 1;
        }
        answer = summa;
        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        double summa = 0;
        double f = 1;
        double a = 1;

        for(int i = 1; i<=6; i++)
        {
            for(int j = 1; j<=a; j++)
            {
                f = f * j;
            }
        a +=1;
        summa = summa + Math.Pow(-1,i) * Math.Pow(5, i)/f;
        f = 1;
        }
        answer = Math.Round(summa, 2);
        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        int n = 3;
        int s = 3;
        for(int i = 1; i<=6; i++)
        {
            s = s * n;
        }
        answer = s;
        return answer;
    }
    public void Task_1_11()
    {
        int a = 1;
        for(int i = 1; i<=6; i++)
        {
            
            System.Console.Write(a + " ");
            a += 1;
        }
        a = 1;
        System.Console.WriteLine();
        for(int i = 1; i<=6; i++)
        {
            
            System.Console.Write(a * 5 + " ");
        }

    }
    public double Task_1_12(double x)
    {
        double answer = 0;
        double summa = 0;
        
        if(x == 0)
        {
            answer = 0;
        }
        
        else
        {
        for(int i = 0; i <= 10; i++)
        {
            summa = summa + 1/Math.Pow(x, i);
        }
        answer = Math.Round(summa, 2);
        }
        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        for(double i = -1.5; i <= 1.5; i+=0.1 )
        {
            if(x <= -1)
            {
                answer = 1;
            }
            else if(-1 < x & x < 1)
            {
                answer = -x;
            }
            else
            {
                answer = -1;
            }
        }

        return answer;
    }
    public void Task_1_14()
    {
       int f = 0;
       int a = 1;
       int b = 1;
       for(int i = 1; i <= 8; i++)
       {
       Console.WriteLine(a);
        f = a + b;
        a = b;
        b = f;
       }
    }
    public double Task_1_15()
    {
        double answer = 0;
        int n = 5;
        double a1 = 1;
        double b1 = 1;
        double a2 = 2;
        double b2 = 1;
        double f=0;
        
        for(int i = 1; i <= n-2; i++)
        {
            f = (a1 + a2)/(b1 + b2);
            double a3 = a1 + a2;
            double b3 = b1 + b2;
            a1 = a2;
            b1 = b2;
            a2 = a3;
            b2 = b3;
            
        }
        answer = f;
        
        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;
        double a = 1;
        
        for(int i = 1; i <= 64; i++)
        {
            a = a * 2;
        }
        a = a/15;
        while(a > 10)
        {
            a = a / 10;
            power +=1;
        }
        answer = Math.Round(a, 2);
        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        double r = 6350;
        
        for(int i = 1; i <= 10; i++)
        {
         answer = Math.Sqrt((Math.Pow((r+x),2) - Math.Pow(r, 2)));
        }
        answer = Math.Round(answer,2);
        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        int n = 10;
        
        for(int i = 1; i <= (x/3); i++)
        {
            n = n * 2;
        }
        answer = n;
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
        int answer = 0;
        int L = 1;
        int n = 1;
        while(true)
        {
            n = n + 3;
            L = L * n;
            if(L > 30000)
            {
                n = n - 3;
                break;
            }
        } 
        answer = n;

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

        int n = 1;
        double e = 0.0001;
        double a;
        double s = 1;

        {
            if(x<1 && x > -1)
            {
            while(true)
            {
            a = Math.Pow(x, 2 * n);
            if(a < e)
            {
                break;
            }
            s = s + Math.Pow(x, 2 * n);
            n +=1;
            }
            System.Console.WriteLine(s);
            answer = Math.Round(s,2);
            }
            else
            {
                answer = 0;
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
        int n = 10;
        int time = 0;
        while(true)
        {
            n = n * 2;
            time +=3;
            if(n > Math.Pow(10,5))
            {
                break;
            }
        }
        
        answer = time;

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
        double s = 10000;
        int m = 0;
        while(true)
        {
            s = s * 1.08;
            m +=1;
            if(s >= 20000)
            {
                break;
            }
        }
        answer = m;
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
        int answer = 0;
        double a1 = 1;
        double b1 = 1;
        double a2 = 2;
        double b2 = 1;
        double f = 0;
        int n = 2;

        while(true)
        {
            f = (a1 + a2)/(b1 + b2);
            double a3 = a1 + a2;
            double b3 = b1 + b2;
            a1 = a2;
            b1 = b2;
            n +=1;
            if(f - a2/b2 <= 0.001 & f - a2/b2 >0)
            {
                answer = n;
                break;
            }
            a2 = a3;
            b2 = b3;
        }
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
        double S = 1, y = 0;
        double i = 1;
        double member = 1;
        double r = 1;
        x = Math.Round(x, 2);

        while(Math.Abs(member) >= 0.0001)
        {
            member = Math.Cos(i * x)/r;
            S += member;
            //System.Console.WriteLine($"x: {x} i: {i} fact: {r} member: {member} S: {S}");
            i++;
            r *= i;
        }
        y = Math.Pow(Math.E, Math.Cos(x))*Math.Cos(Math.Sin(x));
        S = Math.Round(S,2);
        System.Console.WriteLine(S);
        y = Math.Round(y,2);
        
        return (S, y);
    }
    public (double, double) Task_3_4(double x)
    {
        double S = 0, y = 0;

        //  double S = 0, y = 0;
        // double a = 0.1;
        // double b = 1;
        // double h = 0.1;
        // int i = 0;
        // int r;

        //     while(true)
        //     {
        //         r = 1;
        //         for(int j = 1; j <= i; j++)
        //         {
        //             r *= j;
        //         }
        //         System.Console.WriteLine(r);
        //         if(Math.Cos(x * i)/r < 0.0001)
        //         {
        //             break;
        //         }
        //         S = S + Math.Cos(x * i)/r;
        //         i += 1;
                
        //     }
        //     y = Math.Pow(Math.E, Math.Cos(x)) * Math.Cos(Math.Sin(x));
        
        
        // S = Math.Round(S, 2);
        // y = Math.Round(y, 2);
        // return (S, y);

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