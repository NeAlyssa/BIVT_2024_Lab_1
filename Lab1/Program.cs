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
        for (int x = 2; x <= 35; x = x + 3) 
        {
            answer = answer + x;

        }
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        
        for (int a = 1; a <= 10; a ++)
        {   answer = answer + 1.0 / a;
            answer = Math.Round(answer, 2);

        }
            

        
        
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0.0;

        // code here
        for (int a = 2; a <= 112; a = a + 2)
        {
            answer = answer + a / (a + 1.0);
            
        }
        answer = Math.Round(answer, 0);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        double f = 1;
        // code here
        for (int a = 1;a<=9;a++)

        {
            if (x != 0)
            {
                answer += Math.Cos(a * x) / f;
                f = f * x;
            }
            else
                answer = 0;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
       
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int a = 0; a <= 9; a++)
            answer = answer + (p + h * a) * (p + h * a);
            // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        for ( double a=-4; a<5; a+=0.5)
        {
            answer = 0.5 * x * x - (7 * x);
            answer=Math.Round(answer, 2);
        }
        
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        // code here
        int f = 1;
        for (int a = 1; a <= 6; a++)
            f = f * a;
        answer = f;
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int f = 1;
        for (int a = 1; a <= 6; a++)
        {
            f = f * a;
            answer += f;
        }


            


        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        double f = 1; double c = 1; double d = 1;
        // code here;
        for (int a = 1; a <= 6; a++)

        {
            f = a * f;
            c = c * (-1);
            d = d * 5;

            answer = answer + (c*d)/f;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 0;
        int f = 1;
        // code here
        for (int a = 1; a <= 7; a++)
        {
            f = f * 3;
            answer = f;
        }
       
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int a=1;a<=6; a++)
        {
            Console.Write(a);
        }
        Console.WriteLine();
        for (int a = 1; a <= 6; a++)
        {
            Console.Write(5);
        }

        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;
        double f = 1;
        // code here
        for (int a = 0;a<=10;a++)
        {
            if(x!=0)
            {
                answer += 1 / f;
                f =f* x;
            }
            else
            {
                answer = 0;
            }
               
            
        }
        answer=Math.Round(answer, 2);
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
        else if (x > 1)
        {
            answer = -1;
        }
        else
        {
            answer = -x;
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a = 1;
        int b = 1;
        int c = 0;
        int f = 0;
        Console.WriteLine(a);
        Console.WriteLine(b);
        for (int i=1;i<=6;i++)
        {
            Console.WriteLine(a+b);
            f=a+b;
            c = a;
            a = b;
            b = f;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;
        double ch1 = 1;
        double ch2 = 2;
        double zn1 = 1;
        double zn2 = 1;
        double ch3 = 0;
        double zn3 = 0;
        // code here
        for (int a=1;a<=3; a++)
        {
            ch3 = ch1 + ch2;
            zn3 = zn1 + zn2;
            ch1 = ch2;
            zn1 = zn2;
            zn2 = zn3;
            ch2 = ch3;
            answer = ch3 / zn3;
        }
       
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;
        double z = 0;
        double zk = 1;
        // code here
        for (int i = 1; i <=64; i++)
        {
            z += zk;
            zk *= 2;
            
        }
        answer = z / 15;
        while (answer >= 10.0)
        {
            answer /= 10.0;
            power++;
        }
        answer = Math.Round(answer, 2);
        // end
       

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        const double r = 6350.0;

        // code here
        answer = Math.Sqrt(x*(2*r+x));
        // end
        answer = Math.Round(answer, 2);
        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here
        for (int i = 0; i < x; i += 3)
        {
            answer *= 2;
        }
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;
        double n = 1;
        int i = 1;
        // code here
        while (n>=0.0001)
        {
            answer += Math.Cos(i * x) / (i * i);
            i++;
            n = Math.Abs(Math.Cos(i * x) / (i * i));
            
        }
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
        int answer = 0;
        double s = 0;
        if (p>=a+h & h > 0)
        {
            while (s<=p)
            {
                answer++;
                s += a + answer * h;
            }
                
            
        }
         else
         {
              answer = 0;
         }
            
        
     
        // end
           
           


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

        // code here
        if (N==0 || M == 0)
        {
            remainder = 0;
            quotient = 0;
        }
        else if (N > M)
        {
            while (N >= M)
            {
                N-=M;
                quotient++;
                remainder = N;
                
            }
        }
        else
        {
            while (N <= M)
            {
                M -= N;
                quotient++;
                remainder = M;
            }
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
        double answer = 0;
        double s = 10;


        // code here
        for (int i=1;i<=7;i++)
        {
            answer+=s;
            s = s * 1.1;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;
        double s = 10;
        double n = 0;
        // code here
        while (n<100)

        {
            n += s;
            answer++;
            s *= 1.1;
            
        }
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;
        double s = 10;
        // code here
        while (s<20)
        {
            s *= 1.1;
            answer++;
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
        double d = 0.0000000001;

        // code here;


        // code here;
        while (l > d)
        {
            l = l / 2;
            answer++;
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
        double i = 0;
        double n1 = 1;
        double n2 = 1;
        double d = 1;
        double part = n1 * n2 / d;
        while (Math.Abs(part)>=0.0001)
        {
            S += part;
            i++;
            n1 *= (-1);
            n2 *= x * x;
            d *= (2 * i - 1) * (2 * i);
            part=n1 * n2 / d;
            
          
        }
        y = Math.Cos(x);
        y = Math.Round(y, 2);
        S = Math.Round(S, 2);
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
