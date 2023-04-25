//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа 
//в промежутке от M до N с помощью рекурсии.
//M = 1; N = 5 -> "2, 4"
//M = 4; N = 8 -> "4, 6, 8"


int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void OutputOfNaturalNumbers(int number)
{
    if (number == 1)
    {
        Console.WriteLine(number + ";");
    }
    else
    {
        Console.Write(number + ", ");
        OutputOfNaturalNumbers(--number);
    }
}


int number = InputNumberWithMessage("Введите число N: ");


OutputOfNaturalNumbers(number);
