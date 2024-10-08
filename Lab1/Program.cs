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
        for (int i = 2; i < 36; i += 3)
        {
            answer = i + answer;
        }
        Console.WriteLine(answer);

        return answer;

    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double i = 1; i < 11; i++)
        {
            answer += (1 / i);
            Console.WriteLine(answer);
        }

        // end

        return Math.Round(answer, 2);
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2; i < 113; i = i + 2)
        {
            answer = answer + (i / (i + 1));
            Console.WriteLine(answer);
        }

        // end

        return Math.Round(answer, 2);

    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        for (double i = 1; i <= 9; i++)
        {
            answer = answer + Math.Cos(i * x) / (Math.Pow(x, (i - 1)));
        }

        // end


        return Math.Round(answer, 2);
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (double i = 0; i <= 9; i++)
        {
            answer = answer + (p + i * h) * (p + i * h);
        }

        // end


        return Math.Round(answer, 2);
    }
    public double Task_1_6(double x)
    {
        return Math.Round(0.5 * x * x - 7 * x, 2);
    }
    public int Task_1_7()
    {
        int answer = 1;

        for (int i = 2; i <= 6; i++)
        {
            answer = answer * i;
        }

        // end
        return answer;

        
    }
    public int Task_1_8()
    {
        int answer = 0;
        int factorial = 1;
        // code here;
        for (int i = 1; i <= 6; i++)
        {
            factorial = factorial * i;
            answer = answer + factorial;
        }
        // end
        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        double factorial = 1;
        // code here
        for (int i = 1; i <= 6; i++)
        {
            factorial = factorial * i;
            answer = answer + Math.Pow(-1, i) *Math.Pow(5, i) / factorial;
        }
        // end

        return Math.Round (answer, 2);
    }
    public int Task_1_10()
    {
        int answer = 1;
        // code here
        for (int i = 1; i <= 7; i+=1)
        {
            answer = 3 * answer;
        }
        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i< 7; i++)
        {
            Console.WriteLine(i);
            Console.WriteLine(5);
        }
        // code here
    }
    public double Task_1_12(double x)
    {
        double answer = 1;
        // code here
        for (double i = 1; i <= 10; i++)
        {
            answer = answer + (1 / Math.Pow(x, i));
        }
        return Math.Round(answer, 2);
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

            // code here
            if (x <= -1)
            {
                answer=1;
            }
            if (x > -1 && x <= 1)
            {
                answer=-x;
            }
            else
            {
                answer=-1;
            }

            // end

            return answer;
    }
    public void Task_1_14()
    {
            // There is no test for this task
            int end = 21;
            int k = 1;
            Console.WriteLine(1);
            for (int i = 1; i <= end; i += k)
            {
                Console.WriteLine(i);
                k = i - k;
            }
    }
        public double Task_1_15()
        {
            double answer = 0;
            double chis = 1;
            double znam = 1;
            // code here
            for (double i = 1; i <= 8; i += chis)
            {
                chis = i - chis;
            }
            for (double k = 1; k <= 5; k += znam)
            {
                znam = k - znam;
            }
            answer = chis / znam;
            // end


            return Math.Round(answer, 2);
        }
    public (double, int) Task_1_16()
        {
        double answer = 0;
        int power = 0;
        double zer = 2;
        double pow = 2;
        for (int i = 2; i < 64; i++)
        {
            pow *= 2;
            zer += pow;
        }
        zer /= 15;
        while (zer >= 10)
        {
            power++;
            zer /= 10;
        }
        answer = Math.Round(zer, 2);

        Console.WriteLine(answer);
        Console.WriteLine(power);
        return (answer, power);
    }
    public double Task_1_17(double x)
        {
        double answer = 0;

            // code here
            for (int i = 1; i < 11; i++)
            {
                answer = Math.Sqrt(6350 * 2 * i + i * i);
            }

            // end

            return Math.Round(answer,2);
        }
    public int Task_1_18(int x)
        {
            int quantity = 10;
            // code here
            for (int i = 3; i <= 24; i += 3)
            {
                quantity = quantity * 2;
                Console.WriteLine();
            }
            return quantity;
        }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
        {
            double answer = 0;
            double znach = 1;
            double n = 1;
            while (Math.Abs(znach) >= 0.0001)
            {
                znach = Math.Cos(n * x) / (n * n);
                n += 1;
                answer = answer + znach;
            }
            answer -= znach;
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
        double answer = 0;
        int k = 0;

            // code here
            while (answer <= p)
            {
                for (double i = 0; ; i++)
                {
                    k += 1;
                    answer = answer + a + i * h;
                }
            }
            return k;
    }
    public double Task_2_4(double x)
    {
        double answer = 0;


            return answer;
    }
    public (int, int) Task_2_5(int N, int M)
    {
        int quotient = 0, remainder = 0;

            // code here
            while (remainder >= M)
            {
                quotient += 1;
                remainder = remainder - M;
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
            double start = 10;
            // code here
            for (double i = 2; i <= 7; i++)
            {
                start = start + start * 0.1;
            }
            Console.WriteLine(start);
            // end

            return start;
        }
    public int Task_2_7b()
    {
        double answer = 10;

            // code here
            for (double i = 2; i<200 ; i++)
            {
                answer = answer + answer * 0.1;
                if (answer == 100)
                {
                    answer = i;
                    break;
                }
            }
            // end

            return answer;
    }
    public int Task_2_7c()
    {
        double answer = 10;

            // code here
            for (double i = 2; i <= 100; i++)
            {
                answer = answer * 0.1;
                if (answer >= 20)
                {
                    answer = i;
                    break;
                }
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
        double l = 0.1;
        double athom = Math.Pow(10, -10);
            // code here;
            while (l > athom)
            {
                l = l / 2;
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
        double S = 1, y = 0;
        const e= Math.Exp();
        double cosinus = Math.Cos(x);
        double sinus = Math.Sin(x);
        int i = 1;
        while (True)
        {
            double factorial = 1;
            for (int j = 2; j <= i, j++)
            {
                factorial *= j;
            }
            double sigma = Math.Cos(i * x) / factorial;
            if (Math.Abs(sigma) < 0.00001)
            {
                break;
            }
        }
        y = Math.Pow(e; cosinus)*Math.Cos(sinus);
        System.Console.WriteLine(S);
        System.Console.WriteLine(y);
        return (S, y);
    }

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