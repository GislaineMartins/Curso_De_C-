﻿using System;
using System.ComponentModel;

//Problema motivador 1 (reuso)

//Deseja - se fazer um programa que leia um conjunto de N números inteiros (N de 1 a 10), e depois imprima esses números de forma organizada conforme exemplo. Em seguida, informar qual foi o primeiro valor informado.

//EXEMPLO:
//How many values? 3
//10
//8
//23
//Saida:
//[10,8,23]
//First: 10

namespace Aula01 {
    class Program {
        static void Main(string[] args) {
            PrintService<int> printService = new PrintService<int>();

            Console.WriteLine("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i =0; i<n;i++) {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }
            
            printService.Print();
            Console.WriteLine("First: "+printService.First());
        }
    }
}
