//Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 3, n = 2 -> A(m,n) = 29


int InputNumberWithMessage(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int FunctionAckerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return FunctionAckerman(n - 1, 1);
    else
        return FunctionAckerman(n - 1, FunctionAckerman(n, m - 1));

}


int number = InputNumberWithMessage("Введите число N: ");
int number2 = InputNumberWithMessage("Введите число M: ");


Console.WriteLine($"Результат работы функции Аккремана A({number}, {number2}) = {FunctionAckerman(number, number2)}");
