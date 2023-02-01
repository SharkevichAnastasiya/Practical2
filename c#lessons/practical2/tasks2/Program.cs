// Задача 1. Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
/*
Console.Write("Input a three-digit number: ");
int threeDititNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDititNumber);
Console.WriteLine("Second digit number " + stringNumber[1]);
*/

////----------------------------------------------------

// Задача 2. Напишите программу, которая выводит третью цифру заданного числа.
//645 -> 5
//32679 -> 6
//21 -> -1
/*
Console.Write("Input a number: ");
int Number = Convert.ToInt32(Console.ReadLine());
string NumberText = Convert.ToString(Number);
if(NumberText.Length >2)
{
    Console.WriteLine("three number " + NumberText[2]);

}
else
{
    Console.WriteLine(" -1 ");
}

*/

////----------------------------------------------------

//  Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет


/*
Console.Write("Input number:");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingDayOfWeek(int dayNumber)
{
    if(dayNumber== 6 || dayNumber == 7)
    {
        Console.WriteLine("It`s a day off");
    }
    else if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("It`s not a day of the week");
    }
    else
    {
        Console.WriteLine("this day is not a day off");
        
    }
}
 CheckingDayOfWeek(dayNumber);
*/



