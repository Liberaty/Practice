// Написать задачу которая по номеру выдаёт название дня недели.

int Prompt(string message)
{
    System.Console.Write(message);                                                  // вывести сообщение
    string readValue = Console.ReadLine();                                          // считывает строку с консоли
    int result = int.Parse(readValue);                                              // преобразует строку в целое число
    return result;                                                                  // возвращает результат
}

int dayNum = Prompt("Введите номер дня недели: ");
if (dayNum == 1) {
    System.Console.WriteLine("Понедельник");
} else if (dayNum == 2) {
    System.Console.WriteLine("Вторник");
} else if (dayNum == 3) {
    System.Console.WriteLine("Среда");
} else if (dayNum == 4) {
    System.Console.WriteLine("Четверг");
} else if (dayNum == 5) {
    System.Console.WriteLine("Пятница");
} else if (dayNum == 6) {
    System.Console.WriteLine("Суббота");
} else if (dayNum == 7) {
    System.Console.WriteLine("Воскресенье");
} else {
    System.Console.WriteLine("Неверное число! Введите числа от 1 до 7");
}