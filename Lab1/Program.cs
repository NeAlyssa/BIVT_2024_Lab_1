using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Xml.XPath;


public class Program
{
    public int Factorial(int n) {
        int result = 1;
        for (int i = 1; i <= n; i++) {
            result *= i;
        }
        return result;
    }

    public double Power(double x, double y) {
        double result = 1;
        bool isNegative = false;
        if (y < 0) {
            isNegative = true;
            y = -y;
        }

        for (int i = 0; i < y; i++) {
            result *= x;
        }

        if (isNegative) return 1 / result;
        return result;
    }
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
        //program.Task_1_9();F
        //program.Task_1_10();
        //program.Task_1_11();
        //program.Task_1_12(0.9);
        //program.Task_1_13(-1.5);
        //program.Task_1_15();
        //program.Task_1_16();
        //program.Task_1_17(10);
        //program.Task_1_18(24);
        //program.Task_2_1(0);
        //program.Task_2_2();
        //program.Task_2_3(0.2, -1.9, 12);
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
        //program.Task_3_6(0.7);
        //program.Task_3_7(0.1);
        //program.Task_3_8(0.1);
        //program.Task_3_9(0.1);
    }
    #region Level 1
    public int Task_1_1()
    {   
        int answer = 0;
        
        for (int i = 2; i <= 35; i += 3) {
            answer += i;
        }

        return answer;

    }
    public double Task_1_2()
    {
        double answer = 0;
     
        for (double i = 1; i <= 10; i++) {
            answer += 1 / i; // double instead of int!
        }
        
        return Math.Round(answer, 2);
    }
    public double Task_1_3()
    {
        double answer = 0;
      
        for (double i = 2; i <= 112; i += 2) { // double instead of int!
            answer += i / (i + 1);
        }
        
        return Math.Round(answer, 2);
    }
    public double Task_1_4(double x)
    {     
        double answer = 0;
        double helpX = 1;
        for (int i = 1; i <= 9; i++) {
            answer += (x != 0) ? (Math.Cos(i * x) / helpX) : 0; 

            helpX *= x;
        }
        
        return Math.Round(answer, 2);
    }
    public double Task_1_5(double p, double h)
    {
        double answer = 0;
        
        for (int n = 1; n <= 10; n++) {
            answer += Math.Pow(p + (n - 1) * h, 2);
        }    

        return answer;
    }
    public double Task_1_6(double x)
    {   
        double answer = 0.5 * x * x - 7 * x;
        return Math.Round(answer, 2);
    }



    public int Task_1_7()
    {   
        return Factorial(6);
        
    }
    public int Task_1_8()
    {
        int answer = 0;

        for (int i = 1; i <= 6; i++) {
            answer += Factorial(i);
        }     

        return answer;
    }
    public double Task_1_9()
    {
        double answer = 0;
        
        for (int i = 1; i <= 6; i++) {
            answer += Math.Pow(-1, i) * Math.Pow(5, i) / Factorial(i);
        }
        
        return Math.Round(answer, 2);
    }
    public int Task_1_10()
    {
        return (int) Power(3, 7);
        
    }
    public void Task_1_11()
    {
        for (int i = 1; i <= 6; i++) {
            Console.Write(i + " ");
        }

        for (int i = 0; i < 6; i++) {
            Console.Write(5 + " ");
        }
        
    }
    public double Task_1_12(double x)
    {
        double answer = 0;

        for (int i = 0; i < 11; i++) {
            answer += (x != 0) ?  1 / Power(x , i) : 0;
        }
    
        return Math.Round(answer, 2);
    }
    public double Task_1_13(double x) 
    {
        double y;

        if (x <= -1) y = 1;
        else if (x > -1 && x <= 1) y = -x;
        else y = -1;
        
        return y;
    }
    public void Task_1_14()
    {
        
        int prev = 1, cur = 1, tmp;
        Console.WriteLine(prev);
        Console.WriteLine(cur);

        for (int i = 0; i < 6; i++) {
            tmp = cur;
            cur += prev;
            prev = tmp;

            Console.WriteLine(cur);
        }
        
    }
    public double Task_1_15()
    {
        
        double prevNumerator = 1, prevDenumerator = 1;
        double curNumerator = 2, curDenominator = 1;
        double tmpNumerator, tmpDenominator;


        for (int i = 0; i < 3; i++) {
            tmpNumerator = curNumerator;
            tmpDenominator = curDenominator;

            curNumerator += prevNumerator;
            curDenominator += prevDenumerator;

            prevNumerator = tmpNumerator;
            prevDenumerator = tmpDenominator;
        }

        return curNumerator / curDenominator;
        
    }
    public (double, int) Task_1_16()
    {
        double answer;
        double curAmount = 1, totalAmount = 0;
         
        for (int i = 0; i < 64; i++) {
            totalAmount += curAmount;
            curAmount *= 2;
        }


        answer = totalAmount / 15;

        int answerPower = (int) Math.Floor(Math.Log10(answer));
        double answerMantissa = answer / Math.Pow(10, answerPower); 
        return (Math.Round(answerMantissa, 2), answerPower); 
    }
    public double Task_1_17(double x) {

        double R = 6350;
        double resultDistance = Math.Sqrt(x * (2 * R + x));
        
        return Math.Round(resultDistance, 2); 
    }

    public int Task_1_18(int x)
    {
        int curAmebaCount = 10;
        for (int i = 0; i < x; i += 3) {
            curAmebaCount *= 2;
        }
        return curAmebaCount;
    }
    #endregion

    #region Level 2
    public double Task_2_1(double x)
    {
        double curElement = Math.Cos(x), n = 1, sum = 0;
        double epsilon = 0.0001;

        while (Math.Abs(curElement) >= epsilon) {
            sum += curElement;
            n++;
            curElement = Math.Cos(n * x) / (n * n);
        }

        return Math.Round(sum, 2); 
    }
    public int Task_2_2()
    {
        double product = 1;
        double L = 30_000;
        int n = 1;

        while (product * (n + 3) <= L) {
            n += 3;
            product *= n;   
        }

        return n;
    }
    public int Task_2_3(double a, double h, double p)
    {           
        if (a < p && h < 0) return 0;
        
        int n = 0;
        double sum = 0;

        while (sum + (a + n * h) <= p) {
            n++;
            sum += a + (n - 1) * h;
        }   

        Console.WriteLine(n);

        return n;
    }
    public double Task_2_4(double x)
    {
        if (x >= 1) return 0;

        double curElement = 1, epsilon = 0.0001, sum = 1;

        while (curElement * x * x >= epsilon) {
            curElement *= x * x;
            sum += curElement;
        }

        return Math.Round(sum, 2);
    }

    
    public (int, int) Task_2_5(int N, int M) 
      {
        if (M == 0) return (0, 0);
        int quotient = 0, remainder;
        bool positiveSign = false;

        if (N >= 0 && M >= 0 || N <= 0 && M <= 0) positiveSign = true;
        N = Math.Abs(N);
        M = Math.Abs(M);

        while (N - M >= 0) {
            quotient++;
            N -= M;
        }

        remainder = N;
        
        if (!positiveSign) quotient *= -1;

        return (quotient, remainder);
    }
    public int Task_2_6()
    {
        int totalAmount = 10, curTime = 0;

        while (totalAmount < 100_000) {
            totalAmount *= 2;
            curTime += 3;
        }

        return curTime;
    }
    public double Task_2_7a()
    {
        double curDistance = 10, totalDistance = 10;

        for (int i = 0; i < 6; i++) {
            curDistance *= 1.1;
            totalDistance += curDistance;
        }

        return Math.Round(totalDistance, 2);
    }
    public int Task_2_7b()
    {

        double curDistance = 10, totalDistance = 10;
        int daysCount = 1;

        while (totalDistance < 100) {
            curDistance *= 1.1;
            totalDistance += curDistance;
            daysCount++;
        }

        return daysCount;
    }
    public int Task_2_7c()
    {

        double curDistance = 10;
        int daysCount = 0;

        while (curDistance <= 20) {
            curDistance *= 1.1;
            daysCount++;
        }

        return daysCount;
    }
    public int Task_2_8()
    {
        double curBalance = 10_000;
        int monthsCount = 0;

        while (curBalance < 20_000) {
            curBalance *= 1.08;
            monthsCount++;
        }

        return monthsCount;
    }
    public int Task_2_9()
    {
        double L = 0.1;
        int cutCount = 0;
        while (L > Math.Pow(10, -10)) {
            L /= 2;
            cutCount++;
        }

        return cutCount;
    }
    public int Task_2_10()
    {
        double prevNumerator = 1, prevDenominator = 1;
        double curNumerator = 2, curDenominator = 1;
        int count = 2;
        double epsilon = 0.001;

        while (Math.Abs((curNumerator / curDenominator) - (prevNumerator / prevDenominator)) > epsilon) {
            double tmpNumerator = curNumerator, tmpDenominator = curDenominator;

            curNumerator += prevNumerator;
            curDenominator += prevDenominator;

            prevNumerator = tmpNumerator;
            prevDenominator = tmpDenominator;
            count++;
        }
    
        return count;
    }
    #endregion

    #region Level 3
    public (double, double) Task_3_1(double x)
    {
        double S = 0, y = Math.Cos(x), curElement;
        int i = 0;
        curElement = Math.Pow(-1, i) * Math.Pow(x, 2 * i) / Factorial(2 * i);

        while (Math.Abs(curElement) >= 0.0001) {
            S += curElement;
            i++;
            curElement = Math.Pow(-1, i) * Math.Pow(x, 2 * i) / Factorial(2 * i);
        } 

        return (Math.Round(S, 2), Math.Round(y, 2));
    }
    public (double, double) Task_3_2(double x)
    {
        double S = 0, y = x * Math.Sin(Math.PI / 4) / (1 - 2 * x * Math.Cos(Math.PI / 4) + x * x);
        int i = 1;
        double curElement = Math.Pow(x, i) * Math.Sin(i * Math.PI / 4);
        
        while (Math.Abs(Math.Pow(x, i)) >= 0.0001) {
            S += curElement;
            i++;
            curElement = Math.Pow(x, i) * Math.Sin(i * Math.PI / 4);
        }

        return (Math.Round(S, 2), Math.Round(y, 2));
    }
    public (double, double) Task_3_3(double x)
    {
        double S = 1, y = Math.Pow(Math.E, Math.Cos(x)) * Math.Cos(Math.Sin(x));
        
        int i = 1;
        double curElement = Math.Cos(i * x) / Factorial(i);
        
        while (Math.Abs(curElement) >= 0.0001) {
            S += curElement;
            i++;
            curElement = Math.Cos(i * x) / Factorial(i);
        }

        return (Math.Round(S, 2), Math.Round(y, 2)); // problem with rounding; doesn't match to tests
    }
    public (double, double) Task_3_4(double x)
    {
        double S = 0, y = (1 + 2 * x * x) * Math.Pow(Math.E, x * x);
        int i = 0;
        double curElement = (2 * i + 1) * Math.Pow(x, 2 * i) / Factorial(i);
        
        while (Math.Abs(curElement) >= 0.0001) {
            S += curElement;
            i++;
            curElement = (2 * i + 1) * Math.Pow(x, 2 * i) / Factorial(i);
        }

            
        return (Math.Round(S, 2), Math.Round(y, 2));
    }
    public (double, double) Task_3_5(double x)
    {
        double S = 0, y = (x * x - Math.PI * Math.PI / 3) / 4;

        int i = 1;
        double curElement = Math.Pow(-1, i) * Math.Cos(i * x) / (i * i);
        
        while (Math.Abs(curElement) >= 0.0001) {
            S += curElement;
            i++;
            curElement = Math.Pow(-1, i) * Math.Cos(i * x) / (i * i);
        }


        return (Math.Round(S, 2), Math.Round(y, 2));
    }
    public (double, double) Task_3_6(double x)
    {
        double S = 0, y = (1 + x * x) * Math.Atan(x) / 2 - x / 2;

        int i = 1;
        double curElement = Math.Pow(-1, i + 1) * Math.Pow(x, 2 * i + 1) / (4 * i * i - 1);
        
        while (Math.Abs(curElement) >= 0.0001) {
            S += curElement;
            i++;
            curElement = Math.Pow(-1, i + 1) * Math.Pow(x, 2 * i + 1) / (4 * i * i - 1);

        }
        return (Math.Round(S, 2), Math.Round(y, 2));
    }
    public (double, double) Task_3_7(double x)
    {
        double S = 0, y = (Math.Pow(Math.E, x) + Math.Pow(Math.E, -x)) / 2;
        int i = 0;
        double curElement = Math.Pow(x, 2 * i) / Factorial(2 * i);
        
        while (Math.Abs(curElement) >= 0.0001) {
            S += curElement;
            i++;
            curElement = Math.Pow(x, 2 * i) / Factorial(2 * i);

        }
        return (Math.Round(S, 2), Math.Round(y, 2));
    }
    public (double, double) Task_3_8(double x)
    {
        double S = 0, y = Math.Pow(Math.E, 2 * x);

        int i = 0;
        double curElement = Math.Pow(2 * x, i) / Factorial(i);
        
        while (Math.Abs(curElement) >= 0.0001) {
            S += curElement;
            i++;
            curElement = Math.Pow(2 * x, i) / Factorial(i);

        }

        return (Math.Round(S, 2), Math.Round(y, 2));
    }
    public (double, double) Task_3_9(double x)
    {
        double S = 0, y = Math.Atan(x);
        int i = 0;
        double curElement = Math.Pow(-1, i) * Math.Pow(x, 2 * i + 1) / (2 * i + 1);
        
        while (Math.Abs(curElement) >= 0.0001) {
            S += curElement;
            i++;
            curElement = Math.Pow(-1, i) * Math.Pow(x, 2 * i + 1) / (2 * i + 1);

        }
        return (Math.Round(S, 2), Math.Round(y, 2));
    }
    #endregion
}
