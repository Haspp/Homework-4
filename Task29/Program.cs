﻿int[] array = new int[8];
Random rand = new Random();

for(int i = 0 ; i < array.Length ; i++)
{
    
    array[i] = rand.Next(99);
    Console.Write(" " + array[i]);
    
} 

