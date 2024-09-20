using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

        // program.Task_1_1();
        // program.Task_1_2();
        // program.Task_1_3();
        // program.Task_1_4(0.5);
        // program.Task_1_5(0, 2);
        // program.Task_1_6(4);
        // program.Task_1_7();
        // program.Task_1_8();
        // program.Task_1_9();
        // program.Task_1_10();
        // program.Task_1_11();
        // program.Task_1_12(1.35);
        // program.Task_1_13(-1.5);
        // program.Task_1_14();
        // program.Task_1_15();
        // program.Task_1_16();
        // program.Task_1_17(10);
        // program.Task_1_18(24);
        // program.Task_2_1(0);
        // program.Task_2_2();
        //program.Task_2_3(8, 2, 0);
        // program.Task_2_4(0.8);
        //program.Task_2_5(11, 5);
        // program.Task_2_6();
        //program.Task_2_7a();
        //program.Task_2_7b();
        //program.Task_2_7c();
        //program.Task_2_8();
        //program.Task_2_9();
        // program.Task_2_10();
        //program.Task_3_1(0.1);
        //program.Task_3_2(0.1);
        //program.Task_3_3(0.1);
        //program.Task_3_4(0.1);
        //program.Task_3_5(double.Pi/5);
        program.Task_3_6(0.2);
        //program.Task_3_7(0.1);
        //program.Task_3_8(0.1);
        // program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;

        for (int i = 2; i<=35; i+=3)
        {
            answer+=i;
        }

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        for (double i=1;i<=10;i++)
        {
            answer+=1/i;
        }
        answer=Math.Round(answer,2);

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;
        for (double i=2;i<=112;i+=2)
        {
            answer+=i/(i+1);
        }
        answer=Math.Round(answer,2);

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        if (x==0)
        {
            return 0;
        }
        for (int i=0; i<=8;i++)
        {
            answer+=Math.Cos((1+i)*x)/Math.Pow(x,i);
        }
        answer=Math.Round(answer,2);

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        for (int i=0; i<=9; i++)
        {
            answer+=Math.Pow(p+i*h,2);
        }
        Console.WriteLine(answer);

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // for (double i=-4;i<=4;i+=0.5)
        // {
        //     answer = Math.Round((0.5*Math.Pow(i,2)-7*i),2);
        //     Console.WriteLine(answer);
        // }
        answer = Math.Round((0.5*Math.Pow(x,2)-7*x),2);
        return answer;
    }
    public int Task_1_7()
    {
        int answer = 0;

        answer+=1;
        for (int i=1; i<=6;i++)
        {
            answer*=i;
        }
        Console.WriteLine(answer);

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        for (int number=1; number<=6;number++)
        {
            int factorial=1;
            for (int i=1; i<=number;i++)
            {
                factorial*=i;
            }
            answer+=factorial;
        }
        Console.WriteLine(answer);

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        for (int i=1; i<=6;i++)
        {
            int factorial=1;
            for (int j=1; j<=i;j++)
            {
                factorial*=j;
            }
            answer+=Math.Pow(-1,i)*Math.Pow(5,i)/factorial;
        }
        answer=Math.Round(answer,2);

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;

        for (int i=1; i<=7;i++)
        {
            answer*=3;
        }
        Console.WriteLine(answer);
        return answer;
    }
    public void Task_1_11()
    {
        for (int i=1;i<=6;i++)
        {
            if (i<=5)
            {
                Console.Write($"{i} "); 
            }
            if (i==6)
            {
                Console.WriteLine($"{i}"); 
            }
        }
        for (int i=1;i<=6;i++)
        {
            if (i<=5)
            {
                Console.Write($"{5} "); 
            }
            if (i==6)
            {
                Console.WriteLine($"{5}"); 
            }
        }

    }
    public double Task_1_12(double x)
    {
        double answer = 0;
        answer+=1;
        if (x==0)
        {
            return 0;
        }
        for(int i=1;i<=10;i++)
        {
            answer+=1/Math.Pow(x,i);
        }
        answer=Math.Round(answer,2);

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;
        // for (double i=-1.5; i<=1.5;i+=0.1)
        // {
        //     if(i<=-1)
        //     {
        //         Console.WriteLine(1);
        //     }
        //     else if(i>-1 & i<=1)
        //     {
        //         Console.WriteLine(Math.Round(-i,1));
        //     }
        //     else if(i>1)
        //     {
        //         Console.WriteLine(-1);
        //     }
        // }

        if (x <= -1)
            answer = 1;
        else if (x>-1 & x<=1)
            answer = -x;
        else
            answer = -1;

        return answer;
    }
    public void Task_1_14()
    {
        // List<int> numbers = new List<int>();
        // numbers.Add(1);
        // numbers.Add(1);
        // for (int i=2;i<=8-1;i++)
        // {
        //     numbers.Add(numbers[i-1]+numbers[i-2]);
        // }
        // for (int j=0;j<numbers.Count;j++)
        // {
        //     Console.WriteLine(numbers[j]);
        // }
        int a=1, b=1;
        System.Console.WriteLine(a);
        System.Console.WriteLine(b);
        for(int i=1;i<=6;i++)
        {
            int c=a+b;
            Console.WriteLine(c);
            a=b;
            b=c;
        }
    }
    public double Task_1_15()
    {
        double answer = 0;

        // List<double> ch = new List<double>();
        // ch.Add(1);
        // ch.Add(2);
        // for (int i=2;i<=4;i++)
        // {
        //     ch.Add(ch[i-1]+ch[i-2]);
        // }
        // List<double> zn = new List<double>();
        // zn.Add(1);
        // zn.Add(1);
        // for (int i=2;i<=4;i++)
        // {
        //     zn.Add(zn[i-1]+zn[i-2]);
        // }
        // answer=ch[4]/zn[4];

        double ch1=1,ch2=2;
        double zn1=1,zn2=1;
        for (int i=0;i<=1;i++)
        {
            double ch3=ch1+ch2;
            double zn3=zn1+zn2;
            ch1=ch2;
            ch2=ch3;
            zn1=zn2;
            zn2=zn3;
        }
        answer=ch2/zn2;

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 18;

        answer+=1;

        for (int i = 1; i<=63; i++)
        {
            answer += Math.Pow(2,i);
        }
        answer=Math.Round(answer/15/Math.Pow(10,power),2);

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;
        // for (int height=1;height<=10;height++)
        // {
        // answer = Math.Round(Math.Sqrt(Math.Pow(6350+height,2) - Math.Pow(6350,2)),2);
        // System.Console.WriteLine(answer);
        // }
        answer = Math.Round(Math.Sqrt(Math.Pow(6350+x,2) - Math.Pow(6350,2)),2);
        return answer;
        
    }   
    public int Task_1_18(int x)
    {
        int answer = 0;
        answer+=10;
        for (int i=3;i<=x;i+=3)
        {
            answer*=2;
        }
        System.Console.WriteLine(answer);
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
        int i=1;
        while (answer<=30000)
        {
            i+=3;
            answer*=i;
        }
        answer=i-3;
        // тк лишный раз заходит в цикл
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
        double answer = 1;
        int i=2;
        if (Math.Abs(x)>=1)
        {
            return 0;
        }
        while(true)
        {
            if (Math.Pow(x,i)<0.0001)
            break;
            answer+=Math.Pow(x,i);
            i+=2;
        }
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
        int answer = 10;
        int count=0;

        while(answer<100000)
        {
            answer*=2;
            count+=1;
        }
        System.Console.WriteLine(count*3);
        // тк деление происзодит каждые 3 часа
        return count*3;
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
        double summa=10000;

        while(true)
        {
            if (summa>=20000)
            break;
            summa*=1.08;
            answer+=1;
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
        int answer = 0;
        
        double ch1=1,ch2=2;
        double zn1=1,zn2=1;
        while(Math.Abs(ch1/zn1-ch2/zn2)>=0.001)
        {
            double ch3=ch1+ch2;
            double zn3=zn1+zn2;
            ch1=ch2;
            ch2=ch3;
            zn1=zn2;
            zn2=zn3;
            answer+=1;
        }
        answer+=2;
        // +2 тк уже было 2 числа в переди то есть 1/1 и 2/1

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
        int i=1;
        while(true)
        {
            double sugma=Math.Pow(-1,i+1)*Math.Pow(x,2*i+1)/(4*i*i-1);
            if (Math.Abs(sugma)<0.00001)
            break;
            S+=sugma;
            i++;
        }
        y=(1+Math.Pow(x,2))*Math.Atan(x)/2-x/2;
        // y=Math.Round(y,2);
        // S=Math.Round(S,2);
        System.Console.WriteLine(S);
        System.Console.WriteLine(y);


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
