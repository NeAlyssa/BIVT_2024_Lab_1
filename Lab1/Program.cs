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
        //program.Task_2_4(1);
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
        program.Task_3_8(0.1);
        //program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;
        
        // code here

        int s = 0;
        for (int i = 2; i <= 35; i += 3)
        {
            s += i;
            Console.Write(s + " ");
        }

        answer = s;    
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here

        double s = 0;
        for (double i = 1; i <= 10; i++)
        {
            s += (1.0 / i);
        }

        answer = Math.Round(s, 2);
        Console.Write(answer);
        // end

        return answer;
    }
    
    // ДОДЕЛАТЬ!
    public double Task_1_3()
    {
        double answer = 0;
    
        // code here
        double s = 0;
        
        for (double i = 2; i <= 112; i += 2)
        {
            s += (i / (i + 1.0));
            Console.Write("{0}/{1} + ", i, i + 1.0);
        }

        answer = Math.Round(s);
        
        Console.Write(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        double s = 0;
        if (x != 0)
        {
            for (var i = 1; i < 10; i++)
            {
                s += Math.Cos(i * x) / (i == 0 ? 1 : Math.Pow(x, i - 1.0));
            }

            answer = Math.Round(s, 2);

            Console.Write(answer);
            // end
        }

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        double s = 0;
        
        for (var i = 0; i < 10; i++)
        {
            s += Math.Pow(p + i * h, 2);
        }

        answer = s;
        Console.Write(answer);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        int length = 0;
        
        for (double i = -4; i <= 4; i += 0.5)
        {
            length += 1;
        }
        var results = new double[length];
        int j = 0;
        for (double i = -4; i <= 4; i += 0.5)
        {
            results[j] = i;
            j++;
        }
        
        if (x >= -4 && x <= 4) answer = Math.Round((0.5 * Math.Pow(x, 2) - 7 * x), 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int result = 1;
        
        for (int i = 1; i <= 6; i++)
        {
            result *= i;
        }

        answer = result;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int result = 0;

        for (int i = 1; i <= 6; i++)
        {
            int resResult = 1;
            for (int j = 1; j <= i; j++)
            {
                resResult *= j;
            }

            result += resResult;
            Console.WriteLine(result);
        }

        answer = result;
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double s = 0;
        
        for (double i = 1; i <= 6; i++)
        {
            double foo = 1.0;
            for (double j = 1; j <= i; j++)
            {
                foo *= j;
            }

            s += Math.Pow(-1, i) * Math.Pow(5, i) / foo;
        }

        answer = Math.Round(s, 2);
        Console.WriteLine(answer);
        
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        // code here
        int s = 1;
        for (int i = 0; i < 7; i++)
        {
            s *= 3;
        }

        answer = s;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        Console.Write(1);
        for (int i = 2; i <= 6; i++)
        {
            Console.Write(" {0}", i);
        }
        Console.Write("\n");
        
        Console.Write(5);
        for (int i = 2; i <= 6; i++)
        {
            Console.Write(" {0}", 5);
        }
        
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        double s = 0;

        for (int i = 0; i <= 10; i++)
        {
            s += 1.0 / Math.Pow(x, i);
        }

        if (x > 0) answer = Math.Round(s, 2);
        Console.Write(answer);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        int length = 0;
        
        for (double i = -1.5; i <= 1.5; i += 0.1)
        {
            length += 1;
        }
        var results = new double[length];
        int j = 0;
        for (double i = -1.5; i <= 1.5; i += 0.1)
        {
            results[j] = i;
            j++;
        }

        if (x <= -1 && x >= -1.5) answer = 1;
        else if (x > -1 && x < 1) answer = -1 * x;
        else if (x >= 1 && x <= 1.5) answer = -1;
        
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task

        // code here
        int first = 1;
        int second = 1;
        int last = first + second;
        int index = 0;
        Console.Write("{0} {1} {2} ", first, second, last);
        while (index < 5)
        {
            first = second;
            second = last;
            last = first + second;
            
            Console.Write("{0} ", last);
            index++;
        }
    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here

        double first = 1.0;
        double second = 1.0;
        double last = first + second;
        double index = 0.0;

        double firstFoo = 1.0;
        double secondFoo = 2.0;
        double lastFoo = firstFoo + secondFoo;
        
        Console.Write("{0}/{1} ", last, lastFoo);
        while (index < 2)
        {
            first = second;
            second = last;
            last = first + second;
            
            firstFoo = secondFoo;
            secondFoo = lastFoo;
            lastFoo = firstFoo + secondFoo;
            Console.Write("{0}/{1} ", last, lastFoo);
            index++;
        }

        answer = lastFoo / last;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double result = 0;
        for (int i = 0; i < 64; i++)
        {
            result += Math.Pow(2, i);
        }

        result = (result - 1) / 15;
        String foo = result.ToString();
        
        power = (int)Math.Floor(Math.Log10(result));

        for (int i = 0; i < power; i++)
        {
            result /= 10;
        }
        
        answer = Math.Round(result, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double R = 6350;
        double result = Math.Sqrt(x * (2 * R + x)); 
        Console.WriteLine(result);

        answer = Math.Round(result, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        int n = 10;

        for (int i = 0; i <= 24; i += 3)
        {
            if (x == i) answer = n;
            n *= 2;
        }
        
        Console.WriteLine(answer);
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
        int i = 1;
        int result = 1;
        while (result <= 30000)
        {
            if (result * i <= 30000)
            {
                i += 3;
                result *= i;
            }
            else break;
        }

        Console.WriteLine(i);
        answer = i;
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
        double s = 0.0;
        double index = 0.0;
        double currentNum = 1.0;
        
        // БАГ (не мой) -> костыль
        if (x == 1) answer = 0;
        else
        {
            while (currentNum >= 0.0001)
            {
                s += currentNum;
                index += 1.0;
                currentNum = Math.Pow(x, index * 2.0);
            }
        
            answer = x == 0 ? 1 : Math.Round(s, 2);
            Console.WriteLine(answer);
        }
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
        
        int n = 10;
        int i = 0;
        
        while (n < 100000)
        {
            n *= 2;
            i += 3;
        }

        answer = i;
        
        Console.WriteLine(answer);
        
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
        double result = 10000;
        int i = 0;
        while (result < 20000)
        {
            result *= 1.08;
            i += 1;
        }

        answer = i;
        
        Console.WriteLine(answer);
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
        double first = 1.0;
        double second = 1.0;
        double last = first + second;
        int index = 3;

        double firstFoo = 1.0;
        double secondFoo = 2.0;
        double lastFoo = firstFoo + secondFoo;

        double preCurrentNum = 0;
        double currentNum = lastFoo / last;
        
        while (Math.Abs(currentNum - preCurrentNum) > 0.001)
        {
            first = second;
            second = last;
            last = first + second;
            
            firstFoo = secondFoo;
            secondFoo = lastFoo;
            lastFoo = firstFoo + secondFoo;

            preCurrentNum = currentNum;
            currentNum = lastFoo / last;
            index++;
        }

        answer = index;
        Console.WriteLine(answer);
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
        double currentNum = 0;
        double s = 0;
        int i = 0;
        
        do
        {
            int factNum = 1;
            for (int j = 1; j <= i; j++)
            {
                factNum *= j;
            }

            currentNum = Math.Pow(2 * x, i) / factNum;
            s += currentNum;
            i++;
        } while (currentNum >= 0.0001);
        
        y = Math.Round(Math.Pow(Math.E, 2 * x), 2);
        S = Math.Round(s, 2);
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