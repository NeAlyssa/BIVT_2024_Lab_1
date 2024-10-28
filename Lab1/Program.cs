using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System;
using System.Security.Cryptography;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        Console.WriteLine("Hello world");

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

        for (int i = 2; i < 36; i+=3)
        {
            answer = i + answer;
        }
        
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        for (int j = 1; j < 11; j++)
        {
            answer += 1.0/j;
        }

        // end
        answer = Math.Round(answer,2);
        
        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        int i, j;
        for (i = 2; i <= 112; i += 2)
        { 
            j = i + 1;
            answer += (double) i / j;
        }

        // end
        Console.WriteLine(answer);
        answer = Math.Round(answer,2);

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        double k = 1;

        for (int i = 1; i < 10; i++)
        {
            answer += (Math.Cos(x * i)) / k;
            k *= x;
        }
        answer = Math.Round(answer,2);
        
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        for (double i = 0; i < 10; i++)
        {
            answer += Math.Pow(p + i * h, 2);
        }

        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        {
            answer = (x * x / 2) - (7 * x);
        }
        answer = Math.Round(answer,2);
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;


        for (int i = 1;i <7; i++ )
        {
            answer *= i;
        }
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;
        int k = 1;
        for (int i = 1; i < 7; i++)
        {
            k *= i;
            answer += k;
        }
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        double k = 1;
        double j = 1;
        double l = 1;
        for(double i = 1;i<7;i++)
        {
            j *= 5;
            k *= i;
            l *= (-1);
            answer += l * j / k;
        }
        // end
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        int i = 3;
        for (int j = 2;j < 8; j++)
        {
            i *= 3;   
        }
        answer = i;
        Console.WriteLine(answer);
        return answer;
    }
    public void Task_1_11()
    {
        string s = "";
        for (int i = 1; i < 7; i++) 
        {
            s += Convert.ToString(i) + " ";
        }
        Console.WriteLine(s);
        string a = "";
        for (int i = 1; i < 7; i++)
        {
            a += "5 ";
        }
        Console.WriteLine(a);


    }
    public double Task_1_12(double x)

    {
        double answer = 0;

        answer = 1;
        if (x == 0)
        {
            return 0;
        }
        for (double i = 1, k = 1; i <= 10; i++)
        {
            k = k * x;
            answer += 1 / k;
        }

        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
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
        else if (x > -1 && x <= 1)
        {
            answer = -x;
        }
        else
        {
            answer = -1;
        }

        // end

        return answer;
    }
    public void Task_1_14()
    {
        int i = 1;
        int j = 1;
        string numbs = Convert.ToString(i) + " " + Convert.ToString(j) + " ";
        for (int k = 3; k < 9; k++)
        {
            int s = i + j;
            numbs += Convert.ToString(s) + " ";
            i = j;
            j = s;
        }
        Console.WriteLine(numbs);

    }
    public double Task_1_15()

    {
        double answer = 0;
        double c1 = 1;
        double z1 = 1;
        double c2 = 2;
        double z2 = 1;
        double c = 0;
        double z = 0;
        for (int i = 3; i <6; i ++)
        {
            c = c1 + c2;
            z = z1 + z2;
            c1 = c2;
            z1 = z2;
            c2 = c;
            z2 = z;
        }

        answer = Math.Round(c / z, 2);
        
        Console.WriteLine(answer);
        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 1;
        double temp = 1;
        for (int i = 1; i <= 64; i++)
        {
            answer += temp;
            temp *= 2;
        }

        answer = answer / 15;
        power = (int)Math.Log10(answer);

        answer = Math.Round(answer / Math.Pow(10, power), 2);

        return(answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        answer = Math.Sqrt(x * (2 * 6350 + x));
        
        answer = Math.Round(answer, 2);
        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;
        
        for (int i = 1; i <= x; i+= 3)
        {
            answer = answer * 2;
        }
        Console.WriteLine(answer);
        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;
  
        double n = 1;
       

        while(Math.Abs((Math.Cos(x * n)) / (n * n)) >= 0.0001)
        {
            
            answer += (Math.Cos(x * n)) / (n * n);
            n++;
        }
        
        Console.WriteLine(answer);
        
        return (answer);
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
        
        {
            double s = 0;
            int n = 0;

            if (p == 0)
            {
                return 0;
            }
            else if (h <= 0)
            {
                return 0;
            }

            do
            {
                s += a + h * n;
                n++;
                answer++;
            } while (s <= p);
            

            
            answer -= 1; 
        }
        
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
        if (M == 0)
        {
            return (0,0);
        }
        do
        {
            N -= M;
            quotient++;
            remainder = N;
        } while (N >= M);

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

        double n = 10;
        for (int i = 1; i <= 7; i++)
        {
            answer += n;
            n*= 1.1;
        }
        answer = Math.Round(answer,2);
        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        double n = 10;
        double sp = 0;
        do
        {
            answer += 1;
            sp += n;
            n *= 1.1;
            
        } while (sp <= 100);

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        double n = 10;
        do
        {
            n *= 1.1;
            answer++;
        } while (n <= 20);

        
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

        double d =Math.Pow(10, -10);
        double l = 0.1;

        do
        {
            l /= 2;
            answer++;
        }while (l >= d);
        
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


        double i = 1;
        double n1 = -1;
        double n2 = Math.Cos(x);
        double n3 = 1;
        double d = n1 * n2 / n3;
        
        while (Math.Abs(d) >= 0.0001)
        {
            S += d;
            i++;
            n1 *= -1;
            n2 = Math.Cos(i * x);
            n3 = i * i;
            d = n1 * n2 / n3;

            
        }
        y = (x * x - (double.Pi * double.Pi) / 3) / 4;

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
