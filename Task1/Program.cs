// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
void FillArray(int[] massive)
{
    int length = massive.Length;
    var random = new Random();
    for (int index = 0; index < length; index++)
    {
        massive[index]= random.Next(100, 999);
    }
}
void PrintArray(int[] collection)
{
    int count = collection.Length;
    for( int position = 0; position < count; position++)
    {
        Console.WriteLine(collection[position]);
    }

}

int GetEvenNumbers(int[] mass)
{   
    int evencount = 0;
    foreach(var element in mass)
    {
        if (element % 2 == 0)
        {  
            evencount+=1; 
        }
        
    }
    return evencount;
}

int[] array = new int[100];

FillArray(array);
int result = GetEvenNumbers(array);
Console.WriteLine(result);