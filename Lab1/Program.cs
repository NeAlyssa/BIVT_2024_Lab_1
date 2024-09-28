using System.Collections.Generic;
using System.ComponentModel;
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
        for (int i = 2; i <= 35; i = i + 3)
            answer += i;
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;
        double i;
        // code here
        for (i = 1; i <= 10; i++)
            answer += 1 / i;
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;
        double i;
        // code here
        for (i = 2; i <= 112; i = i + 2)
        {
            answer += (i / (i + 1));
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        double i;
        // code here
        double k = 1;
        if (x != 0)
        {
            for (i = 1; i <= 9; i++)
            {
                answer += Math.Cos(i * x) / k;
                k *= x;
            }
            answer = Math.Round(answer, 2);
        }
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;
        int i;
        // code here
        for (i = 0; i <= 9; i++)
        {
            answer += (p + i * h) * (p + i * h);
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        {
            answer = 0.5 * x * x - 7 * x;
            answer = Math.Round(answer, 2);
        }

        // end

            return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;
        // code here
        answer = 1;
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
        int f  = 1; 
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
        double five = 1;
        double fact = 1;
        double one = 1;
        for (int i = 1; i <= 6; i++)
        {
            five *= 5;
            fact *= i;
            one *= -1;
            answer += (one * five) / fact;

        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;
        int i;
        int three = 1;
        // code here
        for (i = 0 ; i <= 6; i++ )
        {
            three *= 3;
            answer = three;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(i + " ");
        }
        for (int i = 1 ;i <= 6; i++) 
        {
            Console.Write(5 + " "); 
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;
        int i;
        double st = 1;
        // code here
        if (x != 0)
        {
            for (i = 0; i <= 10; i++)
            {
                answer += 1 / st;
                st *= x;
            }
        }   answer = Math.Round(answer, 2);
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
        if (x > -1 & x <= 1)
        {
            answer = -x;
        }
        if (x > 1)
        {
            answer = -1;
        }
    
        // end

        return answer;
    }
    public void Task_1_14()
    {
        int i;
        int sum = 0;
        int f1 = 1;
        int f2 = 1;
        Console.WriteLine(f1);
        Console.WriteLine(f2);
        // There is no test for this task
        for (i = 1; i <= 6; i ++)
        {
            sum = f1 + f2;
            Console.WriteLine(sum);
            f1 = f2;
            f2 = sum;
            
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;
        double n1 = 1, n2 = 1, sum = 0; 
        // code here
        for (int i = 1; i <= 5; i ++)
        {
            answer = n2 / n1;
            sum = n2;
            n2 = n1 + n2;
            n1 = sum;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;
        int i;
        double st = 1;
        // code here
        answer = 1;
        for (i = 1;i < 64; i++)
        {
            st = st * 2;
            answer += st;
        }
        answer /= 15;
        while ( answer >= 2)
        {
            power++;
            answer /= 10;
        }
        answer = Math.Round(answer, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        int r = 6350;
        int h;
        // code here
        for (h = 1; h <= x; h ++ )
        {
            answer = Math.Sqrt((r + h) * (r + h) - (r * r));
            answer = Math.Round(answer, 2);
        }
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;
        int i;
        int k = 10;
        // code here
        for (i = 3; i <= x; i += 3)
        {
            k = k * 2;
            answer = k;
  
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
        int mn = 1;
        int pr = 1;
        // code here
        while (pr < 30000)
        {
            mn += 3;
            pr *= mn;
            if (pr < 30000)
            {
                answer = mn;
            }
            else
            {
                break;
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
        double s = 1;
        double ch = x * x;
        // code here
        if (Math.Abs(x) < 1)
        {
            do
            {
                answer = s;
                s += ch;
                ch *= x * x;
            } while (ch > 0.0001);
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
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
        int time = 0;
        int kl = 10;
        // code here
        while (kl < 10 * 10 * 10 * 10 * 10)
        {
            time += 3;
            kl *= 2;
            answer = time;
            Console.WriteLine(answer);
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
        int sum = 10000;
        int pr;
        int time = 0;
        // code here;
        while (sum < 20000)
        {
            pr = (sum * 8) / 100;
            sum += pr;
            time += 1;
            answer = time;
            Console.WriteLine(answer);
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
        double ch1 = 0, ch2 = 1;
        double chisl = 1, znam = 1, s = 0;
        answer = 1;
        // code here
        while (Math.Abs(ch2 - ch1) > 0.001)
        {
            answer++;
            ch1 = ch2;
            s = znam;
            znam = chisl;
            chisl = chisl + s;    
            ch2 = chisl / znam;

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
        double i = 0;
        double n1 = 1;
        double n2 = 1;
        double d = 1;
        double part = n1 * n2 / d;
        while (Math.Abs(part) >= 0.0001)
        {
            S += part;
            i++;
            n1 *= -1;
            n2 *= x * x;
            d  *= (2 * i) * (2 * i - 1);
            part = n1 * n2 / d;
            y = Math.Cos(x);
        }
        
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