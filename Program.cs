using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System;

class Solution
{

    // Complete the saveThePrisoner function below.
    static int saveThePrisoner(int n, int m, int s)
    {
        var resFinal = m + s - 1; 
        if (m >= n)
        {
           while (m > n)
            {
                m -= n;
            }
        }
        if (resFinal >= n)
        {
            while (resFinal > n)
            {
                resFinal -= n;
            }
        }
        
        return resFinal;
       
    }

    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] nms = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nms[0]);

            int m = Convert.ToInt32(nms[1]);

            int s = Convert.ToInt32(nms[2]);

            int result = saveThePrisoner(n, m, s);

            Console.WriteLine(result);
            Console.ReadKey();
        }

    }
}
