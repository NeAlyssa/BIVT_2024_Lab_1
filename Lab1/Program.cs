using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Xml.Linq;

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
            answer = answer + i;
        }
        // end
         
        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;
        // code here
        for(double i = 1; i <= 10; i++)
        {
            answer += 1 / i;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for(double i = 3; i <= 113; i+=2)
        {
            answer = answer + (1 - 1 / i);
        }
        answer = Math.Round(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = Math.Cos(x);

        // code here
        if (x == 0)
        {
            return 0;
        }
        else
        {
            double i = 2, del = x;
            while(i <= 9)
            {
                answer += Math.Cos(i * x) / del;
                del *= x;
                i++;
            }
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;
        // code here
        double s = p * p;
        for(double n = 1; n <= 9; n++)
        {
            s += ((p + n * h) * (p + n * h));
        }
        answer = Math.Round(s, 2);
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
        int answer = 1;

        // code here
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
        int i = 0, nx = 1;
        while(i <= 5)
        {
            nx *= (i + 1);
            answer += nx;
            i++;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double i = 0, nx = 1, ne = 1;
        while(i <= 5)
        {
            nx *= (i + 1);
            ne *= -5;
            answer += ne / nx;
            i++;
        }
        answer = Math.Round(answer, 2);
        // end
         
        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        for(int i = 1; i <= 7; i++)
        {
            answer *= 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for(int i = 1; i <= 6; i++)
        {
            Console.Write($"{i} ");
        }
        for (int j = 1; j <= 6; j++)
        {
            Console.Write($"{5} ");
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 1;

        // code here
        if (x == 0)
        {
            return 0;
        }
        else
        {
            double i = 1, nx = 1 ;
            while(i <= 10)
            {
                nx *= x;
                answer += 1 / nx;
                i++;
            }
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
        if(x > -1 && x <= 1)
        {
            answer = -x;
        }
        if(x > 1)
        {
            answer = -1;
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a = 1, b = 1;
        int c = 0;
        for(int i = 1; i <= 6; i++)
        {
            c = a + b;
            b = a;
            a = c;

        }
        Console.WriteLine(a);
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double ch = 1, znam = 1, dr = 0, s = 0;
        for(int i = 1; i <= 5; i ++)
        {
            dr = ch / znam;
            s = ch + znam;
            znam = ch;
            ch = s;
            
            Console.WriteLine($"{ch} {znam}");
        }
        answer = Math.Round(dr, 2);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double s = 0, zerna = 1, g = 1;
        for(int i = 1; i <= 64; i++)
        {
            s += zerna;
            zerna *= 2;
            
        }
        g = s / 15;
        Console.WriteLine(answer);
        while (g >= 2)
        {
            g /= 10;
            power++;
            Console.WriteLine(power);
        }
        answer = Math.Round(g, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double R = 6350;
        answer = Math.Sqrt(x * (2.0 * R + x));
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int ameba = 1;
        for(int i = 3; i <= x; i += 3)
        {
            ameba *= 2;
            answer = 10*ameba;
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

        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 0;

        // code here
        int n = 1;
        int p = 1;
        while(n * p <= 30_000)
        {
            p *= n;
            n += 3;
        }
        answer = n - 3; 
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
        double s = 1, nx = 1;
        const double e = 0.0001;
        if(Math.Abs(x) < 1)
        {
            while(nx >= e)
            {
                nx *= x * x;
                s += nx;
            }
            answer = Math.Round(s, 2);
        }
        else
        {
            answer = 0;
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
        int ameba = 10, time = 0;
        while(ameba < 100000)
        {
            time += 3;
            ameba *= 2;
        }
        answer = time;
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
        double s = 10000, p = 0.08;
        int m = 0;
        while(s <= 2*10000)
        {
            s += s * p;
            m += 1;
        }
        answer = m;
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
        int answer = 0;

        // code here;
        int i = 1;
        double ch = 1, znam = 1, dr = 0, s = 0, dr1 = 1;
        while(Math.Abs(dr1 - dr) >= 0.001)
        {
            dr = ch / znam;
            s = ch + znam;
            znam = ch;
            ch = s;
            dr1 = ch / znam;
            i++;
            Console.WriteLine($"{dr} {dr1}");
        }
        answer = i;
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
        double l = 1, m = 1, p = -1, i = 1, s = 0, nx = x*x*x;
        while(Math.Abs(l) >= 0.0001)
        {
            s += l;
            p = -p;
            l = p * (nx / (4 * i * i - 1));
            nx *= x * x;
            i++;
        }
        y = ((1 + x * x) * Math.Atan(x) / 2) - (x/2);
        S = s - 1;

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
