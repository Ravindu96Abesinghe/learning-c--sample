﻿
namsepace Algorithms;


    class Program {

        static int[] Reverse(int[] input){
            int[] reversed = new int[input.Length];

            for (int i = 0; i< reversed.Length; i++)
            {
                reversed[i] = input[input.Length-i-1];
            }
            return reversed;
        }

        static void Main(string[] args)
        {

            int[] arr = {1, 2, 3, 4, 5, 6};
            Array.ForEach(Reverse(arr), Console.WriteLine);

        }

    }
