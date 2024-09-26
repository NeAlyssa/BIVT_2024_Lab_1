using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

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

        // code here
        for (int i = 2; i <= 35; i += 3)
        {
            answer += i;
        }
        Console.WriteLine(answer);
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
        answer = Math.Round(answer * 100) / 100;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (int i = 2; i <= 112; i += 2)
        {
            answer += i / (i + 1.0);
        }
        answer = Math.Round(answer);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        double xi=1;
        // code here
        
        for (int i = 0; i <= 8; i++)
        {
            if (x == 0) { return 0; }
            
            answer += Math.Cos((i + 1.0) * x) / xi;
            xi *= x;
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
        for (int i = 0; i <= 9; i++)
        {
            answer += (p + i * h)* (p + i * h);
        }
        
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * x*x - 7 * x;
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for (int i = 2; i <= 6; i++)
        {
            answer *= i;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_8()
    {
        double answer = 0;
        double ier = 1;
        // code here;
        for (double i = 1; i <= 6; i++)
        {
            ier *= i;
            answer += ier;
            
        }
        Console.WriteLine(answer);
        // end

        return (int) answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        double c_1 = 1;
        double c_2 = 1;
        double ier = 1;
        for (int k = 1; k <= 6; k++)
        {
            
            c_1 *= (-1);
            c_2 *= 5;
            ier *= k;

            answer += c_1 * c_2 / ier;
        }
       
        Console.WriteLine(answer);
        // end

        return Math.Round(answer, 2);
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        for (int i = 1; i <= 7; i++)
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
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        //b)
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(5 + " ");
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;
        double per = 1;
        // code here
        
        if (x == 0) { return 0; }
        for (int i = 0; i <= 10; i++)
        {
            answer += 1 / per;
            per *= x;
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
        else if (-1 < x && x <= 1)
        {
            answer = -1 * x;

        }
        else
        {
            answer = -1;
        }
        //end
        return answer;
    }
    public void Task_1_14()
    {
        double ch1 = 0;
        double ch2 = 1;
        double p;
        // There is no test for this task
        for (int i = 1; i <= 8; i++)
        {
            p = ch1 + ch2;
            ch1 = ch2;
            ch2 = p;
            Console.Write(ch2+" ");
        }

        
        // code here
       
    }
    public double Task_1_15()
    {
        double answer = 0;
        double chis1 = 1;
        double chis2 = 2;
        double znam1 = 1;
        double znam2 = 1;
        double p;
        double g;

        // code here
        
        for (int i = 1; i <= 5; i++)
        {
            p = chis1 + chis2;
            chis1 = chis2;
            chis2 = p;

            g = znam1 + znam2;
            znam1 = znam2;
            znam2 = g;

            
        }
        answer = chis2 / znam2;
        Console.WriteLine(Math.Round(answer, 1));
        // end

        return (Math.Round(answer,1));
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;
        double zersum = 1;
        double kletka = 1;
        double var;
        double f = 1;

        for (int i = 1; i <= 63; i++)
        {
            kletka *= 2;
            zersum += kletka;
        }
        var = (double)zersum / 15;
        power = (int)Math.Log10(var);
        for (int j = 1; j <= power; j++)
        {
            f *= 10;
        }
        answer = var / f;


        return (Math.Round(answer, 2), power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        double r = 6350;

        // code here
        if (x == 0) { return 0; }
        answer = Math.Sqrt((r + x)*(r + x) - r*r);
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);


        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;
        double t = 1;
        // code here
        if (x == 0) { return 0; }
        for (double j = 1; j <= (x / 3); j++)
        {
            t *= 2;
        }
        answer *= (int) t;

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
        int p = 1;
        int n = 1;
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
        double answer = 1;
        const double E = 0.0001;
        double chl;
        double pow = 2;
        double per = 1;
        if (x==1) { return 0; }

        do
        {
            per *= x*x;
            chl = per;
            answer += chl;
            pow += 2;
        } while (chl > E);

        return (Math.Round(answer, 2));
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
        while (kl < 100000)
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
        
        int answer = 2;
        // code here;
        double chis1 = 1;
        double znam1 = 1;
        double chis2 = 2;
        double znam2 = 1;
        double t;
        const double ep = 0.001;
        while (Math.Abs(chis2 / znam2 - chis1 / znam1) > ep)
        {
            chis1 += chis2;
            znam1 += znam2;

            t = chis1;
            chis1 = chis2;
            chis2 = t;

            t = znam1;
            znam1 = znam2;
            znam2 = t;

            answer++;
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
     
         double S = 0;
         double y = 0;
         double chl= 1;
         const double E = 0.0001;
         double i = 1;
        double c_1 = -1;
        double c_2 = x;
        
 

         while (true)
         {
            c_1 *= -1;
            c_2 *= x * x;

            chl = c_1 * c_2 / (4 * i * i - 1);

            i++;
            
            if (Math.Abs(chl) >= E)
            {
                S += chl;
            }
            else { break; }
         }

         y = ((1 + x*x) * Math.Atan(x)) / 2 - (x / 2);

         return (S,y);
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