using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;

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
        program.Task_1_6(4);
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
        // program.Task_2_1(0);
        // program.Task_2_2();
        // program.Task_2_3(8, 2, 0);
        // program.Task_2_4(0.8);
        // program.Task_2_5(11, 5);
        // program.Task_2_6();
        // program.Task_2_7a();
        // program.Task_2_7b();
        // program.Task_2_7c();
        // program.Task_2_8();
        // program.Task_2_9();
        // program.Task_2_10();
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
        for(int i = 2; i <= 35; i += 3) {
            answer += i;
        }
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for(double i = 1; i <= 10; ++i) {
            answer += 1 / i;
        }

        answer = Math.Round(answer, 3);

        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for(double i = 2; i <= 112; ++i) {
            answer += i / (i + 1);
        }

        answer = Math.Round(answer, 3);

        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if(x == 0) {
            return 0;
        }
        double x_pow = 1;
        for(int i = 1; i <= 9; ++i) {
            answer += Math.Cos(i * x) / x_pow;
            x_pow *= x;
        }
        answer = Math.Round(answer, 4);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for(int i = 0; i < 10; ++i) {
            answer += Math.Pow(p + i * h, 2);
        }
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * x * x - 7 * x;
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for(int i = 2; i <= 6; ++i) {
            answer *= i;
        }
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int fact = 1;
        for(int i = 1; i <= 6; ++i) {
            fact *= i;
            answer += fact;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double sign = -1, fact = 1, pows = 1;
        for(int i = 1; i <= 6; ++i) {
            fact *= i; 
            pows *= 5;
            answer += sign * pows / fact; 
            sign *= -1;
        }
        answer = Math.Round(answer, 4);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        for(int i = 0; i < 7; ++i) {
            answer *= 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        // code here
        for(int i = 1; i <= 6; ++i) {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        for(int i = 1; i <= 6; ++i) {
            Console.Write(5 + " ");
        }
        Console.WriteLine();
    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if(x == 0) {
            return 0;
        }
        double pows = 1;
        for(int i = 0; i <= 10; ++i) {
            answer += 1 / pows;
            pows *= x;
        }
        answer = Math.Round(answer, 4);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if(x <= -1) {
            answer = 1;
        } else if(x <= 1) {
            answer = -x;
        } else {
            answer = -1;
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task

        // code here
        int num_1 = 0;
        int num_2 = 1;
        for(int i = 0; i < 8; ++i) {
            Console.Write(num_2 + " ");
            int prev = num_2;
            num_2 = num_1 + num_2;
            num_1 = prev;
        }
        Console.WriteLine();
    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double num_1 = 0, num_2 = 1;
        for(int i = 0; i < 5; ++i) {
            double prev = num_2;
            num_2 = num_1 + num_2;
            num_1 = prev;
        }
        answer = num_2 / num_1;
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double seeds = 1;
        double pow = 1;
        for(int i = 0; i < 64; ++i) {
            pow *= 2;
            seeds += pow;
        }
        seeds /= 15;
        while(seeds >= 10) {
            ++power;
            seeds /= 10;
        }
        answer = Math.Round(seeds, 4);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        answer = Math.Sqrt(Math.Pow(6350 + x, 2) + 6350 * 6350);
        answer = Math.Round(answer, 4);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here
        int multiple = x / 3;
        for(int i = 1; i < multiple; ++i) {
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
        double eps = 0.0001;
        double j = 1, res = 0;
        do {
            res = Math.Cos(x * j) / j / j;
            answer += res;
            ++j;
        } while(Math.Abs(res) >= eps);
        answer = Math.Round(answer, 4);
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
        double sum = 0;
        if(h <= 0) {
            return 0;
        }
        while(sum + a + answer * h <= p) {
            sum += a + answer * h;
            ++answer;
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
        if(M == 0) {
            return (0, 0);
        }
        int N_abs = Math.Abs(N), M_abs = Math.Abs(M);
        while(N_abs - M_abs >= 0) {
            ++quotient;
            N_abs -= M_abs;
        }
        remainder = N_abs;
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
        double prev = 10;
        answer = 10;
        for(int i = 1; i < 7; ++i) {
            answer += prev * 1.1;
            prev *= 1.1; 
        }
        answer = Math.Round(answer, 4);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 1;

        // code here
        double rast = 10, prev = 10;
        while(rast < 100) {
            rast += prev * 1.1;
            prev *= 1.1;
            ++answer;
        }
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double prev = 10;
        while(prev <= 20) {
            prev *= 1.1;
            ++answer;
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
        double L = 0.1;
        while(L > 1e-10) {
            L /= 2;
            ++answer;
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
        double S = 1, y = 0;

        // code here
        double fact = 1;
        double i = 1;   
        while(Math.Abs(Math.Cos(i * x) / fact) >= 0.0001) {
            S += Math.Cos(i * x) / fact;
            ++i;
            fact *= i;
        }
        y = Math.Round(Math.Pow(Math.E, Math.Cos(x)) * Math.Cos(Math.Sin(x)), 3);
        S = Math.Round(S, 3);
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