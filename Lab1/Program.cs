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
        //Console.WriteLine(program.Task_1_6(4));
        //program.Task_1_7();
        //program.Task_1_8();
        //program.Task_1_9();
        //program.Task_1_10();
        //Console.WriteLine(program.Task_1_11());
        //Console.WriteLine(program.Task_1_12(0.9));
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
        program.Task_3_6(1);
        //program.Task_3_7(0.1);
        //program.Task_3_8(0.1);
        //program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {
        int answer = 0;

        // code here
        for (int i = 2; i < 36; i += 3)
            answer += i;
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (double i = 1; i < 11; i += 1)
            answer += 1 / i;
        // end

        return Math.Round(answer, 2);
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (double i = 2; i < 113; i += 2)
            answer += i / (i + 1);
        // end

        return Math.Round(answer, 2);
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        double r = 1;
        // code here
        if (x == 0)
            return 0;
        for (double i = 1; i < 10; i += 1)
        {

            answer += Math.Cos(x * i) / r;
            r = r * x;
            // end
        }
        return Math.Round(answer, 2);
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;

        // code here
        for (int i = 1; i < 11; i++)
            answer += (p + h * (i - 1))* (p + h * (i - 1));
        // end

        return Math.Round(answer, 2);
    }
    public double Task_1_6(double x)
    {
        double answer = 0;
        // code here
        for (double i = -4; i < 4.1; i += 0.5)
        {
            answer = 0.5 * x*x - 7 * x;

        }
        return Math.Round(answer, 2);
        // end


    }
    public int Task_1_7()
    {

        int x = 6;
        int i = 1;
        int s = 1;
        // code here
        while (i <= x)
        {
            s = s * i;
            i += 1;
        }


        // end

        return s;
    }
    public int Task_1_8()
    {
        int answer = 0;
        int x = 1;
        // code here;
        for (int i = 1; i < 7; i++)
        {
            x = x * i;
            answer += x;
        }
        // end

        return answer;

    }
    public double Task_1_9()
    {
        double answer = 0;
        double a = 0;
        double v = 1;
        double k = -1;
        double l = 5;
        // code here;
        for (double i = 1; i < 7; i++)
        {
            v = v * i;
            a = (k * l / v);
            answer += a;
            k *= -1;
            l *= 5;
        }
        // end

        return Math.Round(answer, 2);
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        for (int i = 1; i < 8; i++)
            answer = answer * 3;
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        int a = 1;
        int b = 2;
        int c = 3;
        int d = 4;
        int e = 5;
        int f = 6;
        Console.WriteLine("{0} {1} {2} {3} {4} {5}", a, b, c, d, e, f);
        Console.WriteLine("{4} {4} {4} {4} {4} {4}", a, b, c, d, e, f);

        // code here

    }
    public double Task_1_12(double x)
    {
        double t = x;
        double answer = 1;
        if (x == 0)
            return 0;
        // code here
        for (double i = 1; i < 11; i++)
        {
            answer += 1 / t;
            t *= x;
        }
        // end

        return Math.Round(answer, 2);
    }
    public double Task_1_13(double x)
    {


        // code here
        if (x < -1)
            return 1;
        else if (x > 1)
            return -1;
        else
            return (-x);

        // end


    }
    public void Task_1_14()
    {
        int u = 1;
        int r = 1;
        int w = 0;
        Console.WriteLine(u);
        Console.WriteLine(r);
        // There is no test for this task
        for (int i = 1; i < 9; i++)
        {
            Console.WriteLine(u + r);
            w = u + r;
            r = u;
            u = w;

        }




        // code here

    }
    public double Task_1_15()
    {
        double answer = 1;
        double power = 1;
        double p = 3;

        // code here
        for (int i = 1; i < 5; i++)
        {
            p = answer + power;
            power = answer;
            answer = p;


        }
        // end

        return (Math.Round(answer / power, 2));


        // code here

        // end

    }
    public (double, int) Task_1_16()
    {
        int power = 0;
        double u = 1;
        double answer = 1;
        for(int i=1;i<64;i++)
          {
            u *= 2;
            answer += u;
          }
        answer = answer / 15;
        while (answer >= 10)
          {
            answer = answer / 10;
            power += 1;
          }
        Console.WriteLine((Math.Round(answer, 2), power));  

        return (Math.Round(answer, 2), power);


    }
    public double Task_1_17(double x)
    {


        // code here
        double t = 6350;


        double r = t * t;
        double u = (t + x) * (t + x);
        double m = u - r;
        double s = Math.Sqrt(m);

        return (Math.Round(s, 2));


        // end


    }
    public int Task_1_18(int x)
    {
        int e = 10;
        for (int i = 0; i < (x / 3); i++)
            e = e * 2;
        x = e;


        // code here

        // end

        return x;
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

        int x = 1;
        int b = 1;
        // code here
        while (x <= 30000)
        {
            b += 3;
            x = x * b;


        }
        // end
        //Console.WriteLine(b-3);
        return (b - 3);
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
        double v = x * x;
        if (Math.Abs(x) >= 1)
            return 0;
        while(v>0.0001)
        {
            answer += v;
            v = v * x * x;
        }

        return Math.Round(answer, 2);
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
        

        // code here
        int d = 10;
        int e = 0;
        while(d<=1e5)
        {
            e += 3;
            d *= 2;
        }
        // end

        return e;
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
        double y = 10;
        while(y<20)
        {
            y *= 1.08;
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
        double a=1;
        double b=4;
        double a2 = 2;
        double a3 = 3;
        do
        {
            a = b;
            b = a3 / a2;
            a3 += a2;
            a2 = a3 - a2;
            answer++;
        }
        while (Math.Abs(a - b) > 0.001);


        // code here;
        
        
        Console.WriteLine(answer);
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
    {   double k = -1;
        double u = -1;
        double v = 1;
        double S = 0, y = 0;
        double p = x*x*x;
        double b = 1;
        double o;
       
            do
            {   
               
                u *= k;
                o = b * b;
                
                v = u * p / (4 * o - 1);
                p = p * x * x;
                b++;
                if (Math.Abs(v) < 0.0001)
                {
                 break;
                }
                S += v;

            }
            while (Math.Abs(v)>= 0.0001);
            y = (1 + x * x) * Math.Atan(x) / 2 - x / 2;


        // code here

        // end
        Console.WriteLine(S +" "+ y);
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
