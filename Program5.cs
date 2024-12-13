using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Xml.Linq;

public class Program
{
    public static void Main()
    {
        Program program = new Program();

    }
    #region Level 1
    public int Task_1_1(int[,] A)
    {
        int answer = 0;
        // code here

        // end

        return answer;
    }
    public double Task_1_2(int[,] A)
    {
        double answer = 0;
        // code here

        // end

        return answer;
    }
    public int Task_1_3(int[,] A)
    {
        int answer = 0;
        if (A.GetLength(0) != 4 && A.GetLength(1) != 4) return answer;
        // code here
        for (int i = 0;i<4;i++)
        {
            for (int j = 0;j<4;j++)
            {
                if (i==j)
                    answer += A[i,j];
            }
        }
        // end

        return answer;
    }
    public (int, int) Task_1_4(int[,] A)
    {
        int row = 0, col = 0;
        // code here

        // end

        return (row, col);
    }
    public (int, int) Task_1_5(int[,] A, int colIndex)
    {
        int value = 0, rowIndex = -1;
        // code here

        // end

        return (value, rowIndex);
    }
    public int[] Task_1_6(int[,] A)
    {
        if (A.GetLength(0) != 4 && A.GetLength(1) != 7) return null;
        int[] answer = new int [4];

        // code here 
        for (int i = 0; i < 4; i++)
        {
            int min = A[i, 0];
            int indmax = 0;
            for (int j = 0; j < 7; j++)
            {
                if (A[i, j] < min)
                {
                    min = A[i, j];
                    indmax = j;
                }
            }
            answer[i] = indmax;
        }
        // end

        return answer;
    }
    public int[] Task_1_7(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    public double[] Task_1_8(int[,] A)
    {
        double[] answer = default(double[]);
        // code here

        // end

        return answer;
    }
    public int[,] Task_1_9(int[,] A)
    {
        // code here
        int p = 0;
        if (A.GetLength(0) != 5 && A.GetLength(1) != 7) return null ;
        for (int i=0; i<5; i++)
        {
            
            int max = A[i, 0];
            int index = -1;
            for (int j=0; j<7; j++)
            {
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    index = j;
                }
            }
            A[i,index]=A[i,0];
            A[i, 0] = max;
        }
        // end

        return A;
    }
    public int[,] Task_1_10(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_11(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_12(int[,] A)
    {
        // code here
        if (A.GetLength(0) != 6 && A.GetLength(1) != 7) return null;
        int max= -10000;
        int n = -1;
        int m = -1;
        int [,] NewA = new int [5,6];
        for (int i=0; i<6;i++)
        {
            for (int j=0; j<7; j++)
            {
                if (A[i, j] > max)
                {
                    n=i; m=j;
                }
            }
        }
        for (int i=0; i<5;i++)
        {
            for (int j=0; j<6;j++)
            {
                if (i<n)
                {
                    NewA[i,j]=A[i,j];
                }
                if (i >= n)
                {
                    NewA[i, j] = A[i+1, j];
                }
            }
        }
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                if (j < m)
                {
                    NewA[i, j] = A[i, j];
                }
                if (j >= m)
                {
                    NewA[i, j] = A[i, j+1];
                }
            }
        }
        // end

        return A;
    }
    public int[,] Task_1_13(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[] Task_1_14(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    public int[,] Task_1_15(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_16(int[,] A, int n, int m)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_17(int[,] B, int n, int m)
    {
        // code here

        // end

        return B;
    }
    public int[,] Task_1_18(int[,] D, int n, int m)
    {
        // code here

        // end

        return D;
    }
    public double[,] Task_1_19(double[,] C, int n, int m)
    {
        // code here

        // end

        return C;
    }
    public double[,] Task_1_20(double[,] F, int n, int m)
    {
        // code here

        // end

        return F;
    }
    public int[,] Task_1_21(int[,] H)
    {
        // code here

        // end

        return H;
    }
    public double[,] Task_1_22(double[,] Z)
    {
        // code here

        // end

        return Z;
    }
    public int[,] Task_1_23(int[,] G)
    {
        // code here

        // end

        return G;
    }
    public double[,] Task_1_24(double[,] Y)
    {
        // code here

        // end

        return Y;
    }
    public int[,] Task_1_25(int[,] X)
    {
        // code here

        // end

        return X;
    }
    public int[,] Task_1_26(int[,] A, int[] B)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_27(int[,] B)
    {
        // code here

        // end

        return B;
    }
    public int[,] Task_1_28(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_1_29(int[,] F)
    {
        // code here

        // end

        return F;
    }
    public int[,] Task_1_30(int[,] B)
    {
        // code here

        // end

        return B;
    }
    public int[,] Task_1_31(int[,] A, int[] B)
    {
        // code here

        // end

        return A;
    }
    public double[,] Task_1_32(double[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[] Task_1_33(int[,] A)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double[,] Task_2_1(double[,] A)
    {
        // code here

        // end

        return A;
    }
    #endregion
    public int[,] Task_2_2(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_2_3(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_2_4(int[,] A, int[] B)
    {
        // code here

        // end

        return A;
    }
    public double[,] Task_2_5(double[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_2_6(int n)
    {
        int[,] answer = default(int[,]);
        // code here

        // end

        return answer;
    }
    public int[,] Task_2_7(int[,] A)
    {
        // code here

        // end

        return A;
    }
    public int[,] Task_2_8(int[,] B)
    {
        // code here

        // end

        return B;
    }
    public int[,] Task_2_9(int[,] A)
    {
        // code here

        // end

        return A;
    }

    #region Level 3
    public int[,] Task_3_1(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_2(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[] Task_3_3(int[,] matrix)
    {
        int[] answer = default(int[]);
        // code here

        // end

        return answer;
    }
    public int[,] Task_3_4(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_5(int[,] matrix, int k)
    {
        // code here

        // end

        return matrix;
    }
    public (int[], int[]) Task_3_6(int[,] matrix)
    {
        int[] upper = default(int[]);
        int[] lower = default(int[]);
        // code here

        // end

        return (upper, lower);
    }
    public int[] Task_3_7(int[] A, int[] B, int n)
    {
        int[] answer = default(int[]);

        // code here

        // end

        return answer;
    }
    public int[,] Task_3_8(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_9(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_10(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    public int[,] Task_3_11(int[,] matrix)
    {
        // code here

        // end

        return matrix;
    }
    #endregion
}