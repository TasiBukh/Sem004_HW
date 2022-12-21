// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.WriteLine("Введи числа, раздели запятой: ");
string seriesOfNumbers = Console.ReadLine();

seriesOfNumbers = seriesOfNumbers + ",";

string RemovingSpaces (string series)
{
    string seriesNew = "";
    for (int i = 0; i < series.Length; i++)
    {
        if (series[i] != ' ')
        {
            seriesNew += series[i];
        }
    }
    return seriesNew;
}

void CheckNumber2 (int series)
{
    if (series == '0'||series == '1'||series == '2'
    ||series == '3'||series == '4'||series == '5'||series == '6'
    ||series == '7'||series == '8'||series == '9'|| series == ','
    ||series == '-')
    {

    }
    else
    {
        Console.WriteLine($"Ошибка ввода, введи цифры.");
    }
}

int[] ArrayOfNumbers(string seriesNew)
{
    int[] arrayOfNumbers = new int[1];
    int j = 0;

    for (int i = 0; i < seriesNew.Length; i++)
        {
            string seriesNew1 = "";

            while (seriesNew1[i] != ',' && i < seriesNew1.Length)
                {
                    seriesNew1 += seriesNew1[i];
                    CheckNumber2(seriesNew1[i]);
                    i++;
                }
            arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);
            if (i < seriesNew1.Length - 1)
                {
                    arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();
                }
            j++;
        }
        return arrayOfNumbers;
}

void PrintArray(int[] coll)
{
    int count = coll.Length;
    int index = 0;
    Console.WriteLine("[");
    while(index< count)
    {
        Console.WriteLine(coll[index]);
        index++;
        if(index < count)
        {
            Console.WriteLine(", ");
        }
    }
    Console.WriteLine("]");
}

string seriesNew = RemovingSpaces(seriesOfNumbers);
int[] arrayOfNumbers = ArrayOfNumbers(seriesNew);
PrintArray(arrayOfNumbers);