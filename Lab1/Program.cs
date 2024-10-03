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
        program.Task_1_9();
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
        for (int i = 2; i <= 35; i += 3)
        { answer += i; }
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (int i = 1; i <= 10; i += 1)
        { answer += (1.0 / i); }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (int i = 2; i <= 112; i += 2)
        { answer += (i / (i + 1.0)); }
        answer = Math.Round(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if (x == 0) return 0;
        double px = 1;
        for (int i = 1; i <= 9; i++)
        {
            answer += Math.Cos(i * x) / px;
            px *= x;
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
        { answer += (p + i * h) * (p + i * h); }
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
        for (int i = 1; i <= 6; i++)
        { answer *= i; }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 1;

        // code here;
        int cf = 1;
        for (int i = 2; i <= 6; i++)
        {
            cf *= i;
            answer += cf;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        double p1 = 1.0;
        double p5 = 1.0;
        double ft = 1.0;

        // code here;
        for (int i = 1; i <= 6; i++)
        {
            p1 *= -1.0;
            p5 *= 5.0;
            ft *= i;
            answer += p1 * p5 / ft;
            Console.WriteLine(p1 * p5 / ft);
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        for (int i = 1; i <= 7; i++)
        { answer *= 3; }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        Console.WriteLine("а) 1 2 3 4 5 6,");
        Console.WriteLine("б) 5 5 5 5 5 5.");
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x == 0) return 0;
        double px = 1;
        for (int i = 0; i <= 10; i++)
        {
            answer += 1.0 / px;
            px *= x;
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
        int p1 = 1;
        int p2 = 1;
        int current = 0;
        Console.WriteLine(p2);
        for (int i = 0; i <= 6; i++)
        {
            Console.WriteLine(p1);
            current = p1 + p2;
            p2 = p1;
            p1 = current;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        float pc1 = 2;
        float pc2 = 1;
        float cc = 0;
        float pz1 = 1;
        float pz2 = 1;
        float cz = 0;
        for (int i = 0; i <= 2; i++)
        {
            cc = pc1 + pc2;
            pc2 = pc1;
            pc1 = cc;
            cz = pz1 + pz2;
            pz2 = pz1;
            pz1 = cz;
        }
        answer = Math.Round(cc / cz, 2);
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
        double pp = 1;
        for (int i = 0; i < power; i++)
        {
            pp *= 10;
        }
        answer = Math.Round(answer / pp, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        int r = 6350;
        answer = Math.Round(Math.Sqrt((r + x) * (r + x) - r * r), 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here
        for (int i = 1; i <= x / 3; i++)
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

        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 1;
        // code here
        int x = 1;
        for (int n = 1; x * n < 30000; n += 3)
        {
            x *= n;
            answer = n;
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
        if (x <= -1 || x >= 1) return 0;


        int i = 0;
        double a = 1;
        while (Math.Abs(a) >= 0.0001)
        {
            answer += a;
            a *= x * x;
            i++;
        }
        answer = Math.Round(answer, 2);

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
        int x = 10;
        // code here
        while (x < 100000)
        {
            x = x * 2;
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
        double x = 10000;
        double p = 0.08;
        double current = x;

        // code here;
        int answer = 0;
        while (current < x * 2)
        {
            current += current * p;
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
        int answer = 2;
        double ch1 = 1, zn1 = 1, ch2 = 2, zn2 = 1;

        // code here;
        while (Math.Abs(ch2 / zn2 - ch1 / zn1) >= 0.001)
        {
            double ch3 = ch2;
            double zn3 = zn2;
            zn2 += zn1;
            ch2 += ch1;
            zn1 = zn3;
            ch1 = ch3;
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
        double powX = 1;
        double res;
        for (int i = 1; ; i++)
        {
            powX *= x;
            res = powX * Math.Sin(i * Math.PI / 4);
            if (powX < 0.0001) break;
            S += res;
        }
        y = (x * Math.Sin(Math.PI / 4)) / (1 - 2 * x * Math.Cos(Math.PI / 4) + x * x);
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