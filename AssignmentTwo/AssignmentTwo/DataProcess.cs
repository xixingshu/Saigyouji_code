/***************************************************** 
//班级学号：
//姓名：
//注意！非常重要：不要随意修改已有代码结构及相关头文件
*******************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssignmentTwo
{
    class DataProcess
    {
        /** 5 marks
	        @param arr : an array of integer values	        
	        @return the smallest item in the array 
        */
        public static int min(int[] arr){

            //add your code here
            int min_of_arr = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min_of_arr > arr[i])
                {
                    min_of_arr = arr[i];
                }
            }
            return min_of_arr; // to be completed
        }
	
        /** 5 marks
	        @param arr : an array of integer values	        
	        @return the largest item in the array
        */
        public static int max(int[] arr) {

            //add your code here
            int max_of_arr = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (max_of_arr < arr[i])
                {
                    max_of_arr = arr[i];
                }
            }
            return max_of_arr; // to be completed
        }

        /** 10 marks
	        @param arr : an array of integer values	     
	        @return the difference between the largest and smallest items in the array. 
	   
	        You may use the min and max methods defined above.
	   
	        You may not use any functions defined outside of the AssignmentOne file. 
	   
        */
        public static int bigDiff(int[] arr) {

            //add your code here
            int max = DataProcess.max(arr);
            int min = DataProcess.min(arr);

            return max - min; // to be completed
        }


        /** 15 marks
	        @param n 
	        @return the number of divisors of n. 
	   
	        A divisor is a number that divides the integer exactly without
	        any remainder.
	   
	        For example 15 can be divided by 1,3,5,15 so it has 4 divisors.
        */
       public static int numberOfDivisors(int n) {

            //add your code here
            int number = 0;
            for (int i = 1; i < n + 1; i++)
            {
                if (n % i == 0)
                {
                    number++;
                }
            }
            //add your code here
            return number; // to be completed
        }
	
	
        /** 15 marks
	        @param x
	        @return true if x is a "Triangular number" and false otherwise.

	        Read about Triangular number's here: https://en.wikipedia.org/wiki/Triangular_number 	   
        */
        public static bool isTriangular(int x) {

            //add your code here	
            int n = 0, n_1 = 0;
            n = (int)Math.Sqrt(x * 2);
            n_1 = n + 1;

            return x * 2 == n * n_1 ? true : false; // to be completed
        }
	
	
        /** 15 marks
	        @param arr1 : an array of integer elements
	        @param arr2 : an array of integer elements	       
	        @return a new array which is the concatenation of arr1 and arr2.
       
	        The returned array should contain all the elements of arr1 
	        followed by all the elements of arr2.  
       
	        For example, if arr1 = [1,3,5] and arr2 = [2,4,6] then returned array 
	        should be [1,3,5,2,4,6]. 	   
        */
        public static int[] concatArray(int[] arr1,int[] arr2) {

            //add your code here
            int[] arr = new int[arr1.Length + arr2.Length];
            for(int i=0;i<arr1.Length;i++)
            {
                arr[i] = arr1[i];
            }
 
            for (int i = arr1.Length; i < arr2.Length; i++)
            {
                arr[i ] = arr2[i];
            }
            return arr; // to be completed
        }
	
	
        /** 15 marks
	        @param arr : an array of integer elements	        
	        @return a string that represents arr. 
	   
	        Here are some examples:
	        arr = [1, 2, 3]  -->  "[1, 2, 3]"
	        arr = []       -->  "[]"
        */
       public static string formatArray(int[] arr) {

            //add your code here           
            string str = "[";

            for (int i = 0; i < arr.Length; i++)
            {
                str += arr[i].ToString();
                if (i != arr.Length - 1)
                {
                    str += ',';
                    str += ' ';
                }
            }
            str += ']';
            return str; // to be completed
        }
	
	
        /** HD question. 20 marks
	        @param arr: : an array of integer elements 	       
	        @return most common item in arr
       
	        Here are some examples:
	        arr = [1,4,3,4]     --> 4
	        arr = [1,5,2,2,1,2] --> 2	   
        */
        public static int mostCommonItem(int[] arr) {

            //add your code here
            int[] p = new int[arr.Length];
            int[] q = new int[arr.Length];

            int max = p[0];
            int re = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                p[i] = 0;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == q[i])
                    {
                        p[i]++;
                    }
                    else
                    {
                        q[j] = arr[j];
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < p[i])
                {
                    max = p[i];
                    re = q[i];
                }
            }
            return re; // to be completed
        }
    }
}
