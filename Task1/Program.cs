// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введи число N: ");
int numberN = int.Parse(Console.ReadLine());

int SumNumber(int numberN)
{
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        advance = numberN - numberN % 10;
        result = result + (numberN - advance);
        numberN = numberN / 10;
    }
    return result;
}

int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр: " + sumNumber);