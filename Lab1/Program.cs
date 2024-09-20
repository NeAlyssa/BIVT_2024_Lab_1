using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //Console.WriteLine("Добро пожаловать в C#!");
        //program.Task_1_1();
        //program.Task_1_2();
        //program.Task_1_3();
        //program.Task_1_4(0.9);
        program.Task_1_5(0, 2);
        //program.Task_1_6(4);
        //program.Task_1_7();
        // program.Task_1_8();
        //program.Task_1_9();
        //program.Task_1_10();
        // program.Task_1_11();
        //program.Task_1_12(0);
        //program.Task_1_13(-1.5);
        //program.Task_1_14();
        //program.Task_1_15();
        //program.Task_1_16();
        //program.Task_1_17(10);
        //program.Task_1_18(6);
        //program.Task_2_1(0);
        //program.Task_2_2();
        //program.Task_2_3(1, 1, 10);
        //program.Task_2_4(0.8);
        //program.Task_2_5(8, 2);
        //program.Task_2_6();
        // program.Task_2_7a();
        //program.Task_2_7b();
        //program.Task_2_7c();
        // program.Task_2_8();
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
        for (int i = 2; i < 36; i = i + 3)
        {
            answer += i;
            Console.WriteLine(i);
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double i = 1; i < 11; i++)
        {
            answer += 1 / i;
            Console.WriteLine(answer);
        }
        // end
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2; i < 113; i += 2)
        {
            answer += ((i + 0) / (i + 1));
            Console.WriteLine((i + 0));

        }
        // end
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = Math.Cos(x);

        // code here
        if (x == 0)
        {
            return 0;
        }
        for (double i = 1; i <= 8; i++)
        {

            answer += (Math.Cos(x * (i + 1))) / Math.Pow(x, (i));

        }
        // end
        Console.WriteLine(answer);
        answer = Math.Round(answer, 2);
        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;
        Console.WriteLine(p);
        Console.WriteLine(h);
        Console.WriteLine("!!!!!!!!!!!!!!!!!");
        // code here
        for (double i = 0; i <= 9; i++)
        {
            answer += Math.Pow((p + h * i), 2);
            Console.WriteLine(Math.Pow((p + h * i), 2));
            Console.WriteLine((p + h * i));
            Console.WriteLine("----------------------------------");
            // end
        }
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * x * x - 7 * x;
        // end
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for (int i = 1; i < 7; i++)
        {
            answer = answer * i;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        for (int i = 1; i < 7; i++)
        {
            int temp = 1;
            for (int j = 1; j < i + 1; j++)
            {
                temp = temp * j;
            }
            Console.WriteLine(temp);
            answer += temp;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;


        // code here;
        for (int i = 1; i < 7; i++)
        {
            Console.WriteLine("!!!!!!!!!!!");
            double num1 = -1;
            double num2 = 5;
            double res1 = 1;
            double res2 = 1;

            double res3 = 1;

            for (int j = 1; j < i + 1; j++)
            {
                res1 = num1 * res1;
                res2 = num2 * res2;
            }
            for (int j = 1; j < i + 1; j++)
            {
                res3 = res3 * j;
            }
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.WriteLine(res3);

            answer += res1 * res2 / res3;
        }
        // end
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        return answer;
        // end


    }
    public int Task_1_10()
    {
        int answer = 1;
        int co = 3;
        // code here
        for (int j = 1; j < 8; j++)
        {
            answer = answer * co;
            Console.WriteLine(j);
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public void Task_1_11()
    {
        string answer = "";
        string answer2 = "";
        // There is no test for this task
        for (int i = 1; i < 7; i++)
        {
            answer += 5 + " ";
            answer2 += i + " ";
        }
        Console.WriteLine(answer2);
        Console.WriteLine(answer);
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;
        if (x == 0)
        {
            return 0;
        }
        // code here
        for (int i = 0; i < 11; i++)
        {
            double res1 = 1;

            for (int j = 1; j < i + 1; j++)
            {
                res1 = res1 * x;
            }
            Console.WriteLine(1);
            Console.WriteLine("-----");
            Console.WriteLine(res1);
            answer += (1 / res1);
        }
        // end

        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        if (x <= -1)
        {
            return 1;
        }
        if (x > 1)
        {
            return -1;
        }
        // end

        return -x;
    }
    public void Task_1_14()
    {
        int f = 1;
        int s = 1;
        int t = 1;
        Console.WriteLine(1);
        Console.WriteLine(1);
        for (int i = 0; i < 6; i++)
        {
            t = f + s;
            f = s;
            s = t;
            Console.WriteLine(t);
        }

        // There is no test for this task

        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;
        double zn1 = 1;
        double zn2 = 2;
        double zn3 = 3;
        double zn4 = zn3 + zn2;
        double zn5 = zn3 + zn4;

        double ch1 = 1;
        double ch2 = 1;
        double ch3 = 2;
        double ch4 = ch3 + ch2;
        double ch5 = ch3 + ch4;
        // code here

        // end
        answer = zn5 / ch5;
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        double last = 2;
        int power = 0;
        // code here
        for (int i = 1; i < 64; i++)
        {
            answer += last;
            Console.WriteLine(answer);
            last = 2 * last;



        }
        answer = answer / 15;
        while (answer > 10)
        {
            power += 1;
            answer = answer / 10;

        }
        // end
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        answer = Math.Sqrt(2 * x * 6350 + Math.Pow(x, 2));
        // end
        answer = Math.Round(answer, 2);
        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here
        int x_two = x / 3;
        Console.WriteLine(x_two);
        for (int i = 0; i < x_two; i++)
        {
            answer = answer * 2;
        }
        // end
        Console.WriteLine(answer);
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
        int start = 1;
        int n = -1;
        while (answer <= 30000)
        {
            n += 1;
            answer = answer * (1 + 3 * n);
            if (answer > 30000)
            {
                n -= 1;
                break;
            }
            Console.WriteLine("---------------");
            Console.WriteLine(n);
            Console.WriteLine(1 + 3 * n);
            Console.WriteLine(answer);



        }
        // code here

        // end

        return 1 + 3 * n;
    }
    public int Task_2_3(double a, double h, double p)
    {
        double answer = 0;
        double i = 0;
        Console.WriteLine(a);
        Console.WriteLine(h);
        Console.WriteLine(p);
        // code here
        while (answer <= p)
        {

            if ((answer + (a + h * i)) > p)
            {
                break;
            }

            answer += a + h * i;
            i += 1;
            Console.WriteLine(h * i);
            if (i > 100)
            {
                return 0;
            }
        }
        // end
        Console.WriteLine(answer);

        int answer2 = (int)answer;

        Console.WriteLine(i);
        return (int)i;
    }
    public double Task_2_4(double x)
    {
        double answer = 0;
        double s = 1;
        int n = 2;
        if (x == 1)
        {
            return 0;
        }
        while (Math.Abs(Math.Pow(x, n)) >= 0.0001)
        {
            s += Math.Pow(x, n);
            Console.WriteLine(s);
            n += 2;
        }
        // code here

        // end
        s = Math.Round(s, 2);
        Console.WriteLine(s);
        return s;
    }
    public (int, int) Task_2_5(int N, int M)
    {
        Console.WriteLine(N);
        Console.WriteLine(M);
        N = Math.Abs(N);
        M = Math.Abs(M);
        Console.WriteLine("----------");
        int quotient = 0, remainder = 0;
        if (M == 0)
        {
            Console.WriteLine(0);
            return (0, 0);
        }
        // code here
        while (N >= M)
        {
            N = N - M;
            quotient++;

        }

        // end
        Console.WriteLine(quotient);
        Console.WriteLine(N);
        return (quotient, N);
    }
    public int Task_2_6()
    {
        int answer = 0;

        // code here
        int need = 100000;
        int n = 0;
        while (need > 10)
        {
            need = need / 2;
            n += 1;
            Console.WriteLine(need);
        }
        // end
        Console.WriteLine(n * 3);
        return n * 3;
    }
    public double Task_2_7a()
    {
        double answer = 0;
        double start = 10;
        // code here
        for (int i = 0; i <= 6; i++)
        {
            answer += start;
            Console.WriteLine(start);
            start = start * 1.1;
            Console.WriteLine(i);
        }
        // end
        Console.WriteLine(answer);
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        Console.WriteLine(answer);
        return answer;

    }
    public int Task_2_7b()
    {
        double answer = 0;
        double start = 10;
        // code here
        for (int i = 0; i <= 10; i++)
        {
            answer += start;
            Console.WriteLine(start);
            start = start * 1.1;
            Console.WriteLine(i);
            if (answer >= 100)
            {
                return i + 1;
            }
        }
        return 0;



    }
    public int Task_2_7c()
    {
        double answer = 0;
        double start = 10;
        // code here
        for (int i = 0; i <= 10; i++)
        {
            answer += start;
            Console.WriteLine(start);
            start = start * 1.1;
            Console.WriteLine(i);
            if (start >= 20)
            {
                return i + 1;
            }
        }
        return 0;
    }
    public int Task_2_8()
    {
        double answer = 10000;
        double percent = 1.08;
        int n = 0;
        while (answer < 10000 * 2)
        {
            answer = answer * percent;
            n += 1;
            Console.WriteLine(answer);
        }
        // code here;

        // end
        Console.WriteLine(n);
        return n;
    }
    public int Task_2_9()
    {
        int i = 0;
        double atom = 1;
        double lenV = 1000000000;
        // code here;
        while (atom < lenV)
        {
            lenV = lenV / 2;
            i++;
        }
        // end

        return i;
    }
    public int Task_2_10()
    {
        int answer = 0;

        // code here;

        double lastz2 = 1;
        double lastz1 = 1;

        double lastch2 = 2;
        double lastch1 = 1;

        double last = 0;
        double curch = 1;
        double curz = 1;
        double cur = 0;

        for (int i = 1; i < 10; i++)
        {
            curch = (lastch1 + lastch2);
            curz = (lastz2 + lastz1);
            cur = curch / curz;

            last = lastch2 / lastz2;
            Console.WriteLine(i);
            Console.WriteLine("-------");
            Console.WriteLine(curch);
            Console.WriteLine(curz);
            Console.WriteLine("------");

            Console.WriteLine("!!!!!!");
            Console.WriteLine(last);
            Console.WriteLine(cur);
            if (Math.Abs((cur - last)) <= 0.001)
            {
                Console.WriteLine("!");
                Console.WriteLine(i);
                Console.WriteLine(cur - last);
                return i + 2;
            }

            lastch1 = lastch2;
            lastz1 = lastz2;

            lastch2 = curch;
            lastz2 = curz;
            last = cur;
        }

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
        int i = 1;
        // code here
        double next = 5;

        while (Math.Pow(x, i) >= 0.0001)
        {
            next = Math.Pow(x, i) * Math.Sin(i * Math.PI / 4);
            if (Math.Pow(x, i) >= 0.0001)
            {
                S += next;
                i += 1;
            }
            

        }


        y = (x * Math.Sin(Math.PI / 4));
        y = y / (1 - (2 * x * (Math.Cos(Math.PI / 4))) + x * x);
        // end


        y = Math.Round(y, 2);
        S = Math.Round(S, 2);

        Console.WriteLine(S);
        Console.WriteLine(y);

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
