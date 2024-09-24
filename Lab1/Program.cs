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
        //Console.WriteLine(program.Task_1_3());
        //program.Task_1_4(0.9);
        //program.Task_1_5(0, 2);
        //for (double x = -4; x<=4;x+=0.5)
        //    program.Task_1_6(x);
        //program.Task_1_7();
        //program.Task_1_8();
        //Console.WriteLine(program.Task_1_9()); 
        //program.Task_1_10();
        //program.Task_1_11();
        //program.Task_1_12(0.9);
        //program.Task_1_13(-1.5);
        //program.Task_1_14();
        //program.Task_1_15();
        //Console.WriteLine(program.Task_1_16());
        //program.Task_1_17(10);
        //program.Task_1_18(24);
        //program.Task_2_1(0);
        //Console.WriteLine(program.Task_2_2());
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
        for (int i = 2;i<=35;i+=3) 
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
            answer += 1/i;
        }

        // end
        
        return Math.Round(answer,2);
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2;i<=112;i+=2)
        {
            answer+= (i)/(i+1);
        }
        // end

        return Math.Round(answer,2);
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        if (x == 0)
            return 0;
        // code here
        double power=1;
        for (double i = 1; i <= 9; i++)
        {
            answer += Math.Cos(i*x)/power;
            power *= x;
        }
        // end

        return Math.Round(answer,2);
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i = 0; i <= 9; i++) 
        {
            answer += (p + h * i)* (p + h * i); 
        }
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {

        double answer = 0;
        answer = 0.5 * x * x - 7 * x;


        return Math.Round(answer, 2);
        
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for (int i = 1;i<=6;i++)
            answer *= i;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;
        int fact = 1;
        // code here;
        for (int i = 2; i <= 7; i++)
        {
            answer += fact;
            fact *= i;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        double a = -1;
        double b = 5;
        double fact = 1;
        // code here;
        for (int i = 2; i <= 7;i++) 
        {


            answer += (a * b) / fact;
            a *= -1;
            b *= 5;
            fact *= i;

        }
        // end

        return Math.Round(answer,2);
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        for (int i = 1;i<=7;i++)
            answer *= 3;
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        Console.WriteLine("1 2 3 4 5 6");
        Console.WriteLine("5 5 5 5 5 5");
        for (int i = 1; i <= 6; i++)
            Console.WriteLine(i);
        for (int i = 1;i<=5 ; i++)
            Console.WriteLine(5);
        // code here

    }
    public double Task_1_12(double x)
    {
        double den = 1;
        double answer = 0;
        if (x == 0)
            return 0;
        // code here
        for (double i = 0; i <= 10; i++) 
        {
            answer += (1)/(den);
            den *= x;
        }
            
        // end

        return Math.Round(answer,2);
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
            return 1;
        else if ((x > -1) & (x <= 1))
            return -x;
        else
            return -1;
        // end

    }
    public void Task_1_14()
    {
        // There is no test for this task
        int j = 1;
        for (int i = 1; i <= 10; i += j)
        {
            Console.WriteLine(i);
            j = i - j;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;
        int num_1 = 1, den_1 = 1;
        int num_2 = 2, den_2 = 1;

        int num = 0, den = 0;
        // code here
        for (int i = 3; i <= 5; i++) 
        {
            num = num_1 + num_2;
            den = den_1 + den_2;

            num_1 = num_2;
            den_1 = den_2;
            num_2 = num;
            den_2 = den;
        }
        answer = (double) num / (double) den;

        // end
        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;
        double seeds = 1;
        // code here
        for (int i = 0; i <= 63; i++)
        {
            answer += seeds;
            seeds *= 2;
        }
        Console.WriteLine(seeds);
        // end
        answer = answer / 15;
        power = (int) Math.Log10((double)answer);
        double den=1;
        for (int i = 0; i < power; i++)
            den *= 10;
        answer = Math.Round(answer/den,2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x) 
    {
        double answer = 0;
        int R = 6350;
        // code here
        answer = Math.Round(Math.Sqrt((R+x)*(R+x)- R*R),2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;
        int y = (int) x / 3;
        int a = 1;
        for (int i = 0; i < y; i++)
            a *= 2;
        // code here
        answer = (int) a*10;
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
        int prod = 1;
        // code here
        for (int i = 1; i <=1000; i += 3) 
        {
            prod *= i;
            if (prod >= 30000)
                return i-3;
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
        if (x == 1)
            return 0;
        double answer = 0;
        double a = 1;
        for (int i = 0;i<100000;i++)
        {
            answer += a;
            a *= x * x;
            if (a < 0.0001)
                return Math.Round(answer,2);

        }
        // code here
        
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
        int ceils = 10;
        // code here
        while (true)
        {
            ceils *= 2;
            answer += 1;
            if (ceils >= 10*10*10*10*10)
                break;
        }
        // end

        return answer*3;
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
        double sum = 10000;
        double per = 8;
        while (sum <= 20000) 
        {
            answer++;
            sum *= per/100 + 1;
        }
        // code here;

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
        double num_1 = 1, den_1 = 1;
        double num_2 = 2, den_2 = 1;
        if (num_2 / den_2 - num_1 / den_1 <= 0.001)
            return 2;
        double num = 0, den = 0;
        for (int i = 3; i <= 1000; i++)
        {
            num = num_1 + num_2;
            den = den_1 + den_2;
            if (Math.Abs(num / den - num_2 / den_2) <= 0.001)
                return i;
            num_1 = num_2;
            den_1 = den_2;
            num_2 = num;
            den_2 = den;
          
        }
        return 0;
        //answer = (double)num / (double)den;
        // end
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
        double fact = 1;
        double a = 1;
        double sum = 0;
        // code here
        y = (1 + 2 * x * x) * Math.Pow(Math.E, x * x);
        for (int i = 0; i < 100000000000;i++)
        {
            sum = ((2 * i + 1) * a) / (fact);
            fact *= (i+1);
            a = a * x * x;
            S += sum;
            if (Math.Abs(sum) < 0.0001)
            {
                return (S,y);

            }
                
            

            

        }
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
