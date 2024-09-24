using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Numerics;
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
        //program.Task_2_1(1.6);
        //program.Task_2_2();
        //program.Task_2_3(0.2, -1.9, 12);
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
        program.Task_3_3(0.1);
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
        int s = 0;
        for (int i = 2; i <= 35; i = i + 3) 
        {
            s = s + i;
        }
        answer = s;
        //Console.WriteLine(answer);
        // end

        return answer;
        
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        double s = 0;
        for (double i = 1; i <= 10.0; i++)
        {
            s = s + 1.0 / i;
        }
        // end
        answer = Math.Round(s,2);
        //Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        double s = 0;
        double j = 3;
        double i = 2;
        for (; i <= 112; )
        {
            s = s + i/j;
            i = i + 2;
            j = j + 2;
        }
        answer = Math.Round(s);
        //Console.WriteLine(answer);
        return answer;
        // end
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double s = 0;
        double k = 1;
        double m = 1;
        for (;k<=9;k++)

        {   if (x == 0)
                return 0;
            s = s + Math.Cos(k * x)/m;
            m *= x;

        }
        // end
        answer = Math.Round(s,2);
        //Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        double s = 0;
        double k = 0;
        for (; k <= 9;) 
        {
            s = s + (p + k * h) * (p + k * h);
            k = k + 1;
        }
        answer = Math.Round(s,2);
        // end
        //Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        double y = 0.5 * x * x - 7 * x;
        for (; x>=-4 && x <= 4; x = x + 0.5)
        {
            answer=Math.Round(y,2);
        }
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        double s = 1;
        double x = 1;
        for (; x <= 6; x = x + 1)
        {
            s = s * x;
        }
        // end
        answer = (int)s;
        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        double s = 0;
        double f = 1;
        for(double x = 1; x<=6; x++)
        {
            f *= x;
            s += f;
        }
        answer = (int)s;
        // end
        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double s = 0;
        double f = 1;
        double x = (-1)*5;
        double m = x;

        for (double v = 1; v<=6; v++)
        {
            f *= v;
            s += m / f;
            m *= x;
            
        }
        // end
        answer = Math.Round(s,2);
        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        double x = 3;
        double s = 1;

        for (double y=1; y<=7; y++) 
        {
            s *= x;
        }
        // end
        answer = (int)s;
        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task

        for (double x = 1; x <= 6; x++)
        {
            Console.Write(x);
            Console.Write(" ");
        }

        Console.WriteLine("");

        double y = 5;
        for (double k = 1; k <= 6; k++)
        {
            Console.Write(y);
            Console.Write(" ");
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double s = 1;
        double y = x;
        for (double k = 1; k<=10; k++)
        {
            if (x == 0)
                return 0;
            s += 1 / y;
            y *= x;
        }
        // end
        answer = Math.Round(s, 2);
        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        for (; x >= -1.5 && x <= 1.5; x += 0.1)
        {
            if (x <= -1)
                return 1;
            if (x > -1 && x <= 1)
                return -x;
            if (x > 1)
                return -1;
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        double x = 1;
        double x1 = 1;
        double s = 0;
        for (double k = 1; k <= 8; k++)
        { 
            Console.WriteLine(x);
            s = x + x1;
            x = x1;
            x1 = s;     
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double ch = 1;
        double zn = 1;
        double ch1 = 1;
        double zn1 = 1;
        double s = 1;
        double s1 = 1;
        double d = 1;
        

        for (double k = 1; k <= 4; k++)
        {
            s = ch1+ ch;
            ch1 = ch;
            ch = s;
            d = s / s1;
            s1 = zn1+zn;
            zn1 = zn;
            zn = s1;
        }
        // end
        answer = d;
            return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double s = 1;
        double x = 1;
        for (double k = 1; k <= 63; k++) 
        {
            x *= 2;
            s += x;
        }
        s /= 15;
        while (s > 10) 
        {
            s/=10;
            power++;
        }
        answer = Math.Round(s,2);
        
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double d = 0;
        double R = 6350;
        d = ((x + R) * (x + R)) - (R * R);
        d = Math.Sqrt(d);
        // end
        answer = Math.Round(d,2);
        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int a = 2;
        int s = 1;

        for (double k = x / 3; k != 0; k -= 1) 
        {
            s *= a;
        }
        
        // end
        answer = s*10;
        Console.WriteLine(answer);
        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here
        
        double n = 1;
        double s = 0;

        while (Math.Abs((Math.Cos(n * x))/(n*n))>=0.0001) 
        {
            s += Math.Cos(n * x) / (n * n);
            n++;
            
        }

        // end
        answer = s;
        Console.WriteLine(answer);
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
        double s = a;
        double n = 1;
        int k = 0;
        while (s <= p) 
        {
            if (p == 0 || a+n*h<=0)
                return 0;
            
            k++;
            s += (a + n * h);
            n++;
            
        }
        // end
        answer = k;
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
        while (N - M >= 0 && M!=0) 
        {
            quotient++;
            remainder = N - M;
            N = N - M;
            
        }
        if (M == 0)
            return (0, 0);
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
        double d1 = 10;
        double distance = 10;
        double day = 2;
        while (day <= 7)
        {
            d1 = d1 * 1.1;
            distance += d1;
            day++;
        }
        // end
        answer = Math.Round(distance, 2);
        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double s = 100;
        double day = 0;
        double distance = 10;
        while (s >= 0) 
        {
            s -= distance;
            distance *= 1.1;
            day++;
        }
        // end
        answer = (int)day;
        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double day = 0;
        double distance = 10;
        while (distance <= 20)
        {
            distance *= 1.1;
            day++;
        }
        // end
        answer = (int)day;
        return answer;
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
        double d_a = 0.0000000001;
        double l = 0.1;
        int k = 0;

        while (l >= d_a)
        {
            l /= 2;
            k++;
        }
        // end
        
        answer = k;
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
        double E = 0.0001;
        double a = 0.1;
        double b = 1;
       

        for (double h = 0.1; x >= a && x <= b ; x += h) 
        {
            S = 1;
            double i = 1;
            double f = 1;
            double s = 0;
            while (true)
            {
                s += Math.Cos(i * x) / f;
                i++;
                f *= i;
                if (Math.Abs(Math.Cos(i * x) / f) < E)
                    break;
            }
            S = S + s;
            y = Math.Exp(Math.Cos(x)) * Math.Cos(Math.Sin(x));

        }
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
