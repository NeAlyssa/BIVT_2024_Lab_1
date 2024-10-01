using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

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
        program.Task_2_5(1, 0);
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

        for(int i = 2; i<=35; i += 3)
        {
            answer = answer + i;
        }

        

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        for(double i = 1; i<=10; i++)
        {
            double a = 1;
            double x = a / i;
            answer += x;
        }

        
        answer = Math.Round(answer, 2);
        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        for(double chislitel = 2; chislitel < 113; chislitel += 2)
        {
            double znamenatel = chislitel + 1;
            double x = chislitel / znamenatel;
            answer += x;
            Console.WriteLine(x);
        }
        answer = Math.Round(answer, 0);
        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        double s = 0;
        double zn = 1;
        double d = 0;

        for(double i = 1; i < 10; i++)
        {
            if (i == 1)
            {
                zn = 1;
            }
            else
            {
                zn = zn * x;
            }
            d += x;
            s = Math.Cos(d) / zn;
            answer += s;

        }
        answer = Math.Round(answer, 2);

        
        
        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;
        double s = 0;
        for (double i = 0; i < 10; i++)
        {
            s = (p + (i * h)) * (p + (i * h));
            answer += s;
        }

        

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        answer = 0.5 * x * x - 7 * x;
        answer = Math.Round(answer, 2);

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;
        int s = 1;
        for( int i = 1; i < 7; i++)
        {
            s = s * i;
        }

        
        answer = s;
        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;
        int s = 1;

        for (int i = 1; i < 7; i++)
        {
            s = s * i;
            answer += s;
        }

        

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        double i1 = -1;
        double i2 = 5;
        double i3 = 1;
        

        for(int x = 1; x < 7; x++)
        {
            answer += i1 * i2 / i3;
            i1 = i1 * (-1);
            i2 = i2 * 5;
            i3 = i3 * (x + 1);
        }
        answer = Math.Round(answer, 2);
        

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;

        answer = 1;
        for ( int i = 1; i <= 7; i++)
        { 
            answer *= 3;
        }
        
        Console.WriteLine(answer);
        return answer;
    }
    public void Task_1_11()
    {
        
        for(int i = 1;i < 7 ; i++)
        Console.Write(i);
        Console.Write(' ');
        

    }
    public double Task_1_12(double x)
    {
        double answer = 0;
        double zn = 1;

        if (x == 0)
        {
            return answer;
        }
        else
        {
            for (int i = 0; i <= 10; i++)
            {
                answer += 1 / zn;
                zn *= x;
            }
        }
        
        answer = Math.Round(answer, 2);
        

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        
            if (x <= -1)
            {
                answer = 1;
            }
            if (x <= 1 & x > -1)
            {
                answer = -1 * x;
            }
            if (x > 1)
            {
                answer = -1;
            } 
        

        return answer;
    }
    public void Task_1_14()
    {
        int i1 = 1;
        int i2 = 1;
        Console.WriteLine(i1);
        Console.WriteLine(i2);
        for (int i = 1; i < 7 ; i++)
        {
            Console.WriteLine(i1 + i2);
            if (i1 <= i2)
            {
                i1 = i1 + i2;
            }
            else
            {
                i2 = i1 + i2; 
            }
        }

    }
    public double Task_1_15()
    {
        double answer = 0;

        double ch1 = 1; double zn1 = 1;
        double ch2 = 2; double zn2 = 1;
        double ch = 0; double zn = 0;
        
        for (int i = 1; i < 4; i++)
        {
            if (ch1 <= ch2)
            {
                ch1 = ch1 + ch2;
                ch = ch1;
            }
            else
            {
                ch2 = ch1 + ch2;
                ch = ch2;
            }
            if (zn1 <= zn2)
            {
                zn1 = zn1 + zn2;
                zn = zn1;
            }
            else
            {
                zn2 = zn1 + zn2;
                zn = zn2;
            }
        }
        answer = ch / zn;
        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;
        double colvo = 1;
        for(int i = 1; i <= 64; i++)
        {
            colvo = colvo * 2;
            if (colvo > 1000000000)
            {
                colvo = colvo / 10;
                power++;
                
            }
            Console.WriteLine(colvo);
        }
        answer = colvo / 15;
        while(answer > 10)
        {
            answer = Math.Round((answer / 10), 2);
            power++;
        }
        
        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        double a = 0; double b = 6350;
        


            a = b + x;
            answer = Math.Sqrt(a * a - b * b);
            Console.WriteLine(answer);


        
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;
        int a = 10;
        for (int time = 3; time <= x; time += 3)
        {
            a = a * 2;
            answer = a;
            Console.WriteLine(answer);
        }
        

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;
        double n = 0;
        double e = 0.0001;
        double s = 0;
        do
        {
            n++;
            
            s = Math.Cos(x * n) / (n * n);
            answer += s;

        } while (Math.Abs(s) >= e);
            answer = answer - s;
        
            return answer;
    }
    public int Task_2_2()
    {
        int answer = 0;
        int n = 1;
        int l = 1;
        while(l <= 30000)
        {
            n = n + 3; 
            l = l * n;
        }
        answer = n - 3;
        return answer;
    }
    public int Task_2_3(double a, double h, double p)
    {
        int answer = 1;
        double s = a;
        double summa = s;
        while (summa <= p)
        {   
            answer++;
            s = s + h;
            summa = summa +  s;
            Console.WriteLine(s);
        }

        Console.WriteLine(answer);
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
        int a = 0, b = 0;
        if (N == 0 || M == 0)
        {
            Console.WriteLine($"{quotient}, {remainder}");
            return (quotient, remainder);
        }
        else
        {
            if (N < M)
            {
                a = M;
                b = N;
            }
            else
            {
                a = N;
                b = M;
            }

            while (a >= b)
            {
                a = a - b;
                quotient++;
            }
            remainder = a;
        }

        Console.WriteLine($"{quotient}, {remainder}");
        
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

        
        double dist = 10;
        for(int i = 1; i < 8; i++)
        {
            answer += dist;
            dist = dist * 1.1;
        }
        answer = Math.Round(answer, 2);
        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;
        double i = 1;
        double s = 0;
        double dist = 0;

        while(dist < 100)
        {
            i *= 1.1;
            s = 10 * i / 1.1;
            dist += s;
            answer++;
        }
        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;
        double x = 10;
        while (x < 20)
        {
            answer ++;
            x = x * 1.1;
        }
        

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
        double l = 0.1;
        int answer = 0;
        double Da = 1;
        for (int i = 1; i < 11; i++)
        {
            Da = Da / 10;
        }
        while (l > Da)
        {
            l = l / 2;
            answer ++;
        }

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
        double e = 0.0001;
        for (x = 0.1; x <= 1; x += 0.05)
        {
            double chl = 0, chs = 1, zn = 1, i = 0;
            S = 0;
            y = 0;
            do
            {
                if (i > 0)
                {
                    chs *= 2 * x; zn *= i;
                }
                else
                {
                    chs = Math.Pow(2 * x, 0);
                    zn = 1;
                }
                chl = chs / zn;
                S += chl;
                i++;
            } while (Math.Abs(chl) > e);
            S -= chl;
            y = Math.Pow(Math.E, 2 * x);
            y = Math.Round(y, 2);
            S = Math.Round(S, 2);
            Console.WriteLine($"S = {S}, y = {y}");

        }
        

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
