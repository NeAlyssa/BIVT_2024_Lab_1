using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
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
        //program.Task_3_4(0.1);
        //program.Task_3_5(double.Pi/5);
        //program.Task_3_6(0.1);
        //program.Task_3_7(0.1);
        program.Task_3_8(0.1);
        //program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;

        // code here
        for (int i = 2; i <= 35; i += 3) {
            answer += i;
        }
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (int i = 1; i <= 10; i++) {
            answer += 1.0 / i;
        }
        // end

        return Math.Round(answer,2);
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (int i = 3; i<=113; i+=2) {
            answer += (double)(i-1) / i;
        }
        // end 

        return Math.Round(answer, 2);
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if (x == 0) return 0;
        answer = Math.Cos(x);
        for (int i = 2; i <= 9; i++) {
            answer += Math.Cos(i * x) / Math.Pow(x, i - 1);
        }
        // end

        return Math.Round(answer,2);
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i = 0; i < 10; i++) {
            answer += (p + i * h) * (p + i * h);
        }
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        return Math.Round(0.5 * x * x - 7 * x, 2);
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        answer = 1;
        for (int i = 1; i <= 6; i++) {
            answer *= i;
        }
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int factorial = 1;
        for (int i = 1; i <= 6; i++) {
            factorial *= i;
            answer += factorial;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        int factorial = 1;
        for (int i = 1; i <= 6; i++) {
            factorial *= i;
            answer += Math.Pow(-1, i) * Math.Pow(5, i) / factorial;
        }
        // end

        return Math.Round(answer,2);
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        answer = 1;
        for (int i = 0; i < 7; i++) {
            answer *= 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i <= 6; i++) {
            Console.Write(i + " ");
        }
        Console.Write("\n");
        for (int i = 0; i < 6; i++) {
            Console.Write(5 + " ");
        }
        Console.Write("\n");
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x == 0) return 0;
        answer = 1;
        for (int i = 1; i <= 10; i++) {
            answer += 1.0 / Math.Pow(x, i);
        }
        // end

        return Math.Round(answer,2);
    }
    public double Task_1_13(double x)
    {
        // code here
        if (x <= -1) {
            return 1;
        } else if (x <= 1) {
            return -x;
        } else {
            return -1;
        }
        // end
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a = 1, b = 1;
        Console.Write($"{a} {b} ");
        for (int i = 3; i <= 8; i++) {
            int next = a + b;
            Console.Write($"{next} ");
            a = b;
            b = next;
        }
        // code here

    }
    public double Task_1_15()
    {
        // code here
        int n1 = 1, d1 = 1, n2 = 2, d2 = 1;
        for (int i = 3; i <= 5; i++) {
            int nextN = n1 + n2;
            int nextD = d1 + d2;
            n1 = n2;
            d1 = d2;
            n2 = nextN;
            d2 = nextD;
        }
        double answer = (double)n2 / d2;
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double start = 1 / 15.0;
        for (int i = 0; i < 64; i++) {
            answer += start;
            start *= 2;
        }
        power = (int)Math.Log10(answer);
        answer /= Math.Pow(10, power);
        answer = Math.Round(answer, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        // code here
        const double R = 6350;
        double answer = Math.Sqrt(x * (2 * R + x));
        return Math.Round(answer,2);
        // end
    }
    public int Task_1_18(int x)
    {
        // code here
        int cells = 10;
        for (int hours = 3; hours <= x; hours += 3) {
            cells *= 2;
        }
        return cells;
        // end
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
        // code here
        int L = 30000;
        int p = 1;
        int n = 1;

        while (true) {
            n += 3;
            int p_candidate = p * n;

            if (p_candidate > L)
            {
                n -= 3;
                break;
            }

            p = p_candidate;
        }

        return n;
        // end
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
        double e = 0.0001;
        double s = 1.0;
        if (Math.Abs(x) >= 1) {
            return 0.0;
        }

        double term = x * x;
        while (Math.Abs(term) >= e) {
            s += term;
            term *= x * x;
        }
        return Math.Round(s, 2);
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
        int target = 100000;

        while (true) {
            answer += 3;
            int cells = Task_1_18(answer);

            if (cells >= target)
            {
                break;
            }
        }

        return answer;
        // end
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
        double amount = 10000;
        double target = 20000;
        double rate = 0.08;

        while (amount < target) {
            amount += amount * rate;
            answer++;
        }

        return answer;
        // end
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
        int n1 = 1, d1 = 1;
        int n2 = 2, d2 = 1;
        double prevTerm = (double)n1 / d1;
        double currentTerm = (double)n2 / d2;
        int index = 2;

        while (Math.Abs(currentTerm - prevTerm) > 0.001) {
            int nextN = n1 + n2;
            int nextD = d1 + d2;

            n1 = n2;
            d1 = d2;
            n2 = nextN;
            d2 = nextD;

            prevTerm = currentTerm;
            currentTerm = (double)n2 / d2;

            index++;
        }
        return index;
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
        double e = 0.0001;
        double s = 0;
        double term = 1;
        int i = 0;
        double factorial = 1;
        s += term;
        while (Math.Abs(term) >= e) {
            i++;
            factorial *= i;
            term = Math.Pow(2 * x, i) / factorial;
            s += term;
        }
        double y = Math.Exp(2 * x);
        return (Math.Round(s, 2), Math.Round(y, 2));
        //return (S, y);
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
