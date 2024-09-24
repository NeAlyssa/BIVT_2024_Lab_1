using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        Console.WriteLine("Hello");
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
        for (int i = 2; i<36 ;i=i+3)
        {
            answer+=i;
        }

        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for ( double i =1 ; i<11; i++)
        {
            answer = answer + 1/ i;
        
        }  
        // end

        return Math.Round(answer,2);
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2; i<113; i=i+2)
        {
            answer += i/(i+1);
        }

        // end

        return Math.Round(answer,2);
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
      
        if (x==0)
        {
            return 0;
        }

        // code here
        for (double i = 1, k =1;i<10; i++)
        {
            answer += Math.Cos(x*i)/k;
            k=k*x;
        }

        // end

        return Math.Round(answer,2);
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i=0;i<10;i++)
        {
            answer+= (p + h*i)*(p + h*i);
        }


        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer= 0.5*x*x-7*x;
        // end

        return Math.Round(answer,2);
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for (int i =1 ; i<=6; i++)
        {
            answer*= i;
        }
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;
        // code here;
        for (int i = 1,f=1; i<7; i++)
        {
            f=f*i;
            answer+=f;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        for (double  i = 1, ed = -1, p=5, f=1; i<=6; i++)
        {
            f*=i;
            answer+= ed* p/f;
            ed*= -1;
            p*=5;
        }
        // end

        return Math.Round(answer,2);
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        for (int i =1; i<=7;i++)
        {
            answer*=3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i =1; i<=6; i++)
        {
            Console.Write($"{i }");
        }
        Console.WriteLine();
        for (int i =1; i<=6;i++)
        {
            Console.Write ($"{5 }");
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        for (double  i =1, r =1; i<=11;i++)
        {
            if (x == 0)
            {
                return answer;
            }
            answer+=1/r;
            r*=x;
        }
        // end

        return Math.Round(answer,2);
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
        {
            answer=1;
        }
        if (x > -1 && x<=1)
        {
            answer=-x;
        }
        if (x >1)
        {
            answer = -1;
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        for (int i =1,a=1,b=0,s=0; i<=8;i++)
        {
            s=a+b;
            Console.WriteLine(s);
            a=b;
            b=s;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
       for (double i =1, a=1,b=1,k=0;i<=5;i++)
       {
        answer=a/b;
        k=a+b;
        b=a;
        a=k;
       }
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 1;
        int power = 0;
        double g, s=0;
        // code here
        for (double i= 1,k=1;i<=64;i++)
        {
            s+=k;
            k=k*2;
        }
        g=s/15;
        while (g >=2)
        {
            g/=10;
            power++;
        }
        answer=Math.Round(g,2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        double r=6350;
        // code here
        answer=Math.Sqrt((r+x)*(r+x) - r*r);
        // end

        return Math.Round(answer,2);
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here
        for (int i=0;i<x;i=i+3)
        {
            answer=answer*2;
        }
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
        int answer = 1;

        // code here
        for (int i=1,L=1;L<30000;i+=3)
        {
            L=L*i;
            if (L<=30000)
            {
                answer=i;
            }
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
        double answer = 1, res=x*x;
        answer+=res;
        // code here
        if (x==1)
        {
            return 0;
        }
        while (res >=0.0001)
        {
            res*=x*x;
            answer+=res;
        }
        // end

        return Math.Round(answer,2);
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
        for (int i = 3,s=10; s <= 100000;i+=3)
        {
            s=s*2;
            answer=i;
        }
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
        double s = 10000;
        // code here;
        for (int i =1 ; s<=20000;i++)
        {
            s+=s*0.08;
            answer=i;
        }
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
        int answer = 1;

        // code here;
        double   a=1,b=1,k=0,res1=0, res2=1;
        while (Math.Abs(res2 - res1) > 0.001)
       {
        answer++;
        res1=a/b;
        k=a+b;
        b=a;
        a=k;
        res2 = a/b;
        System.Console.WriteLine(res1);
        System.Console.WriteLine(res2);
        
       }
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
        double i = 0, n1=1, n2=1, d=1;
        double res= n1*n2/d;
        while (Math.Abs(res)>=0.0001)
        {
            S+=res;
            i++;
            n1=2*i+1;
            n2*=x*x;
            d*=i;
            res=n1*n2/d;
        }
        y=(1+2*x*x)*Math.Exp(x*x);
        // end
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
