using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.IO.Pipes;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

        //program.Task_1_1();//+
        //program.Task_1_2();//+
        //program.Task_1_3();//+
        //program.Task_1_4(0.5);//+
        //program.Task_1_5(0, 2);//+
        //program.Task_1_6(4);//+
        //program.Task_1_7();//+
        //program.Task_1_8();//+
        //program.Task_1_9();//+
        //program.Task_1_10();//+
        //program.Task_1_11();//+
        //program.Task_1_12(0);//+
        //program.Task_1_13(-1.5);//+- (0.0, 1.0 . . .) - 
        //program.Task_1_14();//+
        //program.Task_1_15();//+
        program.Task_1_16();//+ (how to round) - 
        //program.Task_1_17(10);//+ (why in test 50, 100 . . .)
        //program.Task_1_18(24);//+
        //program.Task_2_1(0);
        //program.Task_2_2();+
        //program.Task_2_3(8, 2, 0);
        //program.Task_2_4(0.8);+
        //program.Task_2_5(11, 5);
        //program.Task_2_6();+
        //program.Task_2_7a();
        //program.Task_2_7b();
        //program.Task_2_7c();
        //program.Task_2_8();+
        //program.Task_2_9();
        //program.Task_2_10();+
        //program.Task_3_1(0.1);
        //program.Task_3_2(0.1);
        //program.Task_3_3(0.1);
        //program.Task_3_4(0.2); //по Y +, а по S в файле нет ответа
        //program.Task_3_5(double.Pi/5);
        //program.Task_3_6(0.1);
        //program.Task_3_7(0.1);
        //program.Task_3_8(0.1);
        //program.Task_3_9(0.1);





        //program.Task_1_1();
        //program.Task_1_2();
        //program.Task_1_3();
        //program.Task_1_4(0.9);
        //program.Task_1_5(0, 2);
        //for (double x=-4; x<4; x += 0.5)
        //{
        //    program.Task_1_6(x);   
        //}
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
        //program.Task_2_4(0);
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

        int Summa = 0;
        for (int i = 2; i<=35; i = i + 3)
        {
            Summa += i;
        }
        answer = Summa;
        // end
        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        double Summa = 1;
        for (int i = 2; i <= 10; i++)
        {
            Summa = Summa + 1.0 / i;
        }
        answer = Math.Round(Summa, 2);
        //Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here

        double Summa = 0;
        for (int i = 2; i <= 112; i = i + 2)
        {
            Summa = Summa + (i / (i + 1.0));
            //Console.WriteLine($"{i} | {i+1.0} = {i/(i+1.0)}");
        }


        answer = Math.Round(Summa, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double Summa;
        Summa = Math.Cos(x);
        //znam = 1;
        if (x == 0)
        {
            answer = 0;
        }
        else
        {
            for (int i = 2; i <= 9; i++)
            {
                double element = Math.Cos(i * x) / Math.Pow(x, i - 1);//znam * x;
                //Console.WriteLine(element);
                Summa += element;
            }

            answer = Math.Round(Summa, 2);
            //Console.WriteLine(Math.Cos(1 * 0) / Math.Pow(0, 1 - 1));
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here

        //p = 0;
        //h = 2;
        double summa = 0;
        for (int i=0; i<10; i++)
        {
            summa += Math.Pow(p + i * h, 2);
        }
        // end
        answer = summa;
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here

        //const double s_start = -4, s_finish = 4, h = 0.5;
        //int n = (int) ((s_finish - s_start) / h + 1);
        //// Console.WriteLine(n);
        //double x1 = -4;
        //for (int i = 1; i <= n; i++)
        //{
        //    double y = 0.5 * x1 * x1 - 7 * x1;
        //    Console.WriteLine($"x = {x1,5} | y = {y,5}");
        //    //answer = y;
        //    x1 += 0.5;
        //}
        double y = 0.5 * x * x - 7 * x;
        // end
        answer = Math.Round(y, 2);
        Console.WriteLine(y);
        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;
        int fact = 1;
        // code here
        for (int i = 1; i<=6; i++)
        {
            fact *= i;
        }
        // end
        answer = fact;
        //Console.WriteLine(answer);
        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;

        int summa = 0;
        int fact = 1;
        for (int i = 1; i<=6; i++)
        {
            fact *= i;
            summa += fact;
        }

        // end
        answer = summa;
        //Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;

        double summa = 0;
        int fact = 1;

        for (int i = 1; i<=6; i++)
        {
            fact *= i;
            double numb = Math.Pow(-1.0, i) * Math.Pow(5.0, i) / fact;
            summa += numb;
        }

        answer = Math.Round(summa, 2);

        // end
        //Console.WriteLine(answer);
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
        Console.WriteLine(answer);
        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task

        // code here
        for (int i = 1; i<=6; i++)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
        for (int i = 1; i<=6; i++)
        {
            Console.Write("5 ");
        }
    }
    public double Task_1_12(double x)
    {
        double answer = 0;
        // code here

        double summa = 0;
        if (x == 0)
        {
            answer = 0;
        }
        else
        {
            for (int i = 0; i <= 10; i++)
            {
                summa += 1.0 / Math.Pow(x, i);
            }
            answer = Math.Round(summa, 2);
            // end
        }
        //Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        if (x <= -1)
        {
            answer = 1;
        }
        else if (-1<x && x <= 1)
        {
            answer = -x;
        }
        else
        {
            answer = -1;
        }

        // code here

        //double x_start = -1.5, x_finish = 1.5, h = 0.1;
        //decimal x1 = -1.5m, y = 0;
        ////double x1 = -1.5, y = 0;
        //int n = (int)((x_finish - x_start) / h + 1);
        //for (int i=1; i<=n; i++)
        //{
        //    if (x1 <= -1)
        //    {
        //        y = 1;
        //    }
        //    else if (-1 < x1 && x1 <= 1)
        //    {
        //        y = -1 * x1;
        //    }
        //    else
        //    {
        //        y = -1;
        //    }
        //    Console.WriteLine($"x = {x1,5} | y = {y,5}");
        //    //x1 += 0.1;
        //    x1 += (decimal)0.1;
        //}

        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int fib1 = 0, fib2 = 1, fib3 = 0;
        for (int i = 1; i<=8; i++)
        {
            fib3 = fib1;
            fib1 += fib2;
            fib2 = fib3;
            Console.WriteLine(fib1);
        }
            
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here

        //method 1

        //double numb1 = 1, numb2 = 1;
        //for (int i = 1; i <= 5; i++)
        //{
        //    if (i == 5)
        //    {
        //        answer = numb1 / numb2;
        //    }
        //    double numb3 = numb1;
        //    numb1 += numb2;
        //    numb2 = numb3;
        //}

        //method2

        double numb1 = 1, numb2 = 1;
        for (int i = 1; i <= 5; i++)
        {
            answer = numb1 / numb2;
            double numb3 = numb1;
            numb1 += numb2;
            numb2 = numb3;
        }

        //Console.WriteLine(answer);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
            double answer = 0;
            int power = 0;

            // code here
            double sum_corn = 1;
            for (int i = 1; i<64; i++)
            {
                sum_corn += Math.Pow(2, i);
                //Console.WriteLine($"{i}   {Math.Pow(2, i)} {sum_corn}");
            }
            double weight_corn = sum_corn / 15.0;
        while (answer > 10)
        {
            power += 1;
            answer /= 10;
        }
        answer = Math.Round(answer, 2);
            //Console.WriteLine(Math.Round(answer/Math.Pow(10, 18), 2));

        // end


        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here

        const double r = 6350;
        //for (double h = 1; h <= 10; h++)
        //{
        //    double s = Math.Pow(Math.Pow(r+h,2)-Math.Pow(r, 2), 0.5);
        //    //double s = Math.Pow(2*r*h+h*h, 0.5);
        //    //Console.WriteLine($"{h} | {s}");
        //    answer = Math.Round(s, 2);
        //    //Console.WriteLine(answer);
        //}
        double s = Math.Pow(Math.Pow(r + x, 2) - Math.Pow(r, 2), 0.5);
        //double s = Math.Pow(2*r*h+h*h, 0.5);
        //Console.WriteLine($"{h} | {s}");
        answer = Math.Round(s, 2);

        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here

        int count_ameb = 10;
            
        for (int hour = 3; hour <= x; hour += 3)
        {
            count_ameb *= 2;
            Console.WriteLine($"{hour} {count_ameb}");
            //Console.WriteLine(count_ameb);
        }
        answer = count_ameb;
        //Console.WriteLine(answer);
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

        // code here

        int p = 1, l = 30000, n = 1;

        while (p*(n+3) <= l)
        {
            n += 3;
            p *= n;
        }
        //Console.WriteLine($"{n}");
        answer = n;
        //Console.WriteLine(answer);
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

        const double e = 0.0001;
        double s = 0;
        int i = 0;
        if (Math.Abs(x) >= 1)
        {
            s = 0;  
        }
        else
        { 
        while (Math.Pow(x, i) >= e) {
            s = s + Math.Pow(x, i);
            //Console.WriteLine($"{x}**{i} = {Math.Pow(x, i)}, s = {s}");
            i += 2;
        }
        }
        answer = Math.Round(s, 2);
        Console.WriteLine(answer);
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

        // code here

        int hour = 0;
        int count_ameb = 10;

        while (count_ameb < Math.Pow(10, 5))
        {
            count_ameb *= 2;
            hour += 3;
            //Console.WriteLine($"hour: {hour} | count: {count_ameb}"); 
        }
        answer = hour;
        //Console.WriteLine(answer);
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
        int answer = 0;

        // code here;

        const double start_sum = 10000;
        double now_sum = 10000;
        int month = 0; 
        while (now_sum < start_sum * 2)
        {
            month += 1;
            now_sum *= 1.08;
            //Console.WriteLine($"month: {month}  sum: {now_sum}");
        }
        answer = month;
        //Console.WriteLine(answer);
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

        double znam = 1, chisl = 1, bottle;
        double first_member = 1, second_member = 2;
        int number = 0;

        while (Math.Abs(second_member-first_member)>0.001)
        {
            number += 1;
            //Console.WriteLine($"{number}. {znam}/{chisl}");
            first_member = second_member;
            second_member = znam / chisl;
            bottle = znam;
            znam += chisl;
            chisl = bottle;      
        }
        answer = number;
        //Console.WriteLine(answer);
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

        int n; //количество итераций цикла
        const double a = 0.1, b = 1, h = 0.1;
        int i, factorial_i = 1;
        double member=1;

        n = (int) ((b - a) / h + 1);
        //Console.WriteLine(n);
        //x = a;
        i = 0;
        
        //for (int k = 1; k<=n; k++)
        //{
            //Console.WriteLine(x);
        while (member > 0.0001)
        {
            member = (2 * i + 1) * Math.Pow(x, 2 * i) / factorial_i;
            S += member;
            //Console.WriteLine($"{i}   {member}");
            i += 1;
            factorial_i *= i;
        }
        y = Math.Round((1 + 2 * Math.Pow(x, 2)) * Math.Pow(Math.E, Math.Pow(x, 2)), 2);
        S = Math.Round(S, 2);    
        Console.WriteLine($"x = {Math.Round(x, 1), -5} | y = {y, 5}   = {S}");
            
        //x += h;
        //}
        //Console.WriteLine($"S = {S}");

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
