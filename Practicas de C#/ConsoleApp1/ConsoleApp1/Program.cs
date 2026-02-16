// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// console.WriteLine("Escribe un numero"); // parecida a System.out.println de java
// int n1 = Convert.ToInt32(console.ReadLine()); // Scanner BuffereadReader en java

// if ()
// {
// }

// if else

// swicht

// for 

// while



// hacer un programa que lea 4 numero y calcule el promedio

using System;

int n1, n2, n3, n4;
float prom = 0.0f;

Console.WriteLine("Escribe 4 numeros");

n1 = Convert.ToInt32(Console.ReadLine());
n2 = Convert.ToInt32(Console.ReadLine());
n3 = Convert.ToInt32(Console.ReadLine());
n4 = Convert.ToInt32(Console.ReadLine());

prom = (float)(n1 + n2 + n3 + n4);
Console.WriteLine("Promedio es: " + prom);

