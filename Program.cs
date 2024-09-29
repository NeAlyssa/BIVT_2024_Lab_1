using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
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
        for (int s = 2; s <= 35; s+=3){
            answer+=s;
        }
        // end

        return answer;
    }
    public double Task_1_2()
    {
        double answer = 0;

        // code here
        for (int i = 1; i < 11; i++){
            answer +=   1.0 / i;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_3()
    {
        double answer = 0;

        // code here
        for (int i = 2; i <= 112; i+= 2 ){
            answer = answer + i / (i + 1.0);
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_4(double x)
    {
        double answer = 0;

        // code here
        if (x == 0) return 0; 
        double poww = 1;
        for (int i = 1; i <= 9; i++){
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

        // code here
        for (int i = 0; i <= 9; i++){
            answer += (p+h*i) * (p+h*i);
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public double Task_1_6(double x)
    {
        double answer = 0;

        // code here
        answer = Math.Round(0.5*x*x - 7*x, 2);
        // end

        return answer;
    }
    public int Task_1_7()
    {
        int answer = 1;

        // code here
        for (int i = 1; i <= 6; i++){
            answer *= i;
        }

        // end
        return answer;
    }
    public int Task_1_8()
    {
        int answer = 0;

        // code here;
        int c = 1;
        for (int j = 1; j <= 6; j++){
            c *= j;
            answer += c;
        }
        // end

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;

        // code here;
        for (int i = 1; i <= 6; i++){
            int pow = 1;
            float pow2 = 1;
            int factorial = 1;
            for (int j = 1; j <= i; j++){
                pow *= -1;
                pow2 *= 5;
                factorial *= j;
            }
            answer += pow * pow2 / factorial;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_1_10()
    {
        int answer = 1;

        // code here
        for (int i = 1; i<=7; i++){
            answer *= 3;
        }
        // end

        return answer;
    }
    public void Task_1_11()
    {
        // There is no test for this task
        for (int i = 1; i <= 6; i++){
            Console.WriteLine(i);
        }
        for (int i = 1;i <= 6; i++){
            Console.WriteLine(5);
        }
        // code here

    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        // code here
        if (x == 0){
        return 0;
        }
        for (int i = 0; i <= 10; i++)
        {
            double pow = 1;
            for (int j = 1; j <= i; j++)
            {
                pow *= x;
            }
            answer += 1.0 / pow;
        }
        answer = Math.Round(answer, 2);
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
        else if (x > -1 && x <= 1)
        {
            answer = -1.0 * x;
        }
        // end

        return answer;
    }
    public void Task_1_14()
    {
        // There is no test for this task
        int pred = 0;
        int next = 1;
        for (int i = 1; i <= 8; i++)
        {
            int sum = pred + next;
            pred = next;
            next = sum;
            Console.WriteLine(sum);
        }
    }
        
        // code here

    public double Task_1_15()
    {
        double answer = 0;

        // code here
        float predchisl1 = 2;
        float predchisl2 = 1;
        float nextchisl = 0;
        float predznam1 = 1;
        float predznam2 = 1;
        float nextznam = 0;
        for (int i = 0; i <= 2; i++)
        {
            nextchisl = predchisl1 + predchisl2;
            predchisl2 = predchisl1;
            predchisl1 = nextchisl;
            nextznam = predznam1 + predznam2;
            predznam2 = predznam1;
            predznam1 = nextznam;
        }
        answer = Math.Round(nextchisl / nextznam, 2);
        // end

        return answer;
    }
    public (double, int) Task_1_16()
    {
        double answer = 0;
        int power = 0;

        // code here
        float c = 1;
        float sum = 1;
        for (int i = 1; i < 64; i++)
        {
            c *= 2;
            sum += c;
        }
        sum /= 15;
        while (sum > 10)
        {
            sum /= 10;
            power++;
        }
        answer = Math.Round(sum, 2);
        // end

        return (answer, power);
    }
    public double Task_1_17(double x)
    {
        double answer = 0;

        // code here
        int r = 6350;
        answer = Math.Round(Math.Sqrt((r + x) * (r + x) - r * r), 2);
        // end

        return answer;
    }
    public int Task_1_18(int x)
    {
        int answer = 0;
        // code here
        int start = 10;
        for (int i = 1; i <= x; i++)
        { if (i%3==0){
            start *= 2;}
        }
        answer = start;
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double answer = 0;

        // code here
        double c = Math.Cos(x);
        double E = 0.0001;
        for (int i = 2; Math.Abs(c) >= E; i++)
        {
            answer += c;
            c = Math.Cos(i * x) / (i * i);
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

        // code here
        int c = 0;
        double s = 0;
        if (h < 0)
        {
            return 0;
        }
        while (s <= p)
        {
            s += (a + c * h);
            c++;
        }
        answer = c - 1;
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
        if (M == 0) return (0, 0);
        while (N >= M)
        {
            N -= M;
            quotient++;
            if (N < M)
            {
                remainder = N;
                return (quotient, remainder);
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

        // code here
        double a = 10;
        for (int i = 1; i <= 7; i++)
        {
            answer += a;
            a *= 1.1;
        }
        answer = Math.Round(answer, 2);
        // end

        return answer;
    }
    public int Task_2_7b()
    {
        int answer = 0;

        // code here
        double a = 10;
        double sum=a;
        int count = 1;
        while (sum<100){
            a *= 1.1;
            sum += a;
            count++;
        }
        answer=count;
        // end

        return answer;
    }
    public int Task_2_7c()
    {
        int answer = 0;

        // code here
        double a = 10;
        int count = 0;
        while (a<=20){
            a*=1.1;
            count++;
        }
        answer=count;
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
        double l = 0.1;
        double d = 0.1;
        for (int i=2; i<=10; i++){
            d*=0.1;
        }
        while (d<=l){
            answer++;
            l/=2;
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
        int k = 1;
        for (int i = 1; ; i++)
        {
            k *= -1;
            double res = k * Math.Cos(i * x) / (i * i);
            if (Math.Abs(res) < 0.0001) break;
            S += res;
        }
        y = (x * x - Math.PI * Math.PI / 3) / 4;

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