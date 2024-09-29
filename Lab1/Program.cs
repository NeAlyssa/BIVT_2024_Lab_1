using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.IO.Pipes;
using System.Net.WebSockets;
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

        // code here
        for (int i = 2; i < 36; i += 3)
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
        for (int n = 1; n < 11; n += 1)
        {
            answer += Convert.ToDouble(1) / n;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (int n = 2; n < 113; n += 2)
        {
            answer += Convert.ToDouble(n) / (n + 1);
        }
        answer = Math.Round(answer);
        // end
        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        double p = 1;

        // code here
        if (x == 0)
        {
            answer = 0;
        }
        else
        {
            for(int i = 1; i <= 9; i++)
            {
                answer += (Math.Cos(i * x)) / p;
                p *= x;
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
        answer += p * p;
        for(int i = 1; i < 10; i++)
        {
            answer += (p + (i * h)) * (p + (i * h));
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
        int answer = 1;

        // code here
        for (int n = 1; n < 7; n++)
        {
            answer *= n;
        }
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int f = 1;
        for (int i = 1; i <= 6; i++)
        {
            f *= i;
            answer += f;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double p = 1;
        double k = 1;
        double f = 1;
        for (double i = 1; i <= 6; i++)
        {
            f *= i;
            p *= 5;
            k *= (-1);
            answer += k * p / f;
        }
        // end
        answer = Math.Round(answer, 2);
        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        
        for(int n =1; n < 8; n++)
        {
            answer *= 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int n = 1; n < 7; n++)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();
        for (int i = 1; i < 7; i++)
        {
            Console.Write("5 ");
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;
        double p = 1;
        // code here
        if(x == 0)
        {
            answer = 0;
        }
        else
        {
            for(double i = 0; i <= 10; i++)
            {
                answer += 1 / p;
                p *= x;
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
        if (x <= -1)
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
        int n1 = 1;
        int n2 = 1;
        Console.Write(n1 + " ");
        Console.Write(n2 + " ");
        for (int i = 3; i <= 8; i++)
        {
            int p = n1 + n2;
            Console.Write(p + " ");
            n1 = n2;
            n2 = p;
        }

        // code here
    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        int fc = 1, sc = 2, fz = 1, sz = 1;
        for (int i = 3; i <= 5; i++)
        {
            int f = fc + sc;
            fc = sc;
            sc = f;
            int p = fz + sz;
            fz = sz;
            sz = p;
            answer = Convert.ToDouble(f) / p;
            // end
        }
        return answer;
    }
    public (double, int) Task_1_16()
    {
       
        int power = 0;

        // code here
        double answer = 1;
        double p = 1;
        for (int i = 1; i < 64; i++)
        {
            p *= 2;
            answer += p;
        }
        answer /= 15;
        while (answer >= 10)
        {
            power++;
            answer /= 10;
        }
        answer = Math.Round(answer, 2);

        return (answer, power);

    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        double r = 6350;
        // code here
        answer = (r + x) * (r + x) - r * r;
        answer = Math.Sqrt(answer);
        answer = Math.Round(answer, 2);
    
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        answer = 10;
        for (int i = 3; i <= x; i += 3)
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

        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 0;
        // code here
        int l = 30000;
        for(int i = 1; i < 1000; i += 3)
        {
            int p = 1;
            for (int g = 1; g <= i; g += 3)
            {
                p *= g;
            }
                if(p > l)
                {
                    break;
                }
                else
                {
                    answer = i;
                }
   
        }
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
        answer += 1;
        if (Math.Abs(x) >= 1) 
            return 0;
        double p = x * x;
        double eps = 0.0001;
        while (Math.Abs(p) >= eps)
        {
            answer += p;
            p *= x * x;
         
        }
        answer = Math.Round(answer, 2);
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
        int kl = 10;

        // code here
        while(kl <= 100000)
        {
           
            kl *= 2;
            answer += 3;
    
        }
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
        double s = 10000;

        // code here;
        while(s <= 20000)
        {
            s *= 1.08;
            answer += 1;
        }
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
        int fc = 1, sc = 2, fz = 1, sz = 1;
        while (Math.Abs((Convert.ToDouble(sc) / sz) - (Convert.ToDouble(fc) / fz)) > 0.001)
        {
            int p = fc + sc;
            fc = sc;
            sc = p;
            int f = fz + sz;
            fz = sz;
            sz = f;
            answer++;
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
        double S = 0;
        double y = 0;
        double a;
        int i;
        double eps = 0.0001;
        for(x = 0.1; x <= 1; x += 0.05)
        {
            S = 0;
            a = 1;
            i = 0;
            while(Math.Abs(a) >= eps)
            {
                S += a;
                i += 1;
                a = a * 2 * x / i;
            }
            y = Math.Exp(2 * x);

        }
        return (S, y);
    }
    public (double, double) Task_3_9(double x)
    {
        double S = 1, y = 1;

        // code here
       
        // end

        return (S, y);
    }
    #endregion
}
