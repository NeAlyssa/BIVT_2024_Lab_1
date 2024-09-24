using System.Collections.Generic;
using System.ComponentModel;
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

        // code here
        for (int i = 2; i <=35; i+=3)
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
        for (int i = 1; i<=10; i++)
        {
            answer += 1.0 / i;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (int i = 2; i<=112; i += 2)
        {
            answer =answer+ (i / (i + 1.0));
        }
        // end
        answer=Math.Round(answer);
        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double a = 1.0;
        if (x == 0)
        {
            answer = 0;
        }
        else
        {

            for (int i = 1; i <= 9; i++)
            {
                answer += (Math.Cos(i * x) / a);
                a *= x;
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
        for (int i = 0; i<=9; i++)
        {
            answer += (p + h * i) * (p + h * i);
        }
        answer= Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * x * x - 7 * x;
        answer=Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        answer+= 1;
        for (int i = 1; i <= 6; i++)
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
        int a = 1;
        for (int i = 1; i <=6; i++)
        {
            a = a * i;
            answer += a;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double a = 1;
        for (int i = 1; i <=6; i++)
        {
            a = a * (-1) * 5 / i;
            answer += a;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        answer += 1;
        for (int i = 1; i <= 7; i ++)
        {
            answer *= 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task

        // code here
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        for (int i = 1; i<=6; i++)
        {
            Console.Write(5 + " ");
        }
    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double a = 1;
        for (int i = 0; i <=10; i++)
        {
            answer += a;
            a /= x;
        }
        if (Double.IsInfinity(answer))
        {
            answer = 0;
        }
        else
        {
            answer = Math.Round(answer, 2);
        }
        
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
        else if (x <= 1)
        {
            answer = x * (-1);
        }
        else
        {
            answer = -1;
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task

        // code here
        int old = 1;
        int ne = 1;
        int prom = 0;
        Console.Write(old + " " + ne + " ");
        for (int i = 3; i<=8; i++)
        {
            prom = ne;
            ne = ne + old;
            old = prom;
            Console.Write(ne + " ");
        }
    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        int f1 = 1;
        int f2 = 1, ch = 0, zn = 1, f3=0, f4=1;
        for (int i =1; i<=5; i++)
        {
            ch = f1+f2;
            f1 = f2; f2 = ch;
            zn = f3 + f4;
            f3 = f4; f4 = zn;
            
        }
        answer = ch*1.0 / zn;
        answer = Math.Round(answer, 1);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double yach = 1;
        double prom = 0;
        for (int i = 1; i <=64; i++)
        {
            
            prom =prom+ yach/15;
            yach =yach* 2;
        }
        while (prom > 10)
        {
            power += 1;
            prom /= 10;
        }
        answer = Math.Round(prom, 2);

        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        int r = 6350;
        answer = Math.Sqrt((r+x) * (r+x) - r*r);
        answer= Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int nach = 10;
        int times = x / 3;
        for (int i = 1; i <=times; i++)
        {
            nach *= 2;
        }
        answer = nach;
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
        int p = 1, n=1;
        while (p <= l)
        {
            n += 3;
            p *= n;
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
        double eps = 0.0001;
        double ch = 1;
        answer += ch;
        if (Math.Abs(x) < 1)
        {
            while (ch * x * x >= eps)
            {
                ch = ch * x * x;
                answer += ch;
            }
            answer = Math.Round(answer, 2);
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
        int nach = 10;
        while (nach < 100000)
        {
            nach *= 2;
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

        // code here;
        double nach = 10000;
        while (nach < 20000)
        {
            nach *= 1.08;
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
        int answer = 0;

        // code here;
        answer = 2;
        double ans1 = 1, ans2=0;
        double f1 = 1;
        double f2 = 1, ch = 0, zn = 1, f3 = 0, f4 = 1;
        ch = f1 + f2;
        f1 = f2; f2 = ch;
        zn = f3 + f4;
        f3 = f4; f4 = zn;

        ans2 = ch / zn;
        while (Math.Abs(ans2-ans1)>0.001)
        {
            ans1 = ans2;
            ch = f1 + f2;
            f1 = f2; f2 = ch;
            zn = f3 + f4;
            f3 = f4; f4 = zn;

            ans2 = ch / zn;
            answer += 1;
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
        y = Math.Pow(Math.E, 2 * x);
        int i = 1;
        double ch = 1;
        while (ch >= 0.0001)
        {
            S += ch;
            ch = ch * 2 * x / i;
            y = Math.Pow(Math.E, 2 * x);
            i += 1;
        }
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);
        Console.WriteLine($"x={x}  y={y}   s={S}");

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