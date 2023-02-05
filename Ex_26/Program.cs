/*
Задача 26. На вход число и на выходе выдает количество цифр в числе (456->3)
*/

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData = Convert.ToInt32(Console.ReadLine());
    return userData;
}
int getNumberOfDigit(int number)
{
    int numberOfDigit = 0;
    while (number > 0)
    {
        number = number / 10;
        numberOfDigit++;
    }
    return numberOfDigit;
}
void showData(string messageStart, int data)
{
    Console.Write(messageStart);
    Console.Write(data);
}
int number = getUserData("Введите число ");
int numberOfDigit = getNumberOfDigit(number);
showData($"В числе {number} количество цифр = ", numberOfDigit);