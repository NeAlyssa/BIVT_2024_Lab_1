using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Formats.Asn1;
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
        //program.Task_2_1(1);
        //program.Task_2_2();
        //program.Task_2_3(0.2, -1.9, 12);
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
        for (int i = 1; i <= 10; ++i)
        {
            answer += 1.0 / i;
        }
         answer = Math.Round(answer, 3);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (int i = 2; i <= 112; i += 1)
        {
            answer += (double)i / (i + 1);
        }
        answer = Math.Round(answer, 3);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if (x == 0)
        {
            answer = 0;
        }
        else
        {
			double xpow = 1;
			for (int i = 1; i <= 9; ++i)
			{
				answer += Math.Cos(i * x) / xpow;
				xpow *= x;
			}
			answer = Math.Round(answer, 4);
		}
		// end

		return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i = 1; i <= 10; ++i)
        {
            answer += (p + (i - 1) * h) * (p + (i - 1) * h);
		}
		answer = Math.Round(answer, 3);
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
        for (int i = 1; i <= 6; ++i)
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
        int x = 1;
        for (int i = 1; i <= 6; ++i)
        {
            x *= i;
            answer += x;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

		// code here;
		double x = 1, y = 1, z = 1;
		for (int i = 1; i <= 6; ++i)
        {
            x *= -1;
            y *= 5;
            z *= i;
            answer += x * y / z;
        }
        answer = Math.Round(answer, 4);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        answer = 1;
        for (int i = 1; i <= 7; ++i)
        {
            answer *= 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i <= 6; ++i)
        {
            Console.WriteLine(i);
        }
		for (int i = 1; i <= 6; ++i)
		{
			Console.WriteLine(5);
		}
		// code here

	}
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double s = 1;
        for (int i = 0; i <= 10; ++i)
        {
            answer += 1 / s;
            s *= x;
        }
        answer = Math.Round(answer, 3);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if ( x <= -1)
        {
            answer = 1;
        }
        else if (x > 1)
        {
            answer = -1;
        }
        else
        {
            answer = -x;
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a = 1, b = 1, c;
        for (int i = 1; i <= 8; ++i)
        {
            Console.Write($"{a} ");
            c = a + b;
            a = b;
            b = c;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double a1 = 1, a2 = 1, b1 = 2, b2 = 1, c1, c2;
        for (int i = 1; i <= 4; ++i)
        {
            c1 = a1 + b1;
            c2 = a2 + b2;
            a1 = b1;
            a2 = b2;
            b1 = c1;
            b2 = c2;
        }
        answer = a1 / a2;
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double s = 0, x = 1;
        for (int i = 1; i <= 64; ++i)
        {
            s += x / 15;
            x *= 2;
        }
        power = 3;
        answer = Math.Round(s, power);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double mx = 6350 * 1000 + x * 1000, m = 6350 * 1000;
        answer = Math.Sqrt(mx * mx - m * m);
        // end
        Console.WriteLine(x);
        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int k = 10;
        for (int i = 1; i < x / 3; ++i)
        {
            k *= 2;
        }
        answer = k;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here
        double s = 0, e = 0, i = 1;
        while (true)
        {
            e = Math.Cos(i * x) / Math.Pow(i, 2);
            if (e < 0.0001 && e > -0.0001)
            {
                break;
            }
            i += 1;
            s += e;
        }
        answer = Math.Round(s + e, 4);
        // end

        return answer;
    }
    public int Task_2_2()
    {
        int answer = 0;

        // code here
        int s = 1;
        for (int i = 1; s <= 30000; i += 3)
        {
            s *= i;
            answer = i - 3;
		}
		// end
		return answer;
    }
    public int Task_2_3(double a, double h, double p)
    {
        int answer = 0;

        // code here
        double s = 0;
        int i = 0;
        while (s <= p)
        {
            s += a + i * h;
            i++;
            if (i > 10000)
            {
                i = 1;
                break;
            }
        }
        answer = i - 1;
        // end

        return answer;
    }
    public double Task_2_4(double x)
    {
        double answer = 0;

        // code here
        double s = 0, e = 1;
        for (int i = 0; ; i += 2)
        {
            s += e;
            e *= x * x;
            if (e < 0.0001)
            {
                break;
            }
            if (i > 10009)
            {
                s = 0;
                break;
            }
        }
        answer = Math.Round(s, 4);
        // end

        return answer;
    }
    public (int, int) Task_2_5(int N, int M)
    {
        int quotient = 0, remainder = 0;

        // code here
        if (M == 0)
        {
            quotient = 0;
            remainder = 0;
        }
        else
        {
            while (Math.Abs(N) >= Math.Abs(M))
            {
                quotient++;
                N -= M;
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
        double s = 0, r = 10;
        for (int i = 1; i <= 7; ++i)
        {
            s += r;
            r *= 1.1;
        }
        answer = Math.Round(s, 4);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

		// code here
		double s = 0, r = 10;
		for (int i = 1; s <= 100; ++i)
		{
			s += r;
			r *= 1.1;
            answer = i;
		}
        // end

		return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

		// code here
		double r = 10;
		for (int i = 1; r <= 20; ++i)
		{
			r *= 1.1;
			answer = i;
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
        double s = 0.1;
        int k = 0;
        while (s > 1e-10)
        {
            s /= 2;
            k++;
        }
        answer = k;
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
        double a = Math.PI / 5, b = Math.PI, h = Math.PI / 25;
        double s = 0, cur = 1;
        int i = 1;
        while (Math.Abs(cur) >= 0.0001)
        {
			cur = Math.Pow(-1, i) * Math.Cos(i * x) / Math.Pow(i, 2);
            S += cur;
            ++i;
		}
        y = (Math.Pow(x, 2) - Math.Pow(Math.PI, 2) / 3) / 4;
        S = Math.Round(S, 2);
		y = Math.Round(y, 2);
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