/*
Задача 28. На вход число N и выдает произведение чисел от 1 до N (4-> 24)
*/

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData = Convert.ToInt32(Console.ReadLine());
    return userData;
}
int getMultiplic(int start, int end)
{
    int multip = 1;
    for (int i = start; i <= end; i++)
    {
        multip = multip*i;
    }
    return multip;
}
void showData(string messageStart, int data)
{
    Console.Write(messageStart);
    Console.Write(data);
}
int end = getUserData("Введите число N ");
int multip = getMultiplic(1, end);
showData($"Произведение чисел от 1 до {end} = ", multip);