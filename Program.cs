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
        program.Task_1_11();
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
        for (int i = 2; i <= 35; i+=3)
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
        for (double i = 1; i <= 10; i++)
        {
            answer += 1 / i;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2.0; i<=112; i+=2)
        {
            answer += i / (i + 1);
        }
        // end
        answer = Math.Round(answer);
        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if (x == 0)
        {
            return 0;
        }
        for (int i = 1; i<=9; i++)
        {
            answer += Math.Cos(i * x) / Math.Pow(x, i - 1);
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i = 0; i< 10; i++)
        {
            answer += Math.Pow((p + i * h), 2);
        }
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * Math.Pow(x, 2) - x * 7;
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        answer++;
        for (int i = 1; i<=6;i++)
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
        for (int i = 1; i <= 6; i++)
        {
            int midanswer = 1;
            for (int j = 1; j<=i;j++)
            {
                midanswer *= j;
            }
            answer += midanswer;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        for (int i = 1; i<=6;i++)
        {
            int midanswer = 1;
            for (int j = 1; j<=i;j++)
            {
                midanswer *= j;
            }
            answer += Math.Pow(-1, i) * Math.Pow(5, i) / midanswer;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int midanswer = 1;
        for (int i = 1; i<=7;i++)
        {
            midanswer *= 3;
        }
        answer = midanswer;
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i<= 6; i++)
        {
            Console.Write(i+ " ");
        }
        Console.WriteLine();
        for (int i = 1; i <= 6; i++)
        {
            Console.Write(5 + " ");
        }
        // code here

    }
    public double Task_1_12(double x)       
    {
        double answer = 0;

        // code here
        if (x == 0)
        {
            answer = 0;
            return answer;
        }
        for (int i = 0; i<=10; i++)
        {
            answer += (1.0 / Math.Pow(x, i));
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
        else if (x > -1 && x < 1)
        {
            answer = -x;
        } else if (x>=1)
        {
            answer = -1;
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a = 1;
        int b = 1;
        for (int i = 0; i<=8; i ++)
        {
            if (i%2==0)
            {
                b = b + a;
                Console.Write(b);
                Console.WriteLine();
            } else
            {
                a = b + a;
                Console.Write(a);
                Console.WriteLine();
            }
        }
        Console.ReadLine();
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double ch1 = 1, ch2 = 2, ch3=0;
        double zn1 = 1, zn2 = 1, zn3=0;
        for (int i = 0; i<3;i++)
        {
            ch3 = ch1 + ch2;
            ch1 = ch2;
            ch2 = ch3;
            zn3 = zn1 + zn2;
            zn1 = zn2;
            zn2 = zn3;
        }
        answer = ch3 / zn2;
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        for (int i = 0; i < 64; i++)
        {
            answer += Math.Pow(2, i);
        }
        answer = answer / 15;
        while (answer > 10)
        {
            power++;
            answer /= 10;
        }
        answer = Math.Round(answer, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        answer = Math.Round(Math.Sqrt(x * (2 * 6350.0 + x)), 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        answer = (int) Math.Pow(2, x/3)*10;
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
        int i = 1;
        int mult = 1;
        // code here
        while (mult * i <= 30000)
        {
            mult *= i;
            i += 3;
        }
        answer = i-3;
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
        int i = 0;
        // code here
        if (x >= 1 || x <= -1)
        {
            answer = 0;
            return answer;
        }
        while (Math.Pow(x, i) > 0.0001)
        {
            answer += Math.Pow(x, i);
            i += 2;
        }
        // end
        answer = Math.Round(answer, 2);
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
        int i = 0;
        // code here
        while ((int)Math.Pow(2, i / 3) * 10 < 100000)
        {
            i += 3;
        }
        // end
        answer = i;
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
        int credit = 10000;
        int month = 0;
        while (credit+credit*7/100<=20000)
        {
            credit += credit * 7 / 100;
            month++;
        }
        answer = month;
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
        answer += 2;
        double ch1 = 1.0, ch2 = 2.0, ch3 = 0;
        double zn1 = 1.0, zn2 = 1.0, zn3 = 1;
        while ((((ch1 + ch2) / (zn1 + zn2) - (ch3/zn3)) > 0.001) || (((ch1 + ch2) / (zn1 + zn2) - (ch3 / zn3)) < -0.001))
        {
            ch3 = ch1 + ch2;
            zn3 = zn1 + zn2;
            ch1 = ch2;
            ch2 = ch3;
            zn1 = zn2;
            zn2 = zn3;
            //Console.WriteLine(zn1 + " " + zn2 + " " + zn3);
            //Console.WriteLine(ch1 + " " + ch2 + " " + ch3);
            answer += 1;
        }
        answer++;
        //Console.ReadKey();
        return answer++;
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
        double a = 0.1; double b = 0.8; double h = 0.1;
        double item = 1;
        int i = 1;
        while (Math.Pow(x, i) > 0.0001)
        {
            item = Math.Pow(x, i) * Math.Sin((i * Math.PI) / 4);
            i++;
            S+=item;
        }
        S = Math.Round(S, 2);
        y = (x * Math.Sin(Math.PI / 4)) / (1 - 2 * x * Math.Cos(Math.PI / 4) + Math.Pow(x, 2));
        y = Math.Round(y, 2);
        Console.WriteLine(S);
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