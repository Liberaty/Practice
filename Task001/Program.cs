// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
int Prompt(string message)
{
    System.Console.Write(message);                                                  // вывести сообщение
    string readValue = Console.ReadLine();                                          // считывает строку с консоли
    int result = int.Parse(readValue);                                              // преобразует строку в целое число
    return result;                                                                  // возвращает результат
}

int value;                                                                          // объявляем переменную
value = Prompt("Введите число: ");                                                  // вводим значение
int result = value * value;                                                         // вычисляем квадрат
System.Console.WriteLine($"Квадрат числа {value} равен {result}");                  // Вывод результата