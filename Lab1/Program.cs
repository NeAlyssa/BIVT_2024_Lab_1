using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        Console.WriteLine("Hello world!");
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
        program.Task_1_16();
        //program.Task_1_17(10);
        //program.Task_1_18(24);
        //program.Task_2_1(1);
        //program.Task_2_2();
        //program.Task_2_3(0.2, -1.9, 12);
        //program.Task_2_4(0.8);
        //program.Task_2_5(8, 2);
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

        /*int a = 0;
        int i = 1;
        while (a < 35)
        {
            a = 2 + 3 * (i - 1);
            i++;
            answer = answer + a;
        }*/

        int n = 1;
        for (int i = 2; i<35;i += 3)
        {
            n++;
        }
        answer = ((2 + 35) * n) / 2;
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        double slagaemoe = 0;
        for (int i = 1; i <= 10; i++)
        {
            slagaemoe = 1.0 / i;
            answer += slagaemoe;
        }
        answer = Math.Round(answer, 2);
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
        //Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double p = 1;
        for (int i = 1; i <= 9; i++)
        {
            answer += Math.Cos(i * x) / p;
            p *= x;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i = 0; i <= 9; i++)
        {
            answer += (p + i * h) * (p + i * h);
        }
        //answer = Math.Round(answer);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
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
        int q=1;

        for (int i = 1; i <= 6; i++)
        {
            q *= i;
        }
        
        for(int i=6;i>=1;i--)
        {
            answer += q;
            q /= i;
        }
        // end
        
        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double n1 = -1;
        double n2 = 5;
        double d = 1;
        double part = n1 * n2 / d;
        answer += part;
        for (int i = 2; i <= 6; i++)
        {
            n1 *= -1;
            n2 *= 5;
            d = d * i;
            part= n1 * n2 / d;
            answer += part;
        }
        answer = Math.Round(answer,2);
        //end
        return answer;
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

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        Console.Write("a)");
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"{i} ");
        }
        Console.Write("6\n");

        Console.Write("б)");
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"5 ");
        }
        Console.Write(5);
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double p = 1;
        for (int i = 0; i <= 10; i++)
        {
            if (x == 0) break;
            answer += 1 / p;
            p *= x;
        }
        answer = Math.Round(answer, 2);
        // end
        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a = 1;
        int b = 1;
        for (int i = 1; i <= 4; i++)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
            a = a + b;
            b = a + b;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        int ch = 1;
        int zn = 1;
        int n = 1;
        int a = 1;
        int b = 1;
        for (int i = 1; i <= 5; i++)
        {
            n = ch / zn;
            ch = ch + zn;
            a = a + b;
            b = a + b;
        }

        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double part = 1;
        for (int i = 1; i <= 64; i++)
        {
            answer += part;
            //Console.WriteLine(i);
            //Console.WriteLine(answer);
            part *= 2;
        }
        answer /= 15;
        while (answer > 1)
        {
            answer /= 10;
            power++;
        }
        answer *= 10; power--;
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        Console.WriteLine(power);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double r = 6350;
        answer = Math.Sqrt(x * (2 * r + x));
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int cell = 10;
        int t=0;
        while (t < x)
        {
            cell *= 2;
            t += 3;
        }
        answer = cell;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here
        double part = 1;
        double i = 1;
        while (Math.Abs(part) >= 0.0001)
        {
            part = Math.Cos(i * x) / (i * i);
            i++;
            answer += part;

        } 
        answer -= part;
        //Console.WriteLine(answer);
        // end

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
        /*double s = 0;
        double slagaemoe = 0;
        
        while (s < p)
        {
            slagaemoe = a + answer * h;
            s += slagaemoe;
            //Console.WriteLine(s);
            answer++;
            
        }
        if (s > p) 
            { 
                answer--; 
            }
        //answer--;
        Console.WriteLine(answer);*/
        //Console.WriteLine(answer);        
        // end

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
        if (M==0) return (quotient, remainder);
        do
        {
            N = N - M;
            quotient++;
            remainder = N;

        } while (remainder >= M);
        // end
        //Console.WriteLine(quotient);
        //Console.WriteLine(remainder);
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
        double day = 0;
        double jog = 10;
        do
        {
            answer += jog;
            jog *= 1.1;
            day++;
        } while (day < 7);
        answer = Math.Round(answer, 2);
        //Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double jog = 10;
        double s = 0;
        while (s < 100)
        {
            s += jog;
            jog *= 1.1;
            answer++;

        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double jog = 10;
        while (jog < 20)
        {
            jog *= 1.1;
            answer++;
        } 
        Console.WriteLine(answer);
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
        double l = 0.1;
        double d = 1;
        //double d = Math.Pow(10, -10);
        for(int ii=1; ii <= 10; ii++)
        {
            d = d / 10;
            //Console.WriteLine(d);
        }

        while (l>=d)
        {
            l = l / 2;
            answer++;
        }
        //Console.WriteLine(answer);
        // end

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
        y = (x * x - Math.PI * Math.PI / 3) / 4;
        double i = 1;
        double n1 = -1;
        double n2 = Math.Cos(x);
        double d = 1;
        double part = n1 * n2 / d;
        while (Math.Abs(part) >= 0.0001)
        {
            S += part;
            i++;
            n1 *= -1;
            n2 = Math.Cos(i * x);
            d = i * i;
            part = n1 * n2 / d;
        }
        Console.WriteLine(S);
        Console.WriteLine(y);
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