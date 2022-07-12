// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
void FillArray(int[] massive)
{
    int length = massive.Length;
    for (int index = 0; index < length; index++)
    {
        massive[index]= new.Random().Next(100, 110);
    }
}
void PrintArray(int[] collection)
{
    int count = collection.Length;
    for( int position = 0; position < count; position++)
    {
        Console.Writeline(collection[position]);
    }

}

int GetOddNumber(int[element] mass)
{   int element = 100;
    int rate = mass.Length;
    for(int location = 0; location < rate; rate++)
    {
        if (element % 2 ==0)
        {
            Console.Writeline(element);
            element+=2; 
        }
        
    }

}

int[] array = new int[];

FillArray(array);
PrintArray(array);