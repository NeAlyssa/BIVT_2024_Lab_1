using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

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
       // program.Task_1_9();
        //program.Task_1_10();
        //program.Task_1_11();
        //program.Task_1_12(0.9);
        //program.Task_1_13(-1.5);
        //program.Task_1_14();
       // program.Task_1_15();
       // program.Task_1_16();
       // program.Task_1_17(10);
       // program.Task_1_18(24);
       //program.Task_2_1(0);
        program.Task_2_2();
        //program.Task_2_3(8, 2, 0);
        program.Task_2_4(0.8);
        //program.Task_2_5(11, 5);
        program.Task_2_6();
        //program.Task_2_7a();
        //program.Task_2_7b();
        //program.Task_2_7c();
        program.Task_2_8();
        //program.Task_2_9();
        program.Task_2_10();
        //program.Task_3_1(0.1);
        program.Task_3_2(0.1);
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
        for(int i = 2; i <= 35; i+=3) {
            answer += i;
            
        }

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;
        for(double i = 1; i <= 10; i += 1)
        {
            answer += 1.0 / i;
            
        }
        return Math.Round(answer,2);
    }
    public double Task_1_3()
    {
        double answer = 0;

        for( double i = 2;i <= 113; i += 2)
        {
            answer += i / (i+1);
        }

        return Math.Round(answer,2);
    }
    public double Task_1_4(double x) 
    {
        double answer = 0;
        double b = 1;
        for(double i = 0; i <= 8; i += 1)
        {
            if (x == 0) { return 0; }
            answer += Math.Cos(x * (i + 1.0)) / b;
            b *= x;
        }
        

        return Math.Round(answer,2);
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;
        double b = 1;
        for (int i = 0; i <= 9; i += 1)
        {
            double count =(p + h * i)*(p+h*i);
            answer += count;
        }

        return answer;
    } 
    public double Task_1_6(double x) 
    {
        double answer = 0;
        answer = (0.5 * x * x) - (7 * x);
        return Math.Round(answer,2);
    }
    public int Task_1_7()
    {
        int answer = 1;
        for(int i = 1; i <= 6; i++)
        {
            answer *= i;
        }

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 1;
        int b = 0;
        for(int i = 1; i <= 6; i++)
        {
            
            answer *= i;
            b += answer;
                
        }

        return b;
    }
    public double Task_1_9()
    {
        double answer = 0; double c_1 = 1; double c_5 = 1;
        int result = 1;
        
        
        for (int l = 1; l <= 6; l++) {
            c_1 *= (-1); 
            c_5 *= 5;
            result *= l;
            answer += c_1 * c_5 / (double)result;
        }
        

        return Math.Round(answer,2);
    }
    public int Task_1_10()
    {
        int answer = 1;

        for(int i  = 1; i <=7; i++)
        {
            answer *= 3;
        }

        return answer;
    }
    public void Task_1_11()
    {
        Console.Write("а) ");
        for (int i = 1; i <= 6; i++)
        {
            if (i == 6)
            {
                Console.Write(i + ",");
            }
            else
            {
                Console.Write(i + " ");
            }
                                    
        }
        Console.WriteLine();
        Console.Write("б) ");
        for (int y = 1; y <= 6; y++)
        {
            if (y == 6)
            {
                Console.Write("5" + ".");
            }
            else
            {
                Console.Write("5" + " ");
            }
        }
        Console.WriteLine();
    }
    public double Task_1_12(double x)
    {
        double answer = 0, ch = 1;
        for(double i = 0; i <= 10; i++)
        {
            if (x == 0)
            {
                return 0;
            }
            answer += 1.0 / ch;
            ch *= x;
        }
        return Math.Round(answer,2);
    }
    public double Task_1_13(double x)
    {
        double y = 0;
        if (x <= - 1)
        {
            y = 1;
            
        } else if  (-1 < x && x <= 1 )
        {
            y = -1 * x;
            
        }
        else
        {
            y = -1;
        }
        

        return y;
    }
    public void Task_1_14()
    {
        int elpr = 0, eln = 1;
        Console.WriteLine(eln +" ");
        for (int i = 1; i < 8; i++)
        {
            int a = elpr + eln;
            Console.Write(a + " ");
            elpr = eln;
            eln = a;
          
        }

    }
    public double Task_1_15() // 1/1 2/1 3/2 5/3           ( 8/5 )
    {
        double answer = 0;

        //элементы предыдущие:
        double predch = 2;
        double predzn = 1;
        // настоящие элементы:
        double chnow = 3;
        double znnow = 2;

        double chnow1 = 0;
        double znnow1 = 0;
        for (int i = 1; i <= 2; i++)
        {
            chnow1 = predch + chnow;
            znnow1 = predzn + znnow;
            predch = chnow;
            predzn = znnow;
            chnow = chnow1;
            znnow = znnow1;
        }
        answer = chnow1 / znnow1;
        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        double a = 1;
        double vari;
        int power = 0;
        double b = 1;
        for(int i = 1; i <= 63; i+= 1)
        {
            b *= 2;
            a += b;
        }
        vari = (double)a / 15;
        power = (int)Math.Log10(vari);
        double c = 1;
        for (int i = 1; i <= power; i++) {
            c *= 10;
        }
        
        answer = vari / c;

        return (Math.Round(answer,2),power);
    }
    public double Task_1_17(double i)
    {
        double answer = 0;

        double R = 6350;
        double e = R + i;
        answer = Math.Sqrt(e*e - R*R);
            
        return Math.Round(answer, 2);

    }
    public int Task_1_18(int x)
    {
        int answer = 0;
        int count_ameba = 10;
        if (x == 0)
        {
            return 0;
        }
        int e = x / 3;
        int num = 1;
        for (int i = 1; i <= e; i++)
        {
            num *= 2;
        }
        count_ameba *= (int) num;

        
        return count_ameba;
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

        int L = 30_000;
        int p = 1*4*7;

        for (int i = 10; i <= 203; i += 3)
        {
            p *= i;
            if ( p <= L)
            {
                answer = i;
            } else
            {
                break;
            }
            

        }
        
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
        //Вычислить s = 1 + x2 + x4 + ... + x2n (|x| < 1).
        //Вычисления прекратить, когда очередной член суммы будет меньше ε = 0,0001.
        double s = 1;
        const double perem = 0.0001;
        double chetchik = 2;
        double vari;

        if (x == 1)
        {
            return 0;
        }
        do
        {
            double e = 1;
            for (int i = 1; i <= chetchik; i+=1)
            {
                e *= x;
            }
            vari = e;
            s += vari;
            chetchik += 2;
        } while (vari > perem);

        return Math.Round(s,2);
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
        int count_ameba = 10;
        int Time = 0;
        while (count_ameba < 100000)
        {
            count_ameba *= 2;
            Time += 3;
        }
        answer = Time;
        Console.WriteLine(Time + " " + count_ameba);
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

        double money = 10000;
        double c = 0;
        for (int i = 1; i <= 15; i++)
        {
            
            money *= 1.08;
            if (money >= 20000)
            {
                answer = i;
                break;
            }
        }

        return answer;
    }
    public int Task_2_9()
    {
        int answer = 0;

        // code here;

        // end

        return answer;
    }
    public int Task_2_10() // 1/1 2/1 3/2 5/3 8/5
    {
        int answer = 2; // 2 numbers since start
        // 1 number
        double ch1 = 1;
        double d1 = 1;
        // 2 number
        double ch2 = 2;
        double d2 = 1;
        double perebros;
        
        while (Math.Abs(ch2 / d2 - ch1 / d1) > 0.001)
        {
            
            ch1 += ch2; //3
            d1 += d2; // 2

            perebros = ch1; // 3
            ch1 = ch2; //2
            ch2 = perebros; //3

            perebros = d1; //2
            d1 = d2; // 2
            d2 = perebros; // 2
            answer++;
        }
        // end

        return answer;

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
        const double e = 0.0001;

        //lastelement and chetchik
        double chet = 1;
        double b = x;
        double lastel = b * Math.Sin((chet * Math.PI) / 4);
        //process
        while (Math.Abs(b) >= e)
        {
            
            
            S += lastel;
            b *= x;
            chet += 1;
            lastel = b * Math.Sin((chet * Math.PI) / 4);
            
        }
        y = (x * Math.Sin(Math.PI / 4)) / (1 - 2 * x * Math.Cos(Math.PI / 4) + x * x);


        return (Math.Round(S, 2), Math.Round(y, 2));
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
        //conditions
        double S = 0, y = 0;



        return (Math.Round(S,2), Math.Round(y,2));
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