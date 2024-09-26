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
        //program.Task_1_6(-3.5);
        //program.Task_1_7();
        //program.Task_1_8();
        //program.Task_1_9();
        //program.Task_1_10();
        program.Task_1_11();
        //program.Task_1_12(0.9);
        //program.Task_1_13(-1.5);
        //program.Task_1_14();
        //program.Task_1_15();
        program.Task_1_16();
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
        //program.Task_3_1(1);
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
        for(int i = 2; i <= 35; i += 3)
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
        for (int i = 1; i <= 10; i++)
        {
            answer += 1.0/i;
        }
        answer = Math.Round(answer, 2);
        // end
        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (float i = 2; i <= 112; i += 2)
        {
            answer += i / (i + 1);
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        // code here
        if (x == 0) return 0;
        for (int i = 1; i <= 9; i++)
        {
            double powX = 1;
            for (int j = 1; j < i; j++)
            {
                powX *= x;
            }
            answer += Math.Cos(i*x) / powX;
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
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = Math.Round(0.5 * x * x - 7 * x, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for (int i = 2; i <= 6; i++)
        {
            answer *= i;
        }
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 1;

        // code here;
        for (int i = 2; i <= 6; i++)
        {
            int currentResult = 1;
            for (int j = 2; j <= i; j++)
            {
                currentResult *= j;
            }
            answer += currentResult;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        for (int i = 1; i <= 6; i++)
        {
            int pow1 = 1;
            float pow5 = 1;
            int factorialI = 1;
            for (int j = 1; j <= i; j++)
            {
                pow1 *= -1;
                pow5 *= 5;
                factorialI *= j;
            }
            answer += pow1 * pow5 / factorialI;
        }
        answer = Math.Round(answer, 2);
        // end

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
        for (int i = 1; i <= 6; i++) Console.Write($"{i} ");
        Console.WriteLine();
        for (int i = 1; i <= 6; i++) Console.Write("5 ");
        Console.WriteLine();
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x == 0) return 0;
        for (int i = 0; i <= 10; i++)
        {
            double powX = 1;
            for (int j = 1; j <= i; j++)
            {
                powX *= x;
            }
            answer += 1.0 / powX;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) answer = 1;
        else if (-1 < x && x <= 1) answer = -x;
        else answer = -1;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int pred1 = 1;
        int pred2 = 1;
        int current = 0;
        Console.WriteLine(pred2);
        for (int i = 0; i <= 6; i++)
        {
            Console.WriteLine(pred1);
            current = pred1 + pred2;
            pred2 = pred1;
            pred1 = current;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        float predChisl1 = 2;
        float predChisl2 = 1;
        float currentChisl = 0;
        float predZnam1 = 1;
        float predZnam2 = 1;
        float currentZnam = 0;
        for (int i = 0; i <= 2; i++)
        {
            currentChisl = predChisl1 + predChisl2;
            predChisl2 = predChisl1;
            predChisl1 = currentChisl;
            currentZnam = predZnam1 + predZnam2;
            predZnam2 = predZnam1;
            predZnam1 = currentZnam;
        }
        answer = Math.Round(currentChisl / currentZnam, 2);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 1;
        int power = 0;

        // code here
        for (int i = 0; i < 64; i++)
        {
            answer *= 2;
        }
        answer /= 15;
        power = (int)Math.Log10(answer);
        double powerPow = 1;
        for (int i = 0; i < power; i++)
        {
            powerPow *= 10;
        }
        answer = Math.Round(answer / powerPow, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        int r = 6350;
        answer = Math.Round(Math.Sqrt((r + x) * (r + x) - r*r), 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here
        for (int i = 1; i <= x/3; i++)
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
        double current = Math.Cos(x);
        const double E = 0.0001;
        for (int i = 2; Math.Abs(current) >= E; i++)
        {
            answer += current;
            current = Math.Cos(i * x) / (i * i);
        }
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
        int i = 0;
        double s = 0;
        if (h < 0)
        {
            return 0;
        }
        while (s <= p)
        {
            s += a + i * h;
            i++;
        }
        answer = i - 1;
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
        int quotient = 0, remainder = N;

        // code here
        if (M == 0) return (0, 0);

        while (remainder >= M)
        {
            quotient++;
            remainder -= M;
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

        double a = 10;
        answer = a;
        for (int i = 2; i <= 7; i++)
        {
            a *= 1.1;
            answer += a;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 1;

        // code here
        double a = 10;
        double s = a;

        while (s < 100)
        {
            a *= 1.1;
            s += a;
            answer++;
        }
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double a = 10;
        while (a <= 20)
        {
            a *= 1.1;
            answer++;
        }
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
        double a = 0.1;
        for (int i = 2; i <= 10; i++)
        {
            a *= 0.1;
        }
        while (l > a)
        {
            answer++;
            l /= 2;
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
        for (int i = 0; ; i++)
        {
            double chisl = 1;
            double znam = 1;
            int k = 1;
            if (i % 2 == 1) k = -1;
            for (int j = 1; j <= 2*i; j++)
            {
                chisl *= x;
                znam *= j;
            }
            double res = k * chisl / znam;
            if (Math.Abs(res) < 0.0001) break;
            S += res;
        }
        y = Math.Cos(x);
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