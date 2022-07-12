//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
void FillArray(int[] massive)
{
    int length = massive.Length;
    for (int index = 0; index < length; index++)
    {
        massive[index]= new Random().Next(1, 100);
    }
}

void GetSumOdds(int[] mass)
{
    int sumodds = 0; 
    foreach(var element in mass)
    {
        if(element % 2 != 0)
        {
            sumodds + = element;
        }

    }
    return sumodds;

}

int[] array = new int[100];

FillArray(array);
int result = GetSumOdds(array);
Console.WriteLine(result);