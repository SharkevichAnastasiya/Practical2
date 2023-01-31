// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
/*
int numberA = 5;
int numberB = 7;
int result = numberA < numberB ? numberB : numberA ;
if (numberA < numberB)
{
    result = numberB;
}
else
{
    result = numberA;
}
Console.WriteLine(result);

// ---------------

numberA = 2;
numberB = 10;
result = numberA < numberB ? numberB : numberA ;
if (numberA < numberB)
{
    result = numberB;
}
else
{
    result = numberA;
}
Console.WriteLine(result);

//----------------

numberA = -9;
numberB = -3;
result = numberA < numberB ? numberB : numberA ;
if (numberA < numberB)
{
    result = numberB;
}
else
{
    result = numberA;
}
Console.WriteLine(result);

*/


//  Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

/*

int numberA = 2;
int numberB = 3;
int numberC = 7;
int result;
if (numberA > numberB)
{
    result = numberB;
}
else
{
    result = numberA;
}
if (numberB > numberC)
{
    result = numberB;
}
else 
{
    result = numberC;
}
Console.WriteLine(result);

//----------------
numberA = 44;
numberB = 5;
numberC = 78;
int result2;
if (numberA > numberB)
{
    result = numberB;
}
else
{
    result = numberA;
}
if (numberB > numberC)
{
    result = numberB;
}
else 
{
    result = numberC;
}
Console.WriteLine(result);

//------------------

numberA = 22;
numberB = 3;
numberC = 9;
int result3;
if (numberA > numberB)
{
    result = numberA;
}
else
{
    result = numberB;
}
if (numberB > numberC)
{
    result = numberB;
}
else 
{
    result = numberC;
}
if (numberA > numberC)
{
    result = numberA;
}
else
{
    result = numberC;
}

Console.WriteLine(result);

*/

//-----------

// Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
//(делится ли оно на два без остатка).
//  4 -> да
// -3 -> нет
//  7 -> нет

/*
int numberA = 4;
int numberB = -3;
int numberC = 7;

if (numberA % 2 == 0)
{
    Console.WriteLine("Try");
}
else
{
    Console.WriteLine("false");
}

if (numberB % 2 == 0)
{
    Console.WriteLine("Try");
}
else
{
    Console.WriteLine("false");
}
if (numberC % 2 ==0)
{
    Console.WriteLine("Try");
}
else
{
    Console.WriteLine("false");
}
*/

//------------------

// Задача 4. Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
/*

int current = 1;
int n = Convert.ToInt32(Console.ReadLine());

while(current <= n)
{
    if ( current % 2 == 0)
    {
    Console.Write(current + " ");
    }
    current++;
}
*/
