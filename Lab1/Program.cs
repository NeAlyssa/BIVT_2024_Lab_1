using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    double poww(double pow_b, int power)
    {
        if (power == 0)
        {
            return pow_b;
        }
        else
        {
            return poww(pow_b, power - 1) * pow_b;
        }
    }
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
        program.Task_2_6();
        //program.Task_2_7a();
        //program.Task_2_7b();
        //program.Task_2_7c();
        program.Task_2_8();
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
        for (int i= 2; i<=35; i += 3)
        {
            answer = answer + i;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (int i=1; i<=10; i++)
        {
            answer = answer + 1.0 / i;
        }
        answer = Math.Round(answer * 100) / 100;
        Console.WriteLine(answer) ;
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (int i=2; i<=112; i += 2)
        {
            answer = answer + i / (i + 1.0);
        }
        answer = Math.Round(answer);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        for (int i=0; i<=8; i++)
        {
            if (x == 0) { return 0; }
            answer = answer + Math.Cos((i + 1.0) * x) / poww(x, i);
        }
        answer = Math.Round(answer,2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i = 0; i <= 9; i++)
        {
            answer = answer + poww((p + i * h), 2);
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * poww(x, 2) - 7 * x;
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;
        
        // code here
        for (int i=2; i<=6; i++)
        {
            answer = answer * i;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;
        
        // code here;
        for (int i=1; i<=6; i++)
        {
            int ier = 1;
            for (int n =1; n<=i; n++)
            {
                ier = ier * n;
            }
            answer = answer + ier;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        for (int i = 1; i <= 6; i++)
        {
            int ier = 1;
            for (int k = 1; k<=i; k++)
            {
                ier *= k;
            }
            answer = answer + (poww(-1, i) * poww(5, i)) / ier;
        }
        Console.WriteLine(answer);
        // end

        return Math.Round(answer, 2);
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        for ( int i=1; i<=7; i++)
        {
            answer *= 3;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        //a)
        for (int i=1; i<=6; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        //b)
        for (int i=1; i<=6; i++)
        {
            Console.Write(5 + " ");
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x ==0) { return 0; }
        for (int i = 0; i <= 10; i++)
        {
            answer += 1 / poww(x, i);
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
        if ( x <= -1)
        {
            answer = 1;
        }else if (-1<x && x <= 1)
        {
            answer = -1*x;

        }else
        {
            answer = -1;
        }
        //end
        return answer;
    }
    public void Task_1_14()
    {
        
        // There is no test for this task
        static long git(int n)
        {
            if (n<=2)
            {
                return 1;
            }else { return git(n - 2) + git(n - 1); }
        }
        for (int i = 1; i<=8; i++)
        {
            Console.Write(git(i) + " ");
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;
        
        // code here
        static double znam(int n)
        {
            if (n <= 2) { return 1; }
            else { return znam(n - 2) + znam(n - 1); }
        }
        static double chis(int n)
        {
            if (n == 1)
            {
                return 1;
            }else if (n==2)
            {
                return 2;
            }else { return chis(n - 2) + chis(n - 1); }
        }
        for (int i=1; i<=5; i++)
        {
            answer = chis(i)/znam(i);
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    !!!!!public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;
        double zersum = 1;
        double kletka = 1;
        double var;

        for (int  i=1; i<=63; i++)
        {
            kletka *= 2;
            zersum += kletka;
        }
        var = (double)zersum / 15;
        power = (int)Math.Log10(var);
        answer = var / poww(10, power);
       

        return (Math.Round(answer,2),power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        double r = 6350;

        // code here
        if (x == 0) { return 0; }
        answer = poww(Math.Pow(r + x, 2) - poww(r, 2));
        answer = Math.Round(answer, 2); 
        Console.WriteLine(answer);


        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here
        if (x == 0) { return 0; }
        answer *= (int) poww(2, x / 3);
        
        // end
        Console.WriteLine(answer);
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
        int p = 1;
        int n =1;
        // code here
        while (p * n < 30000)
        {
            n += 3;
            p *= n;
            
        }
        
        Console.WriteLine(n);
        // end

        return n;
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
        double s = 1;
        double n = 2;
        const double e = 0.001;
        double perem = 1;
        // code here
        if (x==1)
        {
            return 0;
        }
        do
        {
            for (int i = 2; i <= n; i += 2)
            {
                perem *= x;

            }
            s += perem;
            n += 2;

        } while (perem > e);
        // end
        s = Math.Round(s, 2);
        return s;
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
         int kl = 10;
         int t = 0;
         while (kl < poww(10, 5))
         {
             kl *= 2;
             t += 3;

         }
         answer = t;

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
        double sum = 10000;
        int t = 0;
        // code here;
        
        while (sum < 20000)
        {
            sum *= 1.08;
            t++;
        }
        answer = t;
        // end
        Console.WriteLine(answer);
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

        // code here;
        static double znam(int n)
        {
            if (n <= 2) { return 1; }
            else { return znam(n - 2) + znam(n - 1); }
        }
        static double chis(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else if (n == 2)
            {
                return 2;
            }
            else { return chis(n - 2) + chis(n - 1); }
        }
        for (int i = 1; i <= 5; i++)
        {
            answer = chis(i) / znam(i);
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