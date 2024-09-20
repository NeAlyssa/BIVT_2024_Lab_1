using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;


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
        program.Task_3_6(0.4);
        //program.Task_3_7(0.1);
        //program.Task_3_8(0.1);
        //program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;

        for (int i = 2; i <= 35; i += 3)
            answer += i;

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;
        const int a = 1;
        for (double i = 1; i < 11; i++)
        {
            answer += (a / i);
     
        }
            
        return Math.Round(answer,2);
        
    }
    public double Task_1_3()
    {
        double answer = 0;
        for(double i = 2; i<=112; i += 2)
        {
            answer += i / (i + 1);
        }
        
        return Math.Round(answer,2);
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        double numinpow = 1;
        for (int i = 1; i<=9; i++)
        {
            
            answer += Math.Cos(i * x) / numinpow;
            numinpow *= x;
        }
        
        return Math.Round(answer,2);
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        for (int i=0; i<=9; i++)
        {
            answer += (p + i * h)* (p + i * h);
        }
       
        return Math.Round(answer,2);
    }
    public double Task_1_6(double x)
    {
        double answer = 0;
        answer = 0.5 * x*x - 7 * x;
        

        return Math.Round(answer,2);
    }
    public int Task_1_7()
    {
        int answer = 0;

        answer = Fact(6);

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;
        for (int i = 1; i<=6; i++)
        {
            answer += Fact(i);
        }
        
        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        double num1inpow = 1;
        double num2inpow = 1;
        for (int i = 1; i<=6; i++)
        {
            answer += num1inpow * num2inpow / Fact(i);
            num1inpow *= -1;
            num2inpow *= 5;
        }
        
        return Math.Round(answer,2);
    }
    public int Task_1_10()
    {
        int answer= 1;

        int counter = 0;
        while (counter < 7)
        {
            answer *= 3;
            counter++;
        }
      
        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i =1; i<=6; i++)
        {
            Console.Write(i);
        }
        int a = 0;
        Console.WriteLine();
        while (a < 6)
        {
            Console.Write(5);
            a++;
        }

        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 1;
        double numinpow = 1;
        for (double i = 1; i<=10; i++)
        {
            answer += 1 / numinpow;
            numinpow *= x;
        }
        
        return Math.Round(answer,2);
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        if (x <= -1)
        {
            answer = 1;
        }
        else if(x>-1 && x <= 1)
        {
            answer = -1 * x;
        }
        else
        {
            answer = -1;
        }

        return Math.Round(answer,2);
    }
    public void Task_1_14()
    {
        int x = 0;
        int y = 1;
        int newfibonschi = 1;
        Console.WriteLine(y);
        for (int i=0; i<=6; i++)
        {
            newfibonschi = x + y;
            x = y;
            y = newfibonschi;
            Console.WriteLine(y);   
        }
    }
    public double Task_1_15()
    {
        double answer = 0;
        double x = 0;
        double numenator = 1;
        double a = 0;
        double denominator = 1;
        double newfibonschi = 1;
        
        for (int i = 0; i <= 4; i++)
        {
            newfibonschi = x + numenator;
            x = numenator;
            numenator = newfibonschi;
            
        }
        for (int i = 0; i <= 3; i++)
        {
            newfibonschi = a + denominator;
            a = denominator;
            denominator = newfibonschi;

        }
        
        answer = numenator / denominator;
        return Math.Round(answer,2);
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;
        double numinpower = 1;
        for (power = 0; power<=63; power++)
        {
            answer += numinpower;
            numinpower *= 2;
        }
        answer = answer / 15;
        power =(int) Math.Log10(answer);
        numinpower = 1;
        for (double i =0; i<power; i++)
        {
            numinpower *= 10;
        }
        Console.WriteLine(Math.Round(answer / numinpower, 2)+"   "+power);
        return (Math.Round(answer/numinpower,2), power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        int r = 6350;
        answer = Math.Sqrt((r + x)*(r+x) - r*r);
        
        return Math.Round(answer,2);
    }
    public int Task_1_18(int x)
    {
        int answer = 0;
        int truepow = 1;
        for (int i = 1; i<=x/3; i++)
        {
            truepow *= 2; 
        }
        answer = truepow * 10;

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
        int p = 1;
        int proizvedenie = 1;
        while (proizvedenie <= 30000)
        {
            answer = p;
            p += 3;
            proizvedenie *= p;
            
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
        if (x == 1)
            return 0;
        double answer = 0;
        double numinpow = 1;
        
        for (int i = 0; i < 10000; i ++)
        {
            answer += numinpow;
            numinpow = numinpow * x * x;
            
            if (numinpow < 0.0001)
            {
                return Math.Round(answer, 2);

            }
            
        }
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
        double solve = 10;
        double numipow = 1;
        while (solve < 100000)
        {
            solve += numipow*10;
            numipow *= 2;
            answer++;
        }
        
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

        double firstDeposit = 10000;
        while (firstDeposit <= 20000)
        {
            firstDeposit += 0.08 * firstDeposit;
            answer++;
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
    public int Task_2_10()
    {
        
        int counter = 2;
        double numenator1 = 1;
        double denominator1 = 1;
        double numenator2 = 2;
        double denominator2 = 1;
        
        
        while (Math.Abs(numenator2/denominator2 - numenator1 / denominator1) >= 0.001)
        {
            double numinator3 = numenator2;
            double denominator3 = denominator2;
            denominator2 += denominator1;
            numenator2 += numenator1;
            denominator1 = denominator3;
            numenator1= numinator3;
            counter++;
        }

        
        return counter;
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
        double S = 0, y = 0,z =1, i=1;

        
            y = ((1 + x*x) * Math.Atan(x)) / 2 - (x / 2);
            
                
           while (Math.Abs(z) >= 0.0001)
           {
            double num1, num2=1;
            if (i % 2 == 0)
            {
                num1 = -1;
            }
            else
            {
                num1 = 1;
            }
            for (int j = 0; j < 2 * i + 1; j++)
            {
                num2 *= x;
            }
              
           z = num1*num2 / (4 * i * i - 1);
               
           S += z;
           i++;
           }
            
        
        
        Console.WriteLine(Math.Round(S, 10)+"   "+ Math.Round(y, 2));
        return (Math.Round(S,2), Math.Round(y,2)); 
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

    public int Fact(int x)
    {
       
        int count = 1;
        int a = 1;
        
        while (count<=x)
        {
            a *= count;
            count++;
        }
        return (a);
    }
    
}
