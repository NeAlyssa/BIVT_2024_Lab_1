using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        for (double x = -4; x <= 4; x += 0.5);
        //program.Task_1_6(4);
        //program.Task_1_7();
        //program.Task_1_8();
        //program.Task_1_9();
        //program.Task_1_10();
        //program.Task_1_11();
        //program.Task_1_12(0.9);
        for (double x = -1.5; x <= 1.5; x += 0.1);
        //program.Task_1_13(-1.5);
        //program.Task_1_14();
        //program.Task_1_15();
        //program.Task_1_16();
        //program.Task_1_17(10);
        //program.Task_1_18(24);
        //program.Task_2_1(0);
        //program.Task_2_2();
        //program.Task_2_3(8, 2, 0);
       //rogram.Task_2_4(0.8);
        //program.Task_2_5(11, 5);
      // program.Task_2_6();
        //program.Task_2_7a();
        //program.Task_2_7b();
        //program.Task_2_7c();
        //program.Task_2_8();
        //program.Task_2_9();
        //program.Task_2_10();
        //program.Task_3_1(0.1);
        for (double x = 0.1; x <= 0.8; x += 0.1);
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
        // code here

        for (int i = 2; i <= 35; i += 3)
        {
           answer += i;
        }

        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        
        for(int i=1; i<=10; i++)
        {
            answer = answer + (1.0 / i);
            answer = Math.Round(answer, 2);
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;
        // code here
        for (int i = 2; i <= 112; i+=2)
        {
            answer = answer + ((double)i / (i+1));
        }
        answer = Math.Round(answer, 1);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        for (int i=1; i<=9; i++)
        {
            if (x == 0)
            {
                answer = 0;
            }
            else
            {
                answer += Math.Cos(x * i) / Math.Pow(x, (i - 1));
            }
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
        for(int i=0; i<=9; i++)
        {
            answer += Math.Pow(p + i * h, 2);
        }
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = 0.5 * Math.Pow(x, 2) - 7 * x;
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for(int i = 1; i<=6; i++)
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
        int ans = 1;
        for (int i = 1; i <= 6; i++)
            {
                ans = ans * i;
                answer += ans;
            }
          
       
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        int ans = 1;
        for (int i = 1; i <= 6; i++)
        {
            ans = ans * i;
            answer += Math.Pow(-1,i) * Math.Pow(5,i) / ans;
        }
        answer = Math.Round(answer,2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 3;

        // code here
        for(int i = 1; i<=6; i++)
        {
            answer *= 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for(int i=1; i<=6; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        for (int i = 1; i <= 6; i++)
        {
            Console.Write("5" + " ");
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        for(int i=0; i<=10; i++)
        {
            if(x == 0)
            {
                answer = 0;
            }
            else
            {
                answer += 1 / Math.Pow(x, i);
            }
        
        }
        answer = Math.Round(answer,2);  
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;

        // code here
        if(x <= -1)
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
        int answer = 0;
        Console.WriteLine(a);
        Console.WriteLine(b);
        for(int i = 3; i<=8; i++)
        {
            answer = a + b;
            Console.WriteLine(answer);
            a = b;
            b = answer;
          
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;

        // code here
        int first_top = 1;
        int first_bottom = 1;
        int second_top = 2;
        int second_bottom = 1;
        Console.WriteLine($"1-й член: {first_top}/{first_bottom}");
        Console.WriteLine($"2-й член: {second_top}/{second_bottom}");
        for (int i=0; i<3; i++)
        {
           int third_top = first_top + second_top;
           int third_bottom = second_bottom + first_bottom ;
           Console.WriteLine($"{i + 3}-й член: {third_top}/{third_bottom}");
            first_top = second_top;
            first_bottom = second_bottom;
            second_top = third_top;
            second_bottom = third_bottom;
            answer = (double)third_top / third_bottom;
        }
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        double suma = 1;
        for (int i = 1; i < 64; i++)
        {
            suma+= Math.Pow(2, i);
        }
        double gram = suma / 15;
        answer = Math.Round(gram, 2);
        while (answer > 10)
        {
            power += 1;
            answer /= 10;
        }
        answer = Math.Round(answer, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        double r = 6350;
        {
         double d = Math.Sqrt(Math.Pow(r + x, 2) - Math.Pow(r, 2));
         answer = Math.Round(d,2);
         Console.WriteLine(answer);

        }
        
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;

        // code here
        answer = 10 * (int)Math.Pow(2, x / 3);
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
        int l = 1;
        for(int n = 1; n < 50; n += 3)
        {
            l *= n;
            if (l > 30000) 
            {
                break;
            }

            answer = n;

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
        // code here
        double answer = 0;
        double current = 0;
        for(int n = 0; n <= 1000000; n+=2)
        {
            if (Math.Abs(x) >= 1) break;
            current = Math.Pow(x, n);
            if (current < 0.0001) break;
            answer += current;
         }
        answer = Math.Round(answer,2);

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
        int cout = 10;
        while(cout <= Math.Pow(10,5))
        {
            cout *= 2;
            answer += 3;
            
        }
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
        double suma = 10000;
        while(suma <= 20000)
        {
            suma = suma + 0.08 * suma;
            answer += 1;
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
        int answer = 2;

        // code here;
        int first_top = 1;
        int first_bottom = 1;
        int second_top = 2;
        int second_bottom = 1;
        while(Math.Abs((double)second_top/second_bottom - (double)first_top /first_bottom) >= 0.001)
        {
            int third_top = first_top + second_top;
            int third_bottom = second_bottom + first_bottom;
            first_top = second_top;
            first_bottom = second_bottom;
            second_top = third_top;
            second_bottom = third_bottom;
            answer += 1;
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
        for (int i = 1; i < 10000; i++)
        {
            double s_new = Math.Pow(x, i) * Math.Sin(i * Math.PI / 4);
            if (Math.Abs(Math.Pow(x,i)) < 0.0001)
                break;

            S += s_new;
        }        
        y = (x * Math.Sin(Math.PI / 4)) / (((1 - 2 * x * Math.Cos(Math.PI / 4))) + Math.Pow(x, 2));
        
        S = Math.Round(S,2);
        y = Math.Round(y,2);
        Console.WriteLine(S);
        Console.WriteLine(x);
        Console.WriteLine(y);
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