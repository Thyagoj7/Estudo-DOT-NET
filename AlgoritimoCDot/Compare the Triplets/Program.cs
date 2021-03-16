using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;



namespace Compare_the_Triplets
{
    class Program
    {
        // Complete the compareTriplets function below.
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int x = 0;
            int y = 0;
            
            for (int i = 0; i < 4; i++) {

                if(i==0 && x > y)
                {
                    return (1,0);
                    

                }else if(i==0 && x < y)
                {
                    return a = 0; b = 1;
                }

                
            
            }





        }



                static void Main(string[] args)
                {
                    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

                    List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

                    List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

                    List<int> result = compareTriplets(a, b);

                    textWriter.WriteLine(String.Join(" ", result));

                    textWriter.Flush();
                    textWriter.Close();
                }
            
        
    }
}