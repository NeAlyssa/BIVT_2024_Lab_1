using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.IO.Pipes;
using System.Runtime.InteropServices;

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
        program.Task_1_6(-3.5);
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
        //program.Task_2_1(0);
        program.Task_2_2();
        //program.Task_2_3(8, 2, 0);
        program.Task_2_4(0);
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
        //program.Task_3_4(0.1);
        //program.Task_3_5(double.Pi/5);
        //program.Task_3_6(0.1);
        //program.Task_3_7(0.1);
        program.Task_3_8(0.3);
        program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;

        // code here
        for (int i = 2; i < 36; i += 3)
            answer += i;
        
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double i = 1.0; i < 11; i += 1.0)
            answer += 1 / i;

        answer = Math.Round(answer,2);
        
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (int i = 2; i <= 112; i+= 2)
        {
            answer += (i / (i + 1.0));
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if (x != 0.0)
        {
            double delitel = 1.0;
            for (int i = 1; i <= 9; i++)
            {
                answer += Math.Cos(i * x) / delitel;
                delitel *= x;
            }
            answer = Math.Round(answer, 2);

        }
        
            // end

            return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        double j = p;
        for (int i = 1; i <=10; i++)
        {
            answer += j*j;
            j += h;

        }
        answer = Math.Round(answer, 2);
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
        for (int i = 1; i <= 6; i++)
            answer *= i;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int faktorial = 1;
        for (int i= 1; i <= 6; i++)
        {
            faktorial *= i;
            answer += faktorial;
        }    
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double j = 1;
        for (int i = 1; i <= 6; i++)
        {
            j *= (-1) * 5.0 / i;
            answer += j;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int j = 1;
        for (int i = 1; i <= 7; i++)
            j *= 3;
        answer += j;
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i<=6;i++)
            Console.Write(i+" ");
        Console.WriteLine("\n");
        Console.WriteLine("5 5 5 5 5 5");
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x > 0)
        { 
            double del = 1;
            for (int i = 1; i <= 11; i++)
            {
                answer += 1 / del;
                del *= x;
            }
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
            answer = 1;
        else if (x > -1 && x <= 1)
            answer = -x;
        else
            answer = -1;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int i = 1;
        int j = 1;
        Console.WriteLine('1');
        Console.WriteLine('1');
        for (int k = 1; k <=6;k++)
        {
            int j1 = j;
            j = j + i;
            i = j1;
            Console.WriteLine(j);
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double i1 = 1;
        double i2 = 1;
        double j1 = 0;
        double j2 = 1;
        for (int k =1;k<=4;k++)
        {
            answer = (i1 + i2) / (j1 + j2);
            double q = i2;
            i2 += i1;
            i1 = q;
            q = j2;
            j2 += j1;
            j1 = q;
            
        }
        answer = Math.Round(answer,2);
        
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double h = (Math.Pow(2, 64) - 1)/15;
        while (h > 10)
        {
            power++;
            h /= 10;
        }
        answer = Math.Round(h,2);
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
        
        answer = Math.Round(Math.Sqrt( (r + x) * (r + x) - r * r), 2) ;

        // end
        
        return answer;
        
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int h = x / 3;
        answer = 10;
        for (int i = 1; i <= h; i++)
            answer *= 2;
        
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
        int n = -2;
        int l = 30000;
        int p = 1;
        do
        {
            n += 3;
            p *= n;
        }
        while (p < l);
        answer = n-3;
        
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
        if  (x < 1)
        {
            double s = 1;
            double q = 1;
            double e = 0.0001;
            while (q > e)
            {
                q *= x * x;
                s += q;
                
            }
            answer = Math.Round(s, 2);
            
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
        int count = 10;
        int time = 0;
        while (count < 10*10*10*10*10)
        {
            time += 3;
            count *= 2;
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
        int time = 0;
        double s = 10000;
        while (s < 20000)
        {
            time++;
            s *= 1.08;
        }
        answer = time;
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
        double i1 = 1;
        double i2 = 1;
        double j1 = 0;
        double j2 = 1;
        double g1 = 1;
        double g2 = 0;
        int number = 1;
        while (Math.Abs(g1-g2)>0.001)
        {
            g2 = g1;
            g1 = (i1 + i2) / (j1 + j2);
            double q = i2;
            i2 += i1;
            i1 = q;
            q = j2;
            j2 += j1;
            j1 = q;
            number++;
        }
        answer = number;
        
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
        
        double del = 1;
        double h = 1;
        double t = 0;
        int i = 0;
        do
        {
            t = h / del;
            S += t;
            i += 1;
            del *= i;
            h *= 2 * x;

        }
        while (Math.Abs(t) > 0.0001);
        y = Math.Pow(Math.E, 2*x);
        Console.WriteLine(S);
        Console.WriteLine(y);
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