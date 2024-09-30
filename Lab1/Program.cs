using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

        //program.Task_1_1();
        //program.Task_1_2();
        //program.Task_1_3();
        program.Task_1_4(0);
        //program.Task_1_5(0, 2);
        //program.Task_1_6(4);
        //program.Task_1_7();
        program.Task_1_8();
        program.Task_1_9();
        //program.Task_1_10();
        program.Task_1_11();
        //program.Task_1_12(0.9);
        //program.Task_1_13(-1.5);
        //program.Task_1_14();
        //program.Task_1_15();
        //program.Task_1_16();
        //program.Task_1_17(1000);
        //program.Task_1_18(24);
        //program.Task_2_1(0);
        program.Task_2_2();
        //program.Task_2_3(8, 2, 0);
        program.Task_2_4(0.8);
        //program.Task_2_5(11, 5);
        program.Task_2_6();
        //program.Task_2_7a();
        //program.Task_2_7b();
        //program.Task_2_7c();
        program.Task_2_8();
        //program.Task_2_9();
        program.Task_2_10();
        //program.Task_3_1(0.1);
        //program.Task_3_2(0.1);
        //program.Task_3_3(0.1);
        program.Task_3_4(0.1);
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
        int i = 2;

        while (i <= 35)
        {
            answer = answer + i;
            i = i + 3;
        }
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;
        for (int i = 1; i <= 10; i++)
            answer = answer + 1.0 / i;
        Console.WriteLine("{0:f2}", answer);
        answer = Math.Round(answer, 2);
        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;
        for (int i = 2; i <= 112; i += 2)
        {
            double b = i + 1;
            answer = answer + i / b;
            
        }
        Console.WriteLine("{0:f2}", answer);
        answer = Math.Round(answer, 2);

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        double a = (Math.Cos(1 * x));
        double b = 1;
        answer += a / b;
        for (int i = 2; i <= 9; i++)
        {
            if (b != 0)
            {
                
                a = (Math.Cos(i * x));
                b *= x;
                answer += a / b;

            }
            else
                return 0;
            
        
        }
        Console.WriteLine("------");
        Console.WriteLine("{0:f2}", answer);
        Console.WriteLine("------");
        answer = Math.Round(answer, 2);

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        for (int i = 0; i < 10; i++)
        {
            answer += (p + i * h) * (p + i * h);
        
        }
        Console.WriteLine("{0:f2}", answer);
        answer = Math.Round(answer, 2);
        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        answer = 0.5 * x * x - 7 * x;

        answer = Math.Round(answer, 2);
        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        for (int i = 1; i <= 6; i++)
            answer *= i;

        Console.WriteLine("{0:f2}", answer);
        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;
        int f = 1;
        for (int i = 1; i <= 6; i++)
        {
            f *= i;
            answer += f;
            
        }
        Console.WriteLine( answer);
        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        double ch = -5, zn = 1;
        double s = ch / zn;
        for (int i = 2; i <= 6; i++)
        {
            ch *= -5;
            zn *= i;
            s += ch / zn;
            Console.WriteLine($"{ch}/{zn} = {ch / zn}");
        
        }
        //double f = 1;
        //for (int i = 1; i <= 6; i++)
        //{
        //f *= i;
        //int a = -1;
        //int b = 5;
        //for (int j = 1; j < i; j++)
        //{
        //a *= -1;
        //b *= 5;

        //}
        //answer += (a * b) / f;


        //}
        answer = s;
        Console.WriteLine("--->");
        Console.WriteLine("{0:f2}", answer);
        answer = Math.Round(answer, 2);
        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;
        for (int i = 0; i < 7; i++)
            answer *= 3;

        Console.WriteLine(answer);
        return answer;
    }
    public void Task_1_11()
    {
        int x = 5;
        for (int i = 1; i <= 6; i++)
        {
            Console.Write("{0} ", i);
            
        }
        Console.Write("\n");
        for (int i = 1; i <= 6; i++)
            Console.Write("{0} ", x);
        Console.Write("\n");
    }
    public double Task_1_12(double x)
    {
        double answer = 1;
        double t = 1;
        if (x == 0)
            return 0;
        for (int i = 1; i <= 10; i++)
        {
            t *= x;
            answer += 1 / t;

        
        }
        
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        if (x <= -1)
            return 1;
        else if ((-1 < x) && (x <= 1))
            return -x;
        else
            return -1;


        
    }
    public void Task_1_14()
    {
        int a = 1, b = 1;
        Console.Write(a);
        Console.Write(" ");
        Console.Write(b);
        Console.Write(" ");
        int c = 0;
        b = a + b;
        c = b;
        for (int i = 0; i < 6; i++)
        {
            b = c;
            Console.Write(b);
            Console.Write(" ");
            c = a + b;
            a = b;
        }
        Console.Write("\n");
    }
    public double Task_1_15()
    {
        
        int a = 1, b = 1;
        int c = 0;
        c = b;
        for (int i = 0; i < 4; i++)
        {
            b = c;
            Console.Write(b);
            Console.Write("/");
            Console.Write(a);
            Console.Write(" ");
            c = a + b;
            a = b;
        }
        double answer = c;
        answer = answer / a;
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        Console.WriteLine("\n");
        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        double z = 1;
        int power = 0;
        for (int i = 0; i < 64; i++)
        {
            z = 1;
            for (int j = 0; j < i; j++)
                z *= 2;
            answer += z;

        }
        answer = answer / 15;
        double zz = answer;
        while (answer > 10)
        {
            answer /= 10;
            power++;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        Console.WriteLine(power);
        return (answer, power);

    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        int r = 6350;
        double gip = r + x;
        answer = Math.Sqrt((r + x) * (r + x) - r * r);
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;
        for (int i = 0; i < x; i += 3)
        {
            answer *= 2;
        
        }
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
        int l = 1, i = 1;
        int n = i;
        while (l < 30000)
        {
            n = i;
            i += 3;
            l *= i;
            
            Console.Write(l);
            Console.Write(" ");
            Console.Write(i);
            Console.Write("\n");


        }
        answer = n;
        Console.WriteLine(answer);
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
        double n = 1;
        double e = 0.0001;
        if (Math.Abs(x) < 1)
        {


            while (n >= e)
            {
                answer += n;
                n *= (x * x);
                
            }
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
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
        int amebu = 10; 
        while (amebu < 100000)
        {
            answer += 3;
            amebu *= 2;
        }
        Console.WriteLine(answer);

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
        double s2 = 2 * s;
        while (s < s2)
        {
            answer++;
            s *= 1.08;
        
        }
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
        double z1 = 1, z2 = 1;
        double z = z1 + z2;
        double c1 = 1, c2 = 2;
        double c = c1 + c2;
        double e1 = c / z;
        double e2 = c2 / z2;
        int n = 2;
        while (Math.Abs(e1 - e2) > 0.001)
        { 
            z = z1 + z2;
            z1 = z2;
            z2 = z;
            c = c1 + c2;
            c1 = c2;
            c2 = c;
            e1 = e2;
            e2 = c / z2;
            n++;
            Console.WriteLine($"{n}:{e1} - {e2} = {e1 - e2}");

        
        }
        answer = n;
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
        Console.WriteLine("------");
        double S = 0, y = 0;
        double ch1 = 1;
        double ch2 = 1;
        double zn = 1;
        double chl = (ch1*ch2)/zn;
        S += chl;
        int i = 0;
        while (Math.Abs(chl) >= 0.0001)
        {
            Console.WriteLine($"{i}:{ch1*ch2}/{zn} = {chl}");
            i++;
            ch1 = (2 * i + 1);
            ch2 *= (x * x);
            zn *= i;
            chl = ch1*ch2 / zn;
            if (Math.Abs(chl) >= 0.0001) S += chl;
            y = (1 + 2 * x * x) * Math.Exp(x*x);

        }
        Console.WriteLine(S);
        Console.WriteLine(y);

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
