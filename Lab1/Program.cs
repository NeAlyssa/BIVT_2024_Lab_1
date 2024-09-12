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

        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here

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
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;

        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;

        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task

        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here

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

        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here

        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here

        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;
        double elem = 0;
        double i = 1;

        do
        {
            elem = Math.Cos(i * x) / Math.Pow(i, 2);
            if (Math.Abs(elem) < 0.0001) break;
            answer += elem;
            i++;
        } while (Math.Abs(elem) >= 0.0001);

        return Math.Round(answer, 2);
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

        if (h < 0 && p > 0) return answer;

        double s = 0;
        do
        {
            s += a + answer * h;
            if (s > p) break;
            answer++;
        }
        while (s <= p);

        return answer;
    }
    public double Task_2_4(double x)
    {
        double answer = 0;

        // code here

        // end

        return answer;
    }
    public (int, int) Task_2_5(int N, int M) // incorrect
    {
        int quotient = 0, remainder = 0;

        if (M == 0) return (quotient, remainder);
        while (N > M)
        {
            if (N - M < 0) break;
            N -= M;
            quotient++;
        }
        remainder = N;

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
        double curr = 10;

        for (int i = 0; i <= 6; i++)
        {
            answer += curr;
            curr *= 1.1;
        }

        return Math.Round(answer, 2);
    }
    public int Task_2_7b()
    {
        int answer = 0;

        double sum = 0;
        double curr = 10;

        do
        {
            sum += curr;
            answer++;
            if (sum >= 100) return answer;
            curr *= 1.1;
        } while (sum <= 100);

        return 0;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        double curr = 10;

        while (curr <= 20)
        {
            curr *= 1.1;
            answer++;
        }

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

        double len = 0.1;

        while (len > Math.Pow(10, -10))
        {
            len /= 2;
            answer++;
        }
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
        double S = 0, y = (Math.Pow(x, 2) - (Math.Pow(Math.PI, 2) / 3)) / 4;

        double elem = 0, i = 1;

        do
        {
            elem = Math.Pow(-1, i) * Math.Cos(i * x) / Math.Pow(i, 2);
            if (Math.Abs(elem) < 0.0001) break;
            S += elem;
            i++;
        } while (Math.Abs(elem) >= 0.0001);

        return (Math.Round(S, 2), Math.Round(y, 2));
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