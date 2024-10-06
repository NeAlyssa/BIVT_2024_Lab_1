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
        program.Task_1_9();
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
        //Вычислить s = 2 + 5 + 8 + ... + 35. 
        // code here
        for (int i = 2; i <= 35; i = i + 3) answer = answer + i;
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;
        //Вычислить s =1+1/2 + 1/3 + 1/4 + … + 1/10.
        // code here
        for (double i = 1; i <= 10; i++) answer += 1 / i;
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;
        //Вычислить s = 2/3 + 4/5 + 6/7 + ... + 112/113. 
        // code here
        for (double i = 2; i <= 112; i = i + 2) answer += i / (i + 1);
        answer = Math.Round(answer, 0);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;
        //Вычислить s = cos x + (cos 2x)/x + (cos 3x)/x2+ ... + (cos 9x)/x8. 
        // code here
        if (x == 0) return 0;
        double poww = 1;
        for (int i = 1; i <= 9; i++)
        {
            answer += Math.Cos(i * x)/poww;
            poww *= x;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;
        //Вычислить сумму квадратов 10 членов арифметической прогрессии  s = p2 + (p + h)2 + ... + (p + 9h)2. 
        // code here
        for (int i = 0; i <= 9; i++) answer += (p + h * i)* (p + h * i);
        answer = Math.Round(answer, 2);
        // end


        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;
        //Получить таблицу функции y(x) = 0,5x2– 7x при изменении x от –4 до 4 с шагом 0,5
        // code here
        answer = 0.5 * x * x - 7 * x;
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;
        //Вычислить значение факториала числа 6 (6! = 123...6).
        // code here
        for (int i = 2; i <= 6; i++) answer =answer * i;
        
        // end

        return answer;
    }
    public int Task_1_8()
    {
        int answer =1;
        //Вычислить s = 1! + 2! + ... + 6! 
        // code here;
        int prome = 1;
        for (int i = 2; i <= 6; i++)
        {
            prome *= i;
            answer += prome;
        }
        
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        //Вычислить s = (–1) 1·51/1! + (–1)2·52/2! + ... + (–1) 6·56/6! 
        // code here;
        int fact = 1;
        int nachalnoe = -1;
        for (int i== 1; i <= 6; i++){
            fact *= i;
            answer += nachalnoe * int * (50 + i) / fact;
            nachalnoe *= -1;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;
        // Возвести число 3 в 7-ю степень, не используя операцию возведения в степень. 
        // code here
        for(int i = 1; i <= 7; i++) answer *= 3;
        
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        // Напечатать заданную последовательность чисел: а) 1 2 3 4 5 6,  б) 5 5 5 5 5 5. 
        for (int i = 1; i <= 6; i++)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
        for (int i = 1; i <= 6; i++)
        {
            Console.Write("5 ");
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;
        // Вычислить при заданном x сумму s = 1 + 1/x + 1/x2 + ... + 1/x10.
        // code here
        if (x == 0) return 0;
        double poww = 1;
        for(int i = 0; i <= 10; i++)
        {
            answer += 1 / poww;
            poww *= x;
        }
        
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_13(double x)
    {
        double answer = 0;
        //. Составить таблицу значений функции       − x , − − 1 , 1  x x  1 1 на отрезке -1,5 ≤ x ≤ 1,5 с шагом h = 0,1.
        // code here
        if (x <= -1) answer = 1;
        else if (-1 < x && x <= 1) answer = -x;
        else answer = -1;
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        //Напечатать 8 первых членов последовательности, образованной по следующему правилу: первые два числа равны 1; каждое последующее (начиная с третьего) образуется путем суммирования двух предыдущих. (Такая последовательность называется числами Фибоначчи.) 
        int perv = 1;
        int vtor = 1;
        int tr = 0;
        Console.WriteLine(vtor);
        for (int i = 0; i <= 6; i++)
        {
            Console.WriteLine(perv);
            tr = perv + vtor;
            vtor = perv;
            perv = tr;
        }
        // code here

    }
    public double Task_1_15()
    {
        double answer = 0;
        //Вычислить 5-й член последовательности, образованной дробями 1/1, 2/1, 3/2, …, т.е. числитель (знаменатель) следующего члена последовательности получается сложением числителей (знаменателей) двух предыдущих членов. 
        // code here
        float c1 = 2, c2 = 1, chisl = 0, z1 = 1, z2 = 1, znamen = 0;
        for(int i = 0; i <= 2; i++)
        {
            chisl = c1 + c2;
            c2 = c1;
            c1 = chisl;
            znamen = z1 + z2;
            z2 = z1;
            z1 = znamen;
        }
        answer = chisl / znamen;
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 1;
        int power = 0;

        // code here
        for (int i = 0; i < 64; i++) answer *= 2;
        answer /= 15;
        double poww = 1;
        power = (int)Math.Log10(answer);
        for (int i = 0; i < power; i++) poww *= 10;
        answer = answer / poww;
        answer = Math.Round(answer, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        int r = 6350;
        answer = Math.Sqrt((r + x) * (r + x) - r * r);
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 10;

        // code here
        for (int i = 1;  i<= x / 3; i++) answer *= 2;
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
        //Определить наибольшее значение сомножителя n, для которого произведение р = 1 · 4 · 7 ·...· n не превышает L = 30 000.
        // code here
        int x = 1;
        for (int n = 1; x * n < 30000; n += 3)
        {
            x *= n;
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
        double answer = 0;

        // code here
        if (x <= -1 || x >= 1) return 0;
        

            int i = 0;
            double a = 1;
            while (Math.Abs(a) >= 0.0001)
            {
                answer += a;
                a *= x * x;
                i++;
            }
            answer = Math.Round(answer, 2);
        
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
        int x = 10;
        // code here
        while (x< 100000)
        {
            x = x * 2;
            answer+=3;
            
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
        // code here;
        int answer = 0;
        double x = 10000;
        double proch = 0.08;
        double current = x;
        while (current < x * 2)
        {
            current += current * proch;
            answer++;
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
        double ch1 = 1, zn1 = 1, ch2 = 2, zn2 = 1;


        while (Math.Abs(ch2 / zn2 - ch1 / zn1) >= 0.001)
        {
            double ch3 = ch2;
            double zn3 = zn2;
            zn2 += zn1;
            ch2 += ch1;
            zn1 = zn3;
            ch1 = ch3;
            answer++;
        }


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
        double powX = 1;
        double res;
        for (int i = 1; ; i++)
        {
            powX *= x;
            res = powX * Math.Sin(i * Math.PI / 4);
            if (powX < 0.0001) break;
            S += res;
        }
        y = (x * Math.Sin(Math.PI / 4)) / (1 - 2 * x * Math.Cos(Math.PI / 4) + x * x);
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