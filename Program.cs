using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
        //program.Task_1_4(1);
        //program.Task_1_5(0, 2);
        //program.Task_1_6(-4);
        //program.Task_1_7();
        //program.Task_1_8();
        //program.Task_1_9();
        //program.Task_1_10();
        //program.Task_1_11();
        //program.Task_1_12(4);//Деление на 0
        //program.Task_1_13(-1.5);
        //program.Task_1_14();
        //program.Task_1_15();
        //program.Task_1_16();
        //program.Task_1_17(1);
        //program.Task_1_18(24);
        //program.Task_2_1(0);
        //program.Task_2_2();
        //program.Task_2_3(1, 1, 10);
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
        for(int i=2;i<=35;i+=3)
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
        answer = Math.Round(answer,2);
        Console.WriteLine(answer);
        // end
        
        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2; i <= 112; i+=2)
        {
            answer += i/(i+1);
        }
        answer = Math.Round(answer);
        Console.WriteLine(answer);
        // end
        
        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if(x==0)
            return answer;
        double del = 1;
        for (double i = 1; i <= 9; i++)
        {

            answer += Math.Cos(x*i)/del;
            del = del * x;
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
        for (int j = 0; j <= 9; j++)
        {
            answer+=(p + h * j)* (p + h * j);
        }
        // end
        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * x * x - 7 * x;
        answer= Math.Round(answer, 2);
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for (int i = 1; i <= 6; i++)
        {
            answer = answer * i;
        }
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int y = 1;
        for (int i = 1; i <= 6; i++)
        {
            y = y * i;
            answer += y;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        int y = 1;
        double x = 5;
        int p = -1;
        for (int i = 1; i <= 6; i++)
        {
            y = y * i;
            answer += p * x / y;
            x = x * 5;
            p = -p;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        for (int i = 1; i <= 7; i++)
        {
            answer = answer * 3;
        }
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        string ans1 = "";
        string ans2 = "";
        for (int i = 1; i <= 6; i++)
        {
            ans1=ans1+i+" ";
            ans2=ans2+"5 ";
        }
        Console.WriteLine(ans1);
        Console.WriteLine(ans2);
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x == 0)
            return answer;
        double a = 1;
        for (double i = 0; i <= 10; i++)
        {
            answer = answer + 1 / a;
            a = a * x;
        }
        answer = Math.Round(answer, 2);
        // end
        Console.WriteLine(answer);
        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        while (x <= -1)
        {
            answer = 1;
            break;
        }
        while (-1<x&&x<=1)
        {
            answer = -x;
            break;
        }
        while (x > 1)
        {
            answer = -1;
            break;
        };

        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int a1 = 1;
        int a2 = 1;
        int c = 0;
        string ans = a1+" "+a2+" ";
        for (int i = 1; i <= 6; i++)
        {
            c = a1;
            a1 = a2;
            a2 = c + a2;
            ans += a2+" ";
        }
        Console.WriteLine(ans);
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        double a1 = 1;
        double a2 = 1;
        double c = 0;
        for (int i = 1; i <= 6;i++)
        {
            c = a1;
            a1 = a2;
            a2 = a1 + c;
            answer = a2 / a1;
        }
        answer = Math.Round(answer, 1);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double a = 1;
        for (int i = 0; i <= 63; i++)
        {
            answer += a;
            a = a * 2;
        }
        answer = answer / 15;
        power = (int)Math.Log10(answer);
        double st = 1;
        for(int i =1;i<=power;i++)
            st = st * 10;
        answer = answer / st;
        answer = Math.Round(answer, 3);
        // end
        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        answer = Math.Sqrt((6350 + x) * (6350 + x) - 6350 * 6350);
        answer = Math.Round(answer, 2);        
        // end
        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here
        for (int i = 3; i <= x; i += 3)
        {
            answer = answer * 2;
            Console.WriteLine(answer);
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
        double zn = 1;
        double n = 1;
        while (Math.Abs(zn) >= 0.0001)
        {
            zn = Math.Cos(n * x) / (n * n);
            n += 1;
            answer += zn;
            //Console.WriteLine(zn);
        }
        //Console.WriteLine(answer);
        answer -= zn;
        answer = Math.Round(answer, 2);
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

        // code here
        double s = 0;
        double zn = 0;
        int n = 0;
        int flag = 0;
        while (s <= p && h>0)
        {
            flag = 1;
            zn = a + h * n;
            n += 1;
            s += zn;
            //Console.WriteLine(s);
        }
        answer = n - flag;
        Console.WriteLine(answer);
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
        if(N==0||M==0)
            return (quotient, remainder);
        if (N < 0 && M < 0)
        {
            N = -N;
            M = -M;
        }
        while (N - M >= 0)
        {
            quotient += 1;
            N = N - M;
        }
        remainder = N;
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

        // code here
        double n = 1;
        double norma = 10;
        while (n<=7)
        {
            answer = answer + norma;
            norma = norma * 1.1;
            n += 1;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        int n = 0;
        double norma = 10;
        double s = 0;
        while (s<100)
        {
            s = s + norma;
            norma = norma * 1.1;
            n += 1;
        }
        answer = n;
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        int n = 0;
        double norma = 10;
        double s = 0;
        while (norma<=20)
        {
            n = n + 1;
            norma = norma * 1.1;
        }
        answer = n;
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

        // code here;
        double atm = 1;
        double l = 0.1;
        for (int i = 1; i <= 10; i++)
            atm = atm / 10;
        while (l > atm)
        {
            answer += 1;
            l = l / 2;
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
        double a, b, zn, i;
        double j;
        a = 1;
        b = 1;
        i = 0;
        zn = 1;
        S = 1;
        while (Math.Abs(a / b) >= 0.0001 && x!=0)
        {
            i += 1;
            a = a * x * x;
            b = b * (2 * i) * (2 * i - 1);
            zn = a / b;
            S += zn;

        }
        S = S - zn;
        y = (Math.Exp(x) + 1 / Math.Exp(x)) / 2;

        Console.WriteLine(S);
        S = Math.Round(S,3);
        Console.WriteLine(S);

        y = Math.Round(y, 2);
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