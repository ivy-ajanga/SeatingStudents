﻿using System;
using System.Collections.Generic;

namespace SeatingStudents
{
           /* Challenge
        Have the function SeatingStudents(arr) read the array of integers stored in arr which will be in the
        following format: [K, r1, r2, r3, ...] where K represents the number of desks in a classroom,
        and the rest of the integers in the array will be in sorted order and will represent the desks
         that are already occupied.All of the desks will be arranged in 2 columns, 
         where desk #1 is at the top left, desk #2 is at the top right, desk #3 is below #1, desk #4 is below #2, etc. 
         Your program should return the number of ways 2 students can be seated next to each other.
         This means 1 student is on the left and 1 student on the right, or 1 student is directly above or below the other student.
        For example: if arr is [12, 2, 6, 7, 11] then this classrooms looks like the following picture: 


        Based on above arrangement of occupied desks, there are a total of 6 ways to seat 2 new students next to each other.The combinations are: [1, 3], [3, 4], [3, 5], [8, 10], [9, 10], [10, 12]. So for this input your program should return 6. K will range from 2 to 24 and will always be an even number.After K, the number of occupied desks in the array can range from 0 to K. 
        Sample Test Cases
        Input:6, 4
        Output:4
        Input:8, 1, 8
        Output:6
        */

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 6, 4 };//4
            //8,1,8//6
            //4,1,2,3,4//0
            //4//0
            Console.WriteLine(SeatingStudents(arr));
        }
        public static int SeatingStudents(int[] arr)
        {
            // create a hashset add elements in array
            //at left is odd
            //if i is odd check if hashset contains element at i+1
            //if it does continue
            //else count
            //left and right is odd& even if hashset has no element behind that is i+2 count
            int count = 0;
            HashSet<int> occupiedDesks = new HashSet<int>();
            for (int i = 1; i < arr.Length; i++)
            {
                occupiedDesks.Add(arr[i]);
            }
            if (arr.Length < 2) return 0;
            for (int i = 1; i < arr[0]; i++)
            {
                if (occupiedDesks.Contains(i)) continue;
                if (i % 2 != 0)
                {
                    if (!occupiedDesks.Contains(i + 1)) count++;

                }
                if (!occupiedDesks.Contains(i + 2) && ((i + 2) < arr[0])) count++;
            }
            return count;

        }
    }
}
