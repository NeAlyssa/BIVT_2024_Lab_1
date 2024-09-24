using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Transactions;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

        program.Task_1_1();
        program.Task_1_2();
        program.Task_1_3();
        program.Task_1_4(0.9);
        program.Task_1_5(0, 2);
        program.Task_1_6(4);
        program.Task_1_7();
        program.Task_1_8();
        program.Task_1_9();
        program.Task_1_10();
        program.Task_1_11();
        program.Task_1_12(0.9);
        program.Task_1_13(-1.5);
        program.Task_1_14();
        program.Task_1_15();
        program.Task_1_16();
        program.Task_1_17(10);
        program.Task_1_18(24);
        program.Task_2_1(0);
        //program.Task_2_2();
        program.Task_2_3(8, 2, 0);
        //program.Task_2_4(0.8);
        program.Task_2_5(11, 5);
        //program.Task_2_6();
        program.Task_2_7a();
        program.Task_2_7b();
        program.Task_2_7c();
        //program.Task_2_8();
        program.Task_2_9();
        //program.Task_2_10();
        //program.Task_3_1(0.1);
        //program.Task_3_2(0.1);
        //program.Task_3_3(0.1);
        //program.Task_3_4(0.1);
        //program.Task_3_5(double.Pi/5);
        //program.Task_3_6(0.1);
        program.Task_3_7(0.1);
        //program.Task_3_8(0.1);
        //program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;

        // code here
        int i, s = 0;
        for (i = 2; i <= 35; i = i + 3)
            s = s + i;
        answer = s;
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        double s = 0;
        for (double i=1; i<=10; i=i+1)
            s = s + 1.0/i;
        answer = (Math.Round(s,2));
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double s = 0;
        for (double i = 2; i <= 112; i = i + 2)
            s = s + i / (i + 1.0);
        answer = (Math.Round(s));
        // end
        
        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double s = Math.Cos(x);
        double x1 = 1;
        if (x == 0) return 0;
        if (x != 0)
        {
            for (int i = 2; i <= 9; i++)
            {
                x1 = x1 * x;
                s = s + Math.Cos(x * i) / x1;
            }
            if (s >= 0) answer = (Math.Round(s, 2));
            if (s < 0) answer = (-1 * Math.Round(Math.Abs(s), 2));
        }
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        double s = 0;
        for (int i = 0; i<=9; i++)
        {
            s = s + (p + i * h) * (p + i * h);
        }
        answer = (Math.Round(s,3));
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;
        //for (x=-4; x<=4; x+=0.5)
        //{
        //    answer = 0.5 * x * x - 7 * x;
        //    return answer;
        //}
        double i = -4;
        while (i<=4)
        {
            double y = (0.5 * x * x - 7 * x);
            answer=Math.Round(y,2);
            i += 0.5;
        }
        
        //double answer = 0.5 * x * x + 7 * x;
        return answer;


        


    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for (int i = 1; i <= 6; i++)
            answer *= i;
       
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int y = 1;
       // int s = 0;
        for (int i = 1; i <= 6; i++)
        {
            y = y * i;
            answer += y;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double s = 0;
        double y = 0;
        int x = 1;
        int o = 1;
        for (int i=1; i<=6;i++)
        {
            if (i % 2 == 0) y = 5.0 *o / (x * i);
            else y = -1 * (5.0 *o/ (x * i));
            o *= 5;
            x *= i;
            s+= y;
            answer = Math.Round(s,2);

        }
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int x = 1;
        int y = 1;
       while (x<=7)
        {
            y *= 3;
            x++;
        }
        // end
        answer = y;
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
        double s = 1;
        double y = 0;
        double u = 1;
        if (x == 0) return 0;
        for (int i=1;i<=10;i++)
        {
            y = 1.0 / (x * u);
            u *= x;
            s+= y;
        }
        // end
        answer = Math.Round(s,2);
        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;
        //double i = -1.5;
        // while (i<=1.5)
        //{
        //    if (i <= -1) answer = 1;
        //    if (i > -1 || i <= 1) answer = -i;
        //     if (i > 1) answer = -1;
        //    i += 0.1;
        // }
        if (x <= -1)
        {
            answer = 1;
        }
        if (x > -1 && x <= 1)
        {
            answer = -x;
        }
        if (x > 1)
        {
            answer = -1;
        }
        // code here
        // double y = 0;
        // while (x<=1.5)
        //  {
        //  if (x <= -1) y = 1;
        // if (x > -1 || x <= 1) y = -x;
        //  if (x>1) y = -1;
        // x += 0.1;
        // Console.WriteLine(y);
        // return y;

        // }
        // for (x=-1.5;x<=1.5; x += 0.1)
        //  {
        //       if (x <= -1) y = 1;
        //    if (x > -1 || x <= 1) y = -x;
        //    if (x>1) y = -1;
        //     return y;
        // }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int x = 1;
        int y = 1;
        Console.WriteLine(x);
        Console.WriteLine(y);

        for (int i = 1; i <= 6; i++)
        {
            int z = x + y;
            Console.WriteLine(z);
            x = y;
            y = z;

        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        //double s = 0;
        double x = 1;
        double x1 = 1;
        double x2 = 0;
        double y = 1;
        double y1 = 0;
        double y2 = 0;
        for (int i=1; i<=5; i++)
        {
            if (i == 1) answer = x/y;
            if (i > 1)
            {
                answer = Math.Round((x + x1) / (y + y1), 2);
                x2 = x;
                x = x1 + x;
                x1 = x2;
                y2 = y;
                y = y1 + y;
                y1 = y2;
            }
        }
        // end
        return Math.Round(answer,2);
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double x = 1;
        double s = 1;
        for (int i=1;i<=63;i++)
        {
            x = x * 2;
            s =s+x;
            
        }
        // end
        double r = s / 15.0;
        power = (int)Math.Log10(r);
        for (int g=1; g<=power; g++)
        {
            r /= 10;
        }
        answer = Math.Round(r,3);
        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double R = 6350;
        answer = Math.Round(Math.Sqrt((R + x) * (R + x) - R * R), 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int d = 10;
        int y = x / 3;
        for (int i=1; i<=y; i++)
        {
            d = d * 2;
        }
        answer = d;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here
        double s = 0;
        double y = 0;
        int i = 1;
        do
        {
            y = (Math.Cos(i * x) / (i * i));
            i++;
            s += y;
        }
        while (Math.Abs(y) >= 0.0001);
            // end
            answer = Math.Round(s,2);
        return answer;
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
        int n = 0;
        double s = 0;
        do
        {
            s += (a + h * n);
            n++;
            if (h < 0)
            {
                answer = 0;
                s = p + 1;
            }
        }
        while (s <= p);
        // end
        answer = n - 1;
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
        if (N == 0 || M == 0) return (0,0);
        quotient = N / M;
        remainder = Math.Abs(N- (N / M * M));

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
        double answer = 0;

        // code here
        double s = 0;
        double y = 10;
        for (int i=1; i<=7;i++)
        {
            s += y;
            y = 1.1 * y;
        }
        // end
        answer = Math.Round(s,2);
        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double s = 0;
        double y = 10;
        int d = 0;
        do
        {
            s += y;
            y = 1.1 * y;
            d++;
        }
        while (s < 100);
        // end
        answer = d;
        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double s = 0;
        double y = 10;
        int d = 0;
        do
        {
            s += y;
            y = 1.1 * y;
            d++;
        }
        while (y<=20);
        // end
        answer = d;

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
        double L = 0.1;
        int i = 0;
        do
        {
            L = Math.Round(L / 2.0, 10);
            i++;
        }
        while (L > Math.Pow(10, -10));
        // end
        answer = i;
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
        double S = 1, y = 0;

        // code here
        double u = 1;
        int i = 1;
        int d = i;
        double o = 1;
        while (Math.Abs(u) >= 0.0001) 
        {
            d = (d * 2 * i * (2 * i - 1));
            u =(o*x*x) / d;
            o *= x * x;
            i++;
            S += u;
        }
        // end
        y = (Math.Pow(double.E, x) + Math.Pow(double.E, -x)) / 2;
        
        return (Math.Round(S, 2), Math.Round(y,2));
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