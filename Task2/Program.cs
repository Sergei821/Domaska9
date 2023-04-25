//Задача 2: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8 -> 30


int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SummationNaturalNumbers(int number, int number2)
{

    if (number == number2)
    {
        Console.WriteLine(number);
        return number;
    }
    else
    {
        if (number > number2)
        {
            Console.WriteLine(number);
            return number + SummationNaturalNumbers(--number, number2);
            
        }
        else
        {
            Console.WriteLine(number);
            return number + SummationNaturalNumbers(++number, number2);            
        }
    }
}


int number = InputNumberWithMessage("Введите число N: ");
int number2 = InputNumberWithMessage("Введите число M: ");


Console.WriteLine($"Сумма всех натуральных чисел от {number} до {number2} = {SummationNaturalNumbers(number, number2)}");


