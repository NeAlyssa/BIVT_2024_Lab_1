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

        //code here
        for (int i = 2; i<=35; i+=3)
        {
            answer += i;
        }
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        //code here
        for (double i = 1; i<= 10; i++)
        {
            answer += 1/i;
            
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        //code here
        for (double i = 2; i<=112; i+=2)
        {
            double i1 = (i + 1);
            answer += (i / i1);
            
        }
        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        //code here
        if (x == 0)
        {
            answer = 0;
        }
        else for (double a=1, i = 1; i<=9; i++)
        {
            answer += (Math.Cos(i * x) / a);
            a *= x;
            
        }
        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        //code here
        for (int i = 0; i<= 9; i++)
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

        //code here
        answer = 0.5 * x * x - 7 * x;

        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        //code here
        int factorial = 1;

        for (int i = 1; i<=6; i++)
        {
            factorial = factorial * i;
        }
        answer+= factorial;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here
        int factorial = 1;
        
        for (int i = 1; i <= 6; i++)
        {
            factorial *= i;
            answer+=factorial;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here
        double factorial = 1;

        double vir = 0;

        for (double a = 1, b=1, i = 1; i<=6;i++)
        {
            a *= -1;
            b *= 5;
            factorial *= i;
            vir = (a*b)/(factorial);
            answer+= vir;
            
        }
        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int num = 1;

        for (int i = 1;i<=7;i++)
        {
            num = num * 3;
        }
        answer = num;
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        Console.Write("а)");
        for (int i = 1; i<= 6; i++)
        {
            Console.Write(" " + i);
        }
        Console.Write(",");
        Console.WriteLine();
        Console.Write("б)");
        for (int i = 0; i < 6; i++)
        {
            Console.Write(" " + 5);
        }
        Console.Write(".");
    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        //code here
        double vir = 0;
        if (x==0)
        {
            answer = 0;
        }

        else for (double p = 1, i = 0; i<=10; i++)
        {
            vir = 1 / p;
            answer += vir;
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
        if (x <= -1)
        {
            answer = 1;

        }
        else if (-1 < x && x <= 1)
        {
            answer = -x;
        } 
        else if (x>1)
        {
            answer = -1;
        }

        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task

        for (int a = 0, b = 0, i = 1; i <= 8; i++)
        {
            int s;
            if (i == 1 || i == 2)
            {
                s = 1;
            }
            else
            {
                s = a + b;
            }
            Console.Write(s + " ");
            a = b;
            b = s;
        }

    }
    public double Task_1_15()
    {
        double answer = 0;
        double num1 = 1;
        double dem1 = 1;
        double num2 = 2;
        double dem2 = 1;

        // code here

        for (int i = 3; i <= 5; i++)
        {
            double cur_num = num1 + num2;
            double cur_dem = dem1 + dem2;
            num1 = num2;
            dem1 = dem2;
            num2 = cur_num;
            dem2 = cur_dem;
            answer = cur_num / cur_dem;
            
        }
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;
        int z = 1;
        // code here
        for (int i = 1; i <=64; i++)
        {

            z = 2 * z;
            

            if (z > 1000000000)
            {
                z = z / 10;
                power++;
            }


            Console.WriteLine(z);
        }
        answer = z / 15;
        while (answer > 10)
        {
            answer = answer / 10;
            power++;
        }
        answer = Math.Round(answer,2);
        // end

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
        int a = 10;
        for (int i = 3; i <= x; i+=3)
        {
            a *= 2;
            answer = a;
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
        int step = 3;
        int p = 1;
        int L = 30000;
        while (p * n <= L)
        {
            n += step;
            p *= n;
            answer = n;
            Console.WriteLine($"{n} {p}");
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
        double s = 1;
        double a = 1;
        if (Math.Abs(x) < 1)
        {
            while (a >= 0.0001)
            {
                a *= (x * x);
                s += a;
                answer = Math.Round(s,2);
            }
        }
        else
        {
            return answer = 0;
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
        int a = 10;
        while (a <= 100000)
        {
            a *= 2;
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
        double s = 10000;
        double s2 = 2*s;
        double percent = 1.08;
        while (s < s2)
        {
            s *= percent;
            answer++;
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
        double num1 = 1;
        double dem1 = 1;
        double num2 = 2;
        double dem2 = 1;
        double prev = num2 / dem2;
        double cur = prev;
        answer = 2;

        while (Math.Abs(cur - prev) > 0.001 || answer < 3)
        {
            prev = cur;

            double cur_num = num1 + num2;
            double cur_dem = dem1 + dem2;

            num1 = num2;
            dem1 = dem2;
            num2 = cur_num;
            dem2 = cur_dem;

            cur = cur_num / cur_dem;
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
        double st = x * x, factorial = 1, n = 1;
        S = 1;
        for (double i = 1; Math.Abs(n) > 0.0001; i++)
        {
            factorial *= i;
            n = (2 * i + 1) * st / factorial;
            S += n;
            st *= x * x;
        }
        double ex2 = 1;  
        double term = 1;  
        double power = x*x;  

        for (int i = 1; Math.Abs(term) > 0.0001; i++)
        {
            term *= power / i;  
            ex2 += term;     
        }

        y = (1 + 2 * x * x) * ex2;
        S = Math.Round(S, 2);
        y = Math.Round(y, 2);


        
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
