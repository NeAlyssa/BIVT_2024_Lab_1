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

        for (int i = 2; i <= 35; i = i + 3)
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

        for (double i = 1; i <= 10; i++)
        {
            answer = answer + (1 / i);
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2; i <= 112; i = i + 2)
        {
            answer = answer + (i / (i + 1));
        }
        answer = Math.Round(answer);

        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double n = 1;

        if (x != 0)
        {
            for (double i = 1; i <= 9; i++)
            {
                answer += (Math.Cos((i) * x)) / n;
                n = n * x;
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

        for (double i = 0; i < 10; i++)
        {
            answer = answer + (p + i * h) * (p + i * h);
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
        int answer = 0;

        // code here
        answer++;
        for (int i = 1; i < 7; i++)
        {
            answer = answer * i;
        }

        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;

        int f = 1;
        for (int i = 1; i <= 6; ++i)
        {
            f = f * i;
            answer += f;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double pr = -1, n = 5, f = 1;
        for (double i = 1; i <= 6; i++)
        {
            f *= i;
            answer += (pr * n) / f;
            pr *= -1;
            n *= 5;
        }
        answer = Math.Round(answer, 2);

        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        answer = 3;
        for (int i = 2; i <= 7; ++i)
        {
            answer *= 3;
        }

        // end

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
        double n = 1;
        for (double i = 0; i <= 10; i++)
        {
            if (x != 0)
            {
                answer += 1 / n;
                n *= x;
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
        else if (x > -1 && x <= 1)
        {
            answer = -x;
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
        int ch1 = 1;
        int ch2 = 1;
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(ch1);
            Console.WriteLine(ch2);
            ch1 = ch1 + ch2;
            ch2 = ch1 + ch2;
        }

     }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double ch1 = 1, zn1 = 1, ch2 = 2, zn2 = 1;
        for (int i = 0; i < 3; i++)
        {
            double tch = ch1 + ch2;
            double tzn = zn1 + zn2;
            answer = tch / tzn;
            ch1 = ch2;
            zn1 = zn2;
            ch2 = tch;
            zn2 = tzn;
        }
        answer = Math.Round(answer, 1);

        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double n = 1;
        double n1 = 1;
        for (int i = 0; i < 64; ++i)
        {
            if (answer > n1 * 10)
            {
                n1 *= 10;
                power += 1;
            }
            answer += n;
            n *= 2;
        }
        answer /= n1 * 15;
        answer = Math.Round(answer, 2);

        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here

        double R = 6350;
        answer = (R + x) * (R + x) - R * R;
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
        int i = 1;
        double ch = 1;
        do
        {
            ch = (Math.Cos(i * x)) / (i * i);
                answer += ch;

            i++;

        } while (Math.Abs(ch) >= 0.0001);
        answer = Math.Round(answer, 2);

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

        double s = a;
        if (h > 0)
        {
            while (s <= p)
            {
                answer++;
                s =s + a + answer * h;
                
            }
        }
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

        if (M != 0)
        {
            while (Math.Abs(N) >= Math.Abs(M))
            {
                quotient++;
                N = N - M;
            }
            remainder = Math.Abs(N);
        }

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

        double coef = 1;
        for (int i = 0; i < 7; ++i)
        {
            answer += coef * 10;
            coef *= 1.1;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here

        double coef = 1;
        double way = 0;
        while (way <= 100)
        {
            way += coef * 10;
            coef *= 1.1;
            answer++;

        }
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double coef = 1;
        double way = 0;
        while (way <= 20)
        {
            way = coef * 10;
            coef *= 1.1;
            answer++;

        }
        answer--;
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

        double len = 0.1;
        while (len > 1e-10)
        {
            len /= 2;
            answer += 1;
        }
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
        double a = Math.PI / 5, b = Math.PI, h = Math.PI/25, ch;
        int i = 1;
        
            
            while (true)
            {
                if (i % 2 == 0) ch = Math.Cos(i * x) / (i * i);
                else ch = -1 * Math.Cos(i * x) / (i * i);
                if (Math.Abs(ch) <= 0.0001) break;
                S = S + ch;
                i++;
                
            } 
            y = (x * x - Math.PI* Math.PI / 3) / 4;
       
        y = Math.Round(y, 2);
        S = Math.Round(S, 2);
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
