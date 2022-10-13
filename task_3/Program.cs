﻿// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 2, 4, 9 -> [1, 2, 5, 7, 19, 2, 4, 9 ]

// 6, 1, 33, 2, 93, 15, 424, 0-> [6, 1, 33, 2, 93, 15, 424, 0]

Console.Clear();

int[] array = new int[8];
FillArray(array);
Console.WriteLine("[{0}]", string.Join(", ", array)); //выводим массив как в примере


void FillArray(int[] array){
    for(int i=0; i<array.Length;i++){
        array[i] = new Random().Next(0, 500); // ограничил рандом до 500 чтобы небыло заоблачных чисел
    }
}

